
namespace 员工信息管理系统
{
    partial class Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.YGXM = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.YGBM = new System.Windows.Forms.TextBox();
            this.YGGH = new System.Windows.Forms.TextBox();
            this.YGZW = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(201, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(657, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "修改员工信息";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "员工姓名";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // YGXM
            // 
            this.YGXM.Location = new System.Drawing.Point(257, 75);
            this.YGXM.Name = "YGXM";
            this.YGXM.Size = new System.Drawing.Size(230, 25);
            this.YGXM.TabIndex = 2;
            this.YGXM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "员工工号";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(70, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "员工部门";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(493, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 55);
            this.button5.TabIndex = 5;
            this.button5.Text = "员工职务";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // YGBM
            // 
            this.YGBM.Location = new System.Drawing.Point(257, 236);
            this.YGBM.Name = "YGBM";
            this.YGBM.Size = new System.Drawing.Size(230, 25);
            this.YGBM.TabIndex = 6;
            this.YGBM.TextChanged += new System.EventHandler(this.YGBM_TextChanged);
            // 
            // YGGH
            // 
            this.YGGH.Location = new System.Drawing.Point(680, 77);
            this.YGGH.Name = "YGGH";
            this.YGGH.Size = new System.Drawing.Size(245, 25);
            this.YGGH.TabIndex = 7;
            // 
            // YGZW
            // 
            this.YGZW.Location = new System.Drawing.Point(680, 236);
            this.YGZW.Name = "YGZW";
            this.YGZW.Size = new System.Drawing.Size(245, 25);
            this.YGZW.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 55);
            this.button6.TabIndex = 9;
            this.button6.Text = "完成";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(619, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 55);
            this.button7.TabIndex = 10;
            this.button7.Text = "取消";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1110, 569);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.YGZW);
            this.Controls.Add(this.YGGH);
            this.Controls.Add(this.YGBM);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.YGXM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Modify";
            this.Text = "Modify";
            this.Load += new System.EventHandler(this.Modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox YGXM;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox YGBM;
        private System.Windows.Forms.TextBox YGGH;
        private System.Windows.Forms.TextBox YGZW;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}