
namespace serverwin
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Frist = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.TextBox();
            this.sent = new System.Windows.Forms.Button();
            this.userbox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "启动服务器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frist
            // 
            this.Frist.Location = new System.Drawing.Point(12, 60);
            this.Frist.Multiline = true;
            this.Frist.Name = "Frist";
            this.Frist.Size = new System.Drawing.Size(667, 209);
            this.Frist.TabIndex = 1;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(12, 317);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(667, 21);
            this.send.TabIndex = 2;
            // 
            // sent
            // 
            this.sent.Location = new System.Drawing.Point(713, 315);
            this.sent.Name = "sent";
            this.sent.Size = new System.Drawing.Size(75, 23);
            this.sent.TabIndex = 3;
            this.sent.Text = "发送";
            this.sent.UseVisualStyleBackColor = true;
            this.sent.Click += new System.EventHandler(this.sent_Click);
            // 
            // userbox
            // 
            this.userbox.FormattingEnabled = true;
            this.userbox.Location = new System.Drawing.Point(118, 288);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(121, 20);
            this.userbox.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "接收人：";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.sent);
            this.Controls.Add(this.send);
            this.Controls.Add(this.Frist);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Frist;
        private System.Windows.Forms.TextBox send;
        private System.Windows.Forms.Button sent;
        private System.Windows.Forms.ComboBox userbox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

