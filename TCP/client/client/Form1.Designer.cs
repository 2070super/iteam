
namespace client
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
            this.address = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.TextBox();
            this.meg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(76, 56);
            this.address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(132, 25);
            this.address.TabIndex = 1;
            this.address.Text = "192.168.3.45";
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(359, 56);
            this.port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(141, 25);
            this.port.TabIndex = 2;
            this.port.Text = "8000";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(-65, 60);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 25);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "IP:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(217, 60);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 18);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "端口：";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 56);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(76, 112);
            this.top.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.top.Multiline = true;
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(667, 220);
            this.top.TabIndex = 6;
            // 
            // meg
            // 
            this.meg.Location = new System.Drawing.Point(76, 371);
            this.meg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.meg.Multiline = true;
            this.meg.Name = "meg";
            this.meg.Size = new System.Drawing.Size(667, 64);
            this.meg.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.meg);
            this.Controls.Add(this.top);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.port);
            this.Controls.Add(this.address);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox top;
        private System.Windows.Forms.TextBox meg;
    }
}

