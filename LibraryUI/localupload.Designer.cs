namespace LibraryUI
{
    partial class Localupload
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
            this.button1 = new System.Windows.Forms.Button();
            this.sure = new System.Windows.Forms.Button();
            this.imagePartSelecter1 = new OMCS.Tools.ImagePartSelecter();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(188, 362);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(75, 23);
            this.sure.TabIndex = 2;
            this.sure.Text = "确认";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // imagePartSelecter1
            // 
            this.imagePartSelecter1.BackColor = System.Drawing.Color.White;
            this.imagePartSelecter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imagePartSelecter1.Location = new System.Drawing.Point(12, 40);
            this.imagePartSelecter1.Name = "imagePartSelecter1";
            this.imagePartSelecter1.Size = new System.Drawing.Size(442, 316);
            this.imagePartSelecter1.TabIndex = 3;
            // 
            // Localupload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(466, 397);
            this.Controls.Add(this.imagePartSelecter1);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.button1);
            this.Name = "Localupload";
            this.Text = "localupload";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sure;
        private OMCS.Tools.ImagePartSelecter imagePartSelecter1;
    }
}