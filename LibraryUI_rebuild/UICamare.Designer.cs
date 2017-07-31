namespace LibraryUI_rebuild
{
    partial class UICamare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UICamare));
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.headImagePanel1 = new OMCS.Tools.HeadImagePanel();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_down;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Location = new System.Drawing.Point(94, 284);
            this.skinButton1.MouseBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_hover;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_normal;
            this.skinButton1.Palace = true;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "照相";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // headImagePanel1
            // 
            this.headImagePanel1.BackColor = System.Drawing.Color.White;
            this.headImagePanel1.Location = new System.Drawing.Point(11, 34);
            this.headImagePanel1.Name = "headImagePanel1";
            this.headImagePanel1.Size = new System.Drawing.Size(240, 240);
            this.headImagePanel1.TabIndex = 2;
            // 
            // UICamare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ClientSize = new System.Drawing.Size(265, 319);
            this.Controls.Add(this.headImagePanel1);
            this.Controls.Add(this.skinButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UICamare";
            this.Text = "Camare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camare_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private OMCS.Tools.HeadImagePanel headImagePanel1;

    }
}