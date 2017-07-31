namespace LibrarySET
{
    partial class bookcomment
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
            this.Img = new CCWin.SkinControl.SkinPanel();
            this.user = new CCWin.SkinControl.SkinLabel();
            this.comment = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.floor = new CCWin.SkinControl.SkinLabel();
            this.date = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // Img
            // 
            this.Img.BackColor = System.Drawing.Color.Transparent;
            this.Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Img.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Img.DownBack = null;
            this.Img.Location = new System.Drawing.Point(6, 5);
            this.Img.MouseBack = null;
            this.Img.Name = "Img";
            this.Img.NormlBack = null;
            this.Img.Size = new System.Drawing.Size(70, 70);
            this.Img.TabIndex = 0;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.BorderColor = System.Drawing.Color.White;
            this.user.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user.ForeColor = System.Drawing.Color.Black;
            this.user.Location = new System.Drawing.Point(86, 5);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(73, 17);
            this.user.TabIndex = 1;
            this.user.Text = "skinLabel1";
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.BackColor = System.Drawing.Color.Transparent;
            this.comment.BorderColor = System.Drawing.Color.White;
            this.comment.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comment.ForeColor = System.Drawing.Color.Black;
            this.comment.Location = new System.Drawing.Point(86, 37);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(73, 17);
            this.comment.TabIndex = 2;
            this.comment.Text = "skinLabel2";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Black;
            this.skinLabel3.Location = new System.Drawing.Point(339, 5);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(20, 17);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "楼";
            // 
            // floor
            // 
            this.floor.AutoSize = true;
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.BorderColor = System.Drawing.Color.White;
            this.floor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.floor.ForeColor = System.Drawing.Color.Blue;
            this.floor.Location = new System.Drawing.Point(324, 5);
            this.floor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(20, 17);
            this.floor.TabIndex = 4;
            this.floor.Text = "楼";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.BorderColor = System.Drawing.Color.White;
            this.date.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Location = new System.Drawing.Point(161, 5);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(73, 17);
            this.date.TabIndex = 5;
            this.date.Text = "skinLabel1";
            // 
            // bookcomment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LibrarySET.Properties.Resources._21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Img);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "bookcomment";
            this.Size = new System.Drawing.Size(364, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel Img;
        private CCWin.SkinControl.SkinLabel user;
        private CCWin.SkinControl.SkinLabel comment;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel floor;
        private CCWin.SkinControl.SkinLabel date;
    }
}
