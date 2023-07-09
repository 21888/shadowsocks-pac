using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Masuit.Tools;
using Masuit.Tools.Files;

namespace ShadowsocksPac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        INIFile ini = new INIFile(System.AppDomain.CurrentDomain.BaseDirectory + "config.ini");

        private void ProgramInits()
        {
            textBox_path.Text = ini.IniReadValue("shadowsocks", "path");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgramInits();
        }

        private void textBox_path_TextChanged(object sender, EventArgs e)
        {
            ini.IniWriteValue("shadowsocks", "path", textBox_path.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取域名
            var domain = getDomain();
            if (domain == "")
            {
                MessageBox.Show("请输入正确的网址");
                return;
            }

            // 读入txt文件
            string[] lines = System.IO.File.ReadAllLines(textBox_path.Text + "\\pac.txt");
            // 判断是否包含域名
            if (lines.Any(s => s.Contains(domain)))
            {
                // 提示是否删除
                DialogResult dr = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    // 删除
                    lines = lines.Where(s => !s.Contains(domain)).ToArray();
                    // 保存
                    System.IO.File.WriteAllLines(textBox_path.Text + "\\pac.txt", lines);
                    MessageBox.Show("删除成功");
                    RestartShadowsocks();
                }

                return;
            }

            for (var i = 0; i < lines.Length; i++)
            {
                // 判断是否为@@||local
                if (lines[i].Contains("@@||local"))
                {
                    // 插入
                    lines[i] = lines[i] + $"\r\n  \"@@||{domain}\",";
                    // 保存
                    System.IO.File.WriteAllLines(textBox_path.Text + "\\pac.txt", lines);
                    MessageBox.Show("添加成功");
                    RestartShadowsocks();
                    return;
                }
            }
        }

        /// <summary>
        /// 获取域名
        /// </summary>
        /// <returns>domain</returns>
        string getDomain()
        {
            // 判断网址是否正确
            bool isUrl = textBox_path.Text.MatchUrl();
            if (!isUrl)
            {
                MessageBox.Show("网址不正确");
                return "";
            }

            // 将网址转换为域名
            string url = textBox_url.Text;
            Uri uri = new Uri(url);
            string domain = uri.Host;
            // 判断域名是否正确
            if (domain == "")
            {
                MessageBox.Show("域名不正确");
                return domain;
                ;
            }

            // 判断文件是否存在
            if (!System.IO.File.Exists(textBox_path.Text + "\\pac.txt"))
            {
                MessageBox.Show("pac.txt文件不存在");
            }

            return domain;
        }

        /// <summary>
        /// 重启进程
        /// </summary>
        void RestartShadowsocks()
        {
            // 重启进程 Shadowsocks.exe
            Process[] processes = Process.GetProcessesByName("Shadowsocks");
            foreach (Process process in processes)
            {
                process.Kill();
            }

            Process.Start(textBox_path.Text + "\\Shadowsocks.exe");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox_url.Focus();
        }
    }
}