namespace LibraryUI_rebuild
{
    partial class UIheadchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIheadchange));
            this.head = new System.Windows.Forms.Panel();
            this.headchanged = new System.Windows.Forms.Panel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.cameraload = new CCWin.SkinControl.SkinLabel();
            this.localload = new CCWin.SkinControl.SkinLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cancle = new CCWin.SkinControl.SkinButton();
            this.sure = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.Transparent;
            this.head.BackgroundImage = global::LibraryUI_rebuild.Properties.Resources.none;
            this.head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.head.Location = new System.Drawing.Point(33, 81);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(104, 104);
            this.head.TabIndex = 16;
            // 
            // headchanged
            // 
            this.headchanged.BackColor = System.Drawing.Color.Transparent;
            this.headchanged.BackgroundImage = global::LibraryUI_rebuild.Properties.Resources.none;
            this.headchanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.headchanged.Location = new System.Drawing.Point(228, 81);
            this.headchanged.Name = "headchanged";
            this.headchanged.Size = new System.Drawing.Size(104, 104);
            this.headchanged.TabIndex = 17;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(64, 52);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 18;
            this.skinLabel1.Text = "更换前";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(258, 52);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 19;
            this.skinLabel2.Text = "更换后";
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.BackgroundImage")));
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(150, 99);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(68, 68);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox1.TabIndex = 21;
            this.skinPictureBox1.TabStop = false;
            // 
            // cameraload
            // 
            this.cameraload.AutoSize = true;
            this.cameraload.BackColor = System.Drawing.Color.Transparent;
            this.cameraload.BorderColor = System.Drawing.Color.White;
            this.cameraload.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cameraload.Location = new System.Drawing.Point(110, 209);
            this.cameraload.Name = "cameraload";
            this.cameraload.Size = new System.Drawing.Size(56, 17);
            this.cameraload.TabIndex = 22;
            this.cameraload.Text = "相机上传";
            this.cameraload.Click += new System.EventHandler(this.cameraload_Click);
            this.cameraload.MouseEnter += new System.EventHandler(this.cameraload_MouseEnter);
            this.cameraload.MouseLeave += new System.EventHandler(this.cameraload_MouseLeave);
            this.cameraload.MouseHover += new System.EventHandler(this.cameraload_MouseHover);
            // 
            // localload
            // 
            this.localload.AutoSize = true;
            this.localload.BackColor = System.Drawing.Color.Transparent;
            this.localload.BorderColor = System.Drawing.Color.White;
            this.localload.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.localload.Location = new System.Drawing.Point(199, 209);
            this.localload.Name = "localload";
            this.localload.Size = new System.Drawing.Size(56, 17);
            this.localload.TabIndex = 23;
            this.localload.Text = "本地上传";
            this.localload.Click += new System.EventHandler(this.localload_Click);
            this.localload.MouseEnter += new System.EventHandler(this.localload_MouseEnter);
            this.localload.MouseLeave += new System.EventHandler(this.localload_MouseLeave);
            this.localload.MouseHover += new System.EventHandler(this.localload_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cancle
            // 
            this.cancle.BackColor = System.Drawing.Color.Transparent;
            this.cancle.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cancle.DownBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_down;
            this.cancle.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.cancle.Location = new System.Drawing.Point(202, 247);
            this.cancle.MouseBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_hover;
            this.cancle.Name = "cancle";
            this.cancle.NormlBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_normal;
            this.cancle.Size = new System.Drawing.Size(88, 23);
            this.cancle.TabIndex = 47;
            this.cancle.Text = "取消";
            this.cancle.UseVisualStyleBackColor = false;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // sure
            // 
            this.sure.BackColor = System.Drawing.Color.Transparent;
            this.sure.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sure.DownBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_down;
            this.sure.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.sure.Location = new System.Drawing.Point(78, 247);
            this.sure.MouseBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_hover;
            this.sure.Name = "sure";
            this.sure.NormlBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_normal;
            this.sure.Size = new System.Drawing.Size(88, 23);
            this.sure.TabIndex = 46;
            this.sure.Text = "确认";
            this.sure.UseVisualStyleBackColor = false;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // UIheadchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUI_rebuild.Properties.Resources._3db11210366998daacff2d9419348b70;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 294);
            this.CloseDownBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_disable;
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.localload);
            this.Controls.Add(this.cameraload);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.headchanged);
            this.Controls.Add(this.head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIheadchange";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.headchange_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Panel headchanged;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinLabel cameraload;
        private CCWin.SkinControl.SkinLabel localload;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton cancle;
        private CCWin.SkinControl.SkinButton sure;
    }
}