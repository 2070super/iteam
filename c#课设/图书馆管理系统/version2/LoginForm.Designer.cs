
namespace demo01
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zhanghao = new System.Windows.Forms.TextBox();
            this.mima = new System.Windows.Forms.TextBox();
            this.radiouser = new System.Windows.Forms.RadioButton();
            this.radiomanager = new System.Windows.Forms.RadioButton();
            this.login = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(288, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(162, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(162, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "账户";
            // 
            // zhanghao
            // 
            this.zhanghao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhanghao.Location = new System.Drawing.Point(253, 136);
            this.zhanghao.Name = "zhanghao";
            this.zhanghao.Size = new System.Drawing.Size(264, 30);
            this.zhanghao.TabIndex = 3;
            // 
            // mima
            // 
            this.mima.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mima.Location = new System.Drawing.Point(253, 205);
            this.mima.Name = "mima";
            this.mima.Size = new System.Drawing.Size(264, 30);
            this.mima.TabIndex = 4;
            // 
            // radiouser
            // 
            this.radiouser.AutoSize = true;
            this.radiouser.BackColor = System.Drawing.Color.Transparent;
            this.radiouser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radiouser.Location = new System.Drawing.Point(165, 278);
            this.radiouser.Name = "radiouser";
            this.radiouser.Size = new System.Drawing.Size(70, 24);
            this.radiouser.TabIndex = 5;
            this.radiouser.TabStop = true;
            this.radiouser.Text = "用户";
            this.radiouser.UseVisualStyleBackColor = false;
            // 
            // radiomanager
            // 
            this.radiomanager.AutoSize = true;
            this.radiomanager.BackColor = System.Drawing.Color.Transparent;
            this.radiomanager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radiomanager.Location = new System.Drawing.Point(383, 278);
            this.radiomanager.Name = "radiomanager";
            this.radiomanager.Size = new System.Drawing.Size(90, 24);
            this.radiomanager.TabIndex = 6;
            this.radiomanager.TabStop = true;
            this.radiomanager.Text = "管理员";
            this.radiomanager.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(327, 347);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(105, 44);
            this.login.TabIndex = 7;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear.Location = new System.Drawing.Point(560, 347);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(105, 44);
            this.clear.TabIndex = 8;
            this.clear.Text = "重置";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(106, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::demo01.Properties.Resources.mmexport1607336742216;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.login);
            this.Controls.Add(this.radiomanager);
            this.Controls.Add(this.radiouser);
            this.Controls.Add(this.mima);
            this.Controls.Add(this.zhanghao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zhanghao;
        private System.Windows.Forms.TextBox mima;
        private System.Windows.Forms.RadioButton radiouser;
        private System.Windows.Forms.RadioButton radiomanager;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button1;
    }
}