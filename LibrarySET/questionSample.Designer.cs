namespace LibrarySET
{
    partial class questionSample
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.date = new CCWin.SkinControl.SkinLabel();
            this.type = new CCWin.SkinControl.SkinLabel();
            this.questioner = new CCWin.SkinControl.SkinLabel();
            this.Img = new CCWin.SkinControl.SkinPanel();
            this.title = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.BorderColor = System.Drawing.Color.Gray;
            this.date.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(172, 3);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(73, 17);
            this.date.TabIndex = 11;
            this.date.Text = "skinLabel1";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.type.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.ForeColor = System.Drawing.Color.Blue;
            this.type.Location = new System.Drawing.Point(83, 35);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(24, 17);
            this.type.TabIndex = 8;
            this.type.Text = "##";
            // 
            // questioner
            // 
            this.questioner.AutoSize = true;
            this.questioner.BackColor = System.Drawing.Color.Transparent;
            this.questioner.BorderColor = System.Drawing.Color.Gray;
            this.questioner.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.questioner.ForeColor = System.Drawing.Color.White;
            this.questioner.Location = new System.Drawing.Point(83, 3);
            this.questioner.Name = "questioner";
            this.questioner.Size = new System.Drawing.Size(73, 17);
            this.questioner.TabIndex = 7;
            this.questioner.Text = "skinLabel1";
            // 
            // Img
            // 
            this.Img.BackColor = System.Drawing.Color.Transparent;
            this.Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Img.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Img.DownBack = null;
            this.Img.Location = new System.Drawing.Point(3, 3);
            this.Img.MouseBack = null;
            this.Img.Name = "Img";
            this.Img.NormlBack = null;
            this.Img.Size = new System.Drawing.Size(70, 70);
            this.Img.TabIndex = 6;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BorderColor = System.Drawing.Color.Gray;
            this.title.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(142, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(73, 17);
            this.title.TabIndex = 12;
            this.title.Text = "skinLabel2";
            // 
            // questionSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LibrarySET.Properties.Resources._3db11210366998daacff2d9419348b70;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.title);
            this.Controls.Add(this.date);
            this.Controls.Add(this.type);
            this.Controls.Add(this.questioner);
            this.Controls.Add(this.Img);
            this.Name = "questionSample";
            this.Size = new System.Drawing.Size(384, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel date;
        private CCWin.SkinControl.SkinLabel type;
        private CCWin.SkinControl.SkinLabel questioner;
        private CCWin.SkinControl.SkinPanel Img;
        private CCWin.SkinControl.SkinLabel title;

    }
}
