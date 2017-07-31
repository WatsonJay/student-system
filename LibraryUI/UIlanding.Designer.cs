namespace LibraryUI
{
    partial class UIlanding
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIlanding));
            this.userlabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.land = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Panel();
            this.circle = new System.Windows.Forms.Panel();
            this.usercheck = new System.Windows.Forms.Label();
            this.head.SuspendLayout();
            this.SuspendLayout();
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.BackColor = System.Drawing.Color.Transparent;
            this.userlabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userlabel.Location = new System.Drawing.Point(164, 99);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(89, 19);
            this.userlabel.TabIndex = 0;
            this.userlabel.Text = "用户名：";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordlabel.Location = new System.Drawing.Point(164, 156);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(91, 19);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "密  码：";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user.Location = new System.Drawing.Point(259, 96);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(159, 29);
            this.user.TabIndex = 2;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(259, 153);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(159, 29);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // land
            // 
            this.land.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.land.Location = new System.Drawing.Point(56, 219);
            this.land.Name = "land";
            this.land.Size = new System.Drawing.Size(88, 27);
            this.land.TabIndex = 4;
            this.land.Text = "登  陆";
            this.land.UseVisualStyleBackColor = true;
            this.land.Click += new System.EventHandler(this.land_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(195, 219);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(88, 27);
            this.login.TabIndex = 5;
            this.login.Text = "注  册";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancle
            // 
            this.cancle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancle.Location = new System.Drawing.Point(331, 219);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(88, 27);
            this.cancle.TabIndex = 6;
            this.cancle.Text = "取  消";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.Transparent;
            this.head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.head.Controls.Add(this.circle);
            this.head.Location = new System.Drawing.Point(34, 87);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(100, 100);
            this.head.TabIndex = 7;
            this.head.Paint += new System.Windows.Forms.PaintEventHandler(this.head_Paint);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.Transparent;
            this.circle.BackgroundImage = global::LibraryUI.Properties.Resources.QQ截图20170225211125;
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circle.Location = new System.Drawing.Point(44, 12);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(100, 100);
            this.circle.TabIndex = 34;
            this.circle.Paint += new System.Windows.Forms.PaintEventHandler(this.circle_Paint);
            // 
            // usercheck
            // 
            this.usercheck.AutoSize = true;
            this.usercheck.BackColor = System.Drawing.Color.Transparent;
            this.usercheck.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usercheck.ForeColor = System.Drawing.Color.Red;
            this.usercheck.Location = new System.Drawing.Point(265, 134);
            this.usercheck.Name = "usercheck";
            this.usercheck.Size = new System.Drawing.Size(0, 12);
            this.usercheck.TabIndex = 8;
            // 
            // UIlanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUI.Properties.Resources.logn3;
            this.ClientSize = new System.Drawing.Size(493, 292);
            this.Controls.Add(this.usercheck);
            this.Controls.Add(this.head);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.login);
            this.Controls.Add(this.land);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.userlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UIlanding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆系统";
            this.Load += new System.EventHandler(this.UIlanding_Load);
            this.head.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button land;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Panel circle;
        private System.Windows.Forms.Label usercheck;
    }
}

