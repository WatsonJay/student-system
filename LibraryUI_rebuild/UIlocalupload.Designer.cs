namespace LibraryUI_rebuild
{
    partial class UIlocalupload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIlocalupload));
            this.imagePartSelecter1 = new OMCS.Tools.ImagePartSelecter();
            this.selectpic = new CCWin.SkinControl.SkinButton();
            this.sure = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // imagePartSelecter1
            // 
            this.imagePartSelecter1.BackColor = System.Drawing.Color.White;
            this.imagePartSelecter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imagePartSelecter1.Location = new System.Drawing.Point(7, 31);
            this.imagePartSelecter1.Name = "imagePartSelecter1";
            this.imagePartSelecter1.Size = new System.Drawing.Size(310, 264);
            this.imagePartSelecter1.TabIndex = 0;
            // 
            // selectpic
            // 
            this.selectpic.BackColor = System.Drawing.Color.Transparent;
            this.selectpic.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.selectpic.DownBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_down;
            this.selectpic.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.selectpic.Location = new System.Drawing.Point(47, 306);
            this.selectpic.MouseBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_hover;
            this.selectpic.Name = "selectpic";
            this.selectpic.NormlBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_normal;
            this.selectpic.Size = new System.Drawing.Size(75, 23);
            this.selectpic.TabIndex = 1;
            this.selectpic.Text = "选取图片";
            this.selectpic.UseVisualStyleBackColor = false;
            this.selectpic.Click += new System.EventHandler(this.selectpic_Click);
            // 
            // sure
            // 
            this.sure.BackColor = System.Drawing.Color.Transparent;
            this.sure.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sure.DownBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_down;
            this.sure.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.sure.Location = new System.Drawing.Point(188, 306);
            this.sure.MouseBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_hover;
            this.sure.Name = "sure";
            this.sure.NormlBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_normal;
            this.sure.Size = new System.Drawing.Size(75, 23);
            this.sure.TabIndex = 2;
            this.sure.Text = "确认";
            this.sure.UseVisualStyleBackColor = false;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // UIlocalupload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 340);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.selectpic);
            this.Controls.Add(this.imagePartSelecter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UIlocalupload";
            this.Text = "localupload";
            this.ResumeLayout(false);

        }

        #endregion

        private OMCS.Tools.ImagePartSelecter imagePartSelecter1;
        private CCWin.SkinControl.SkinButton selectpic;
        private CCWin.SkinControl.SkinButton sure;
    }
}