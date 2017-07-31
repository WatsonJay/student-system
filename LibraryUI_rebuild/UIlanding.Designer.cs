namespace LibraryUI_rebuild
{
    partial class UIlanding
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIlanding));
            this.head = new System.Windows.Forms.Panel();
            this.usertext = new CCWin.SkinControl.SkinWaterTextBox();
            this.user = new CCWin.SkinControl.SkinTextBox();
            this.password = new CCWin.SkinControl.SkinTextBox();
            this.passwordtext = new CCWin.SkinControl.SkinWaterTextBox();
            this.btnlanding = new CCWin.SkinControl.SkinButton();
            this.login = new CCWin.SkinControl.SkinButton();
            this.user.SuspendLayout();
            this.password.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.Transparent;
            this.head.BackgroundImage = global::LibraryUI_rebuild.Properties.Resources.none;
            this.head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.head.Location = new System.Drawing.Point(35, 140);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(80, 80);
            this.head.TabIndex = 8;
            // 
            // usertext
            // 
            this.usertext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usertext.Font = new System.Drawing.Font("宋体", 9.25F);
            this.usertext.Location = new System.Drawing.Point(5, 5);
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(129, 15);
            this.usertext.TabIndex = 9;
            this.usertext.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.usertext.WaterText = "用户名";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Controls.Add(this.usertext);
            this.user.DownBack = null;
            this.user.Icon = null;
            this.user.IconIsButton = false;
            this.user.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.user.IsPasswordChat = '\0';
            this.user.IsSystemPasswordChar = false;
            this.user.Lines = new string[0];
            this.user.Location = new System.Drawing.Point(130, 140);
            this.user.Margin = new System.Windows.Forms.Padding(0);
            this.user.MaxLength = 32767;
            this.user.MinimumSize = new System.Drawing.Size(28, 28);
            this.user.MouseBack = null;
            this.user.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.user.Multiline = false;
            this.user.Name = "user";
            this.user.NormlBack = null;
            this.user.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.user.ReadOnly = false;
            this.user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user.Size = new System.Drawing.Size(162, 28);
            // 
            // 
            // 
            this.user.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.user.SkinTxt.Name = "BaseText";
            this.user.SkinTxt.TabIndex = 0;
            this.user.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.user.SkinTxt.WaterText = "用户名";
            this.user.TabIndex = 10;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.user.WaterText = "用户名";
            this.user.WordWrap = true;
            this.user.Leave += new System.EventHandler(this.skinTextBox1_Leave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Controls.Add(this.passwordtext);
            this.password.DownBack = null;
            this.password.Icon = global::LibraryUI_rebuild.Properties.Resources.imgRjp_BackgroundImage;
            this.password.IconIsButton = true;
            this.password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.password.IsPasswordChat = '●';
            this.password.IsSystemPasswordChar = true;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(130, 182);
            this.password.Margin = new System.Windows.Forms.Padding(0);
            this.password.MaxLength = 32767;
            this.password.MinimumSize = new System.Drawing.Size(28, 28);
            this.password.MouseBack = null;
            this.password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.NormlBack = null;
            this.password.Padding = new System.Windows.Forms.Padding(5, 5, 51, 5);
            this.password.ReadOnly = false;
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.Size = new System.Drawing.Size(162, 28);
            // 
            // 
            // 
            this.password.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.password.SkinTxt.Name = "BaseText";
            this.password.SkinTxt.PasswordChar = '●';
            this.password.SkinTxt.TabIndex = 0;
            this.password.SkinTxt.UseSystemPasswordChar = true;
            this.password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.password.SkinTxt.WaterText = "密码";
            this.password.TabIndex = 12;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.password.WaterText = "密码";
            this.password.WordWrap = true;
            this.password.IconClick += new System.EventHandler(this.password_IconClick);
            // 
            // passwordtext
            // 
            this.passwordtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordtext.Font = new System.Drawing.Font("宋体", 9.25F);
            this.passwordtext.Location = new System.Drawing.Point(5, 5);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(106, 15);
            this.passwordtext.TabIndex = 1;
            this.passwordtext.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordtext.WaterText = "密码";
            // 
            // btnlanding
            // 
            this.btnlanding.BackColor = System.Drawing.Color.Transparent;
            this.btnlanding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlanding.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnlanding.BaseColor = System.Drawing.Color.Black;
            this.btnlanding.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnlanding.DownBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_down;
            this.btnlanding.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnlanding.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnlanding.Location = new System.Drawing.Point(130, 256);
            this.btnlanding.MouseBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_hover;
            this.btnlanding.Name = "btnlanding";
            this.btnlanding.NormlBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_normal;
            this.btnlanding.Palace = true;
            this.btnlanding.Radius = 30;
            this.btnlanding.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnlanding.Size = new System.Drawing.Size(128, 32);
            this.btnlanding.TabIndex = 13;
            this.btnlanding.Text = "登    陆";
            this.btnlanding.UseVisualStyleBackColor = false;
            this.btnlanding.Click += new System.EventHandler(this.landing_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.login.DownBack = global::LibraryUI_rebuild.Properties.Resources.zhuce_press;
            this.login.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.login.Location = new System.Drawing.Point(307, 147);
            this.login.MouseBack = global::LibraryUI_rebuild.Properties.Resources.zhuce_hover;
            this.login.Name = "login";
            this.login.NormlBack = global::LibraryUI_rebuild.Properties.Resources.zhuce;
            this.login.Size = new System.Drawing.Size(45, 15);
            this.login.TabIndex = 14;
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // UIlanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::LibraryUI_rebuild.Properties.Resources.noonSCO;
            this.BackPalace = global::LibraryUI_rebuild.Properties.Resources.BackPalace2;
            this.BackShade = false;
            this.ClientSize = new System.Drawing.Size(381, 295);
            this.CloseDownBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_disable;
            this.Controls.Add(this.login);
            this.Controls.Add(this.btnlanding);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.head);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::LibraryUI_rebuild.Properties.Resources.btn_max_down;
            this.MaximizeBox = false;
            this.MaxMouseBack = global::LibraryUI_rebuild.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::LibraryUI_rebuild.Properties.Resources.btn_max_normal;
            this.MiniDownBack = global::LibraryUI_rebuild.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::LibraryUI_rebuild.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::LibraryUI_rebuild.Properties.Resources.btn_mini_normal;
            this.Name = "UIlanding";
            this.RestoreDownBack = global::LibraryUI_rebuild.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::LibraryUI_rebuild.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::LibraryUI_rebuild.Properties.Resources.btn_restore_normal;
            this.ShowDrawIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
            this.password.ResumeLayout(false);
            this.password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private CCWin.SkinControl.SkinWaterTextBox usertext;
        private CCWin.SkinControl.SkinTextBox user;
        private CCWin.SkinControl.SkinTextBox password;
        private CCWin.SkinControl.SkinWaterTextBox passwordtext;
        private CCWin.SkinControl.SkinButton btnlanding;
        private CCWin.SkinControl.SkinButton login;
    }
}