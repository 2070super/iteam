
namespace 员工信息管理系统
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.YGXM = new System.Windows.Forms.TextBox();
            this.YGGH = new System.Windows.Forms.TextBox();
            this.YGBM = new System.Windows.Forms.TextBox();
            this.YGZW = new System.Windows.Forms.TextBox();
            this.完成 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加员工信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "员工姓名";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(565, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "员工工号";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "员工部门";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(565, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "员工职务";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // YGXM
            // 
            this.YGXM.Location = new System.Drawing.Point(331, 153);
            this.YGXM.Name = "YGXM";
            this.YGXM.Size = new System.Drawing.Size(178, 25);
            this.YGXM.TabIndex = 5;
            this.YGXM.TextChanged += new System.EventHandler(this.YGXM_TextChanged);
            // 
            // YGGH
            // 
            this.YGGH.Location = new System.Drawing.Point(835, 153);
            this.YGGH.Name = "YGGH";
            this.YGGH.Size = new System.Drawing.Size(178, 25);
            this.YGGH.TabIndex = 6;
            // 
            // YGBM
            // 
            this.YGBM.Location = new System.Drawing.Point(331, 234);
            this.YGBM.Name = "YGBM";
            this.YGBM.Size = new System.Drawing.Size(178, 25);
            this.YGBM.TabIndex = 7;
            // 
            // YGZW
            // 
            this.YGZW.Location = new System.Drawing.Point(835, 234);
            this.YGZW.Name = "YGZW";
            this.YGZW.Size = new System.Drawing.Size(178, 25);
            this.YGZW.TabIndex = 8;
            // 
            // 完成
            // 
            this.完成.Location = new System.Drawing.Point(232, 378);
            this.完成.Name = "完成";
            this.完成.Size = new System.Drawing.Size(211, 54);
            this.完成.TabIndex = 9;
            this.完成.Text = "完成";
            this.完成.UseVisualStyleBackColor = true;
            this.完成.Click += new System.EventHandler(this.完成_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(565, 378);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 54);
            this.button7.TabIndex = 10;
            this.button7.Text = "取消";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1087, 562);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.完成);
            this.Controls.Add(this.YGZW);
            this.Controls.Add(this.YGBM);
            this.Controls.Add(this.YGGH);
            this.Controls.Add(this.YGXM);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox YGXM;
        private System.Windows.Forms.TextBox YGGH;
        private System.Windows.Forms.TextBox YGBM;
        private System.Windows.Forms.TextBox YGZW;
        private System.Windows.Forms.Button 完成;
        private System.Windows.Forms.Button button7;
    }
}