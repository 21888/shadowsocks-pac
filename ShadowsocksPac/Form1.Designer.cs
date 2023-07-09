namespace ShadowsocksPac
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.exe = new System.Windows.Forms.Label();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox_path.Location = new System.Drawing.Point(103, 22);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(309, 21);
            this.textBox_path.TabIndex = 0;
            this.textBox_path.TextChanged += new System.EventHandler(this.textBox_path_TextChanged);
            // 
            // exe
            // 
            this.exe.Location = new System.Drawing.Point(17, 22);
            this.exe.Name = "exe";
            this.exe.Size = new System.Drawing.Size(80, 21);
            this.exe.TabIndex = 1;
            this.exe.Text = "安装路径";
            this.exe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_url
            // 
            this.textBox_url.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_url.Location = new System.Drawing.Point(103, 66);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(309, 21);
            this.textBox_url.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "网址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加白名单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.exe);
            this.Controls.Add(this.textBox_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shadowsocks Pac 快捷操作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.TextBox textBox_path;

        private System.Windows.Forms.Button button1;

        public System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label exe;

        #endregion
    }
}