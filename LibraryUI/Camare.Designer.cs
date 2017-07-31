namespace LibraryUI
{
    partial class Camare
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
            this.headImagePanel1 = new OMCS.Tools.HeadImagePanel();
            this.sure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headImagePanel1
            // 
            this.headImagePanel1.BackColor = System.Drawing.Color.White;
            this.headImagePanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headImagePanel1.Location = new System.Drawing.Point(12, 12);
            this.headImagePanel1.Name = "headImagePanel1";
            this.headImagePanel1.Size = new System.Drawing.Size(422, 336);
            this.headImagePanel1.TabIndex = 0;
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(173, 374);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(106, 35);
            this.sure.TabIndex = 1;
            this.sure.Text = "确认";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // Camare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 430);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.headImagePanel1);
            this.Name = "Camare";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camare_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private OMCS.Tools.HeadImagePanel headImagePanel1;
        private System.Windows.Forms.Button sure;
    }
}