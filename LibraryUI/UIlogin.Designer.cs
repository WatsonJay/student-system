namespace LibraryUI
{
    partial class UIlogin
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
            this.information = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cameraupload = new System.Windows.Forms.Label();
            this.qq = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.passwordcheck = new System.Windows.Forms.Label();
            this.usercheck = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.repassword = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.stuname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.localupload = new System.Windows.Forms.Label();
            this.courage = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stuid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.information.SuspendLayout();
            this.head.SuspendLayout();
            this.SuspendLayout();
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.Transparent;
            this.information.Controls.Add(this.label12);
            this.information.Controls.Add(this.head);
            this.information.Controls.Add(this.cameraupload);
            this.information.Controls.Add(this.qq);
            this.information.Controls.Add(this.label15);
            this.information.Controls.Add(this.passwordcheck);
            this.information.Controls.Add(this.usercheck);
            this.information.Controls.Add(this.label14);
            this.information.Controls.Add(this.label13);
            this.information.Controls.Add(this.password);
            this.information.Controls.Add(this.repassword);
            this.information.Controls.Add(this.phone);
            this.information.Controls.Add(this.stuname);
            this.information.Controls.Add(this.name);
            this.information.Controls.Add(this.localupload);
            this.information.Controls.Add(this.courage);
            this.information.Controls.Add(this.label11);
            this.information.Controls.Add(this.label10);
            this.information.Controls.Add(this.label9);
            this.information.Controls.Add(this.label8);
            this.information.Controls.Add(this.label7);
            this.information.Controls.Add(this.label6);
            this.information.Controls.Add(this.label5);
            this.information.Controls.Add(this.label4);
            this.information.Controls.Add(this.stuid);
            this.information.Controls.Add(this.label3);
            this.information.Controls.Add(this.label2);
            this.information.Controls.Add(this.label1);
            this.information.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.information.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.information.Location = new System.Drawing.Point(56, 138);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(614, 342);
            this.information.TabIndex = 0;
            this.information.TabStop = false;
            this.information.Text = "基本信息";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(303, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 14);
            this.label12.TabIndex = 33;
            this.label12.Text = "*号为必填内容";
            // 
            // head
            // 
            this.head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.head.Controls.Add(this.panel1);
            this.head.Location = new System.Drawing.Point(418, 18);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(124, 124);
            this.head.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LibraryUI.Properties.Resources.QQ截图20170225205535;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 124);
            this.panel1.TabIndex = 33;
            // 
            // cameraupload
            // 
            this.cameraupload.AutoSize = true;
            this.cameraupload.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cameraupload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cameraupload.Location = new System.Drawing.Point(501, 157);
            this.cameraupload.Name = "cameraupload";
            this.cameraupload.Size = new System.Drawing.Size(53, 12);
            this.cameraupload.TabIndex = 31;
            this.cameraupload.Text = "拍照上传";
            this.cameraupload.Click += new System.EventHandler(this.cameraupload_Click);
            this.cameraupload.MouseEnter += new System.EventHandler(this.cameraupload_MouseEnter);
            this.cameraupload.MouseLeave += new System.EventHandler(this.cameraupload_MouseLeave);
            // 
            // qq
            // 
            this.qq.Location = new System.Drawing.Point(114, 290);
            this.qq.MaxLength = 15;
            this.qq.Name = "qq";
            this.qq.Size = new System.Drawing.Size(165, 29);
            this.qq.TabIndex = 30;
            this.qq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qq_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(46, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 19);
            this.label15.TabIndex = 29;
            this.label15.Text = "qq：";
            // 
            // passwordcheck
            // 
            this.passwordcheck.AutoSize = true;
            this.passwordcheck.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordcheck.ForeColor = System.Drawing.Color.Crimson;
            this.passwordcheck.Location = new System.Drawing.Point(416, 284);
            this.passwordcheck.Name = "passwordcheck";
            this.passwordcheck.Size = new System.Drawing.Size(0, 12);
            this.passwordcheck.TabIndex = 28;
            // 
            // usercheck
            // 
            this.usercheck.AutoSize = true;
            this.usercheck.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usercheck.ForeColor = System.Drawing.Color.Crimson;
            this.usercheck.Location = new System.Drawing.Point(285, 48);
            this.usercheck.Name = "usercheck";
            this.usercheck.Size = new System.Drawing.Size(0, 12);
            this.usercheck.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(303, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(303, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "*";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(418, 190);
            this.password.MaxLength = 50;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(165, 29);
            this.password.TabIndex = 24;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // repassword
            // 
            this.repassword.Location = new System.Drawing.Point(418, 242);
            this.repassword.MaxLength = 50;
            this.repassword.Name = "repassword";
            this.repassword.Size = new System.Drawing.Size(165, 29);
            this.repassword.TabIndex = 23;
            this.repassword.UseSystemPasswordChar = true;
            this.repassword.TextChanged += new System.EventHandler(this.repassword_TextChanged);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(114, 242);
            this.phone.MaxLength = 15;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(165, 29);
            this.phone.TabIndex = 22;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // stuname
            // 
            this.stuname.Location = new System.Drawing.Point(114, 89);
            this.stuname.MaxLength = 50;
            this.stuname.Name = "stuname";
            this.stuname.Size = new System.Drawing.Size(165, 29);
            this.stuname.TabIndex = 21;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(114, 39);
            this.name.MaxLength = 50;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 29);
            this.name.TabIndex = 20;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // localupload
            // 
            this.localupload.AutoSize = true;
            this.localupload.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.localupload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.localupload.Location = new System.Drawing.Point(398, 157);
            this.localupload.Name = "localupload";
            this.localupload.Size = new System.Drawing.Size(53, 12);
            this.localupload.TabIndex = 19;
            this.localupload.Text = "本地上传";
            this.localupload.Click += new System.EventHandler(this.localupload_Click);
            this.localupload.MouseEnter += new System.EventHandler(this.localupload_MouseEnter);
            this.localupload.MouseLeave += new System.EventHandler(this.localupload_MouseLeave);
            // 
            // courage
            // 
            this.courage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courage.FormattingEnabled = true;
            this.courage.Items.AddRange(new object[] {
            "机械工程学院",
            "计算机学院",
            "通信工程学院",
            "美术学院",
            "人文学院"});
            this.courage.Location = new System.Drawing.Point(114, 190);
            this.courage.Name = "courage";
            this.courage.Size = new System.Drawing.Size(165, 27);
            this.courage.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(33, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(33, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(33, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(33, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(46, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(315, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "确认密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(315, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "密    码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(46, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "学院：";
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(114, 140);
            this.stuid.MaxLength = 10;
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(165, 29);
            this.stuid.TabIndex = 5;
            this.stuid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stuid_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(46, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称：";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(186, 506);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(140, 41);
            this.login.TabIndex = 1;
            this.login.Text = "注册";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancle
            // 
            this.cancle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancle.Location = new System.Drawing.Point(393, 506);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(140, 41);
            this.cancle.TabIndex = 2;
            this.cancle.Text = "取消";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // UIlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUI.Properties.Resources.login4;
            this.ClientSize = new System.Drawing.Size(682, 639);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.login);
            this.Controls.Add(this.information);
            this.MaximizeBox = false;
            this.Name = "UIlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIlogin_closeing);
            this.Load += new System.EventHandler(this.UIlogin_Load);
            this.information.ResumeLayout(false);
            this.information.PerformLayout();
            this.head.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stuname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label localupload;
        private System.Windows.Forms.ComboBox courage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stuid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox repassword;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label passwordcheck;
        private System.Windows.Forms.Label usercheck;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.TextBox qq;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label cameraupload;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1; //选取头像
    }
}