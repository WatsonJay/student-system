namespace LibraryUI
{
    partial class UImain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UImain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.project = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.Label();
            this.firepage = new System.Windows.Forms.Label();
            this.Head = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.seachtype = new System.Windows.Forms.ComboBox();
            this.seach = new System.Windows.Forms.TextBox();
            this.settinglist = new System.Windows.Forms.Panel();
            this.levelpanel = new System.Windows.Forms.Panel();
            this.landedlevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userpanel = new System.Windows.Forms.Panel();
            this.landedname = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.Head.SuspendLayout();
            this.panel3.SuspendLayout();
            this.settinglist.SuspendLayout();
            this.levelpanel.SuspendLayout();
            this.userpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.project);
            this.panel1.Controls.Add(this.book);
            this.panel1.Controls.Add(this.firepage);
            this.panel1.Controls.Add(this.Head);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 54);
            this.panel1.TabIndex = 0;
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project.Location = new System.Drawing.Point(186, 17);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(58, 24);
            this.project.TabIndex = 4;
            this.project.Text = "项目";
            // 
            // book
            // 
            this.book.AutoSize = true;
            this.book.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.book.Location = new System.Drawing.Point(106, 17);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(58, 24);
            this.book.TabIndex = 3;
            this.book.Text = "图书";
            // 
            // firepage
            // 
            this.firepage.AutoSize = true;
            this.firepage.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firepage.Location = new System.Drawing.Point(30, 17);
            this.firepage.Name = "firepage";
            this.firepage.Size = new System.Drawing.Size(58, 24);
            this.firepage.TabIndex = 2;
            this.firepage.Text = "首页";
            // 
            // Head
            // 
            this.Head.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Head.Controls.Add(this.panel5);
            this.Head.Location = new System.Drawing.Point(653, 4);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(44, 44);
            this.Head.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::LibraryUI.Properties.Resources.white1;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(44, 44);
            this.panel5.TabIndex = 2;
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
            this.panel5.MouseEnter += new System.EventHandler(this.panel5_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.seachtype);
            this.panel3.Controls.Add(this.seach);
            this.panel3.Location = new System.Drawing.Point(703, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 30);
            this.panel3.TabIndex = 0;
            // 
            // seachtype
            // 
            this.seachtype.Dock = System.Windows.Forms.DockStyle.Left;
            this.seachtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seachtype.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.seachtype.FormattingEnabled = true;
            this.seachtype.ItemHeight = 19;
            this.seachtype.Items.AddRange(new object[] {
            "书名",
            "作者",
            "出版社",
            "项目",
            "项目发布者"});
            this.seachtype.Location = new System.Drawing.Point(0, 0);
            this.seachtype.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.seachtype.Name = "seachtype";
            this.seachtype.Size = new System.Drawing.Size(120, 27);
            this.seachtype.TabIndex = 1;
            // 
            // seach
            // 
            this.seach.Dock = System.Windows.Forms.DockStyle.Right;
            this.seach.Font = new System.Drawing.Font("宋体", 14F);
            this.seach.Location = new System.Drawing.Point(120, 0);
            this.seach.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.seach.Name = "seach";
            this.seach.Size = new System.Drawing.Size(270, 29);
            this.seach.TabIndex = 0;
            // 
            // settinglist
            // 
            this.settinglist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settinglist.BackColor = System.Drawing.Color.Transparent;
            this.settinglist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settinglist.Controls.Add(this.levelpanel);
            this.settinglist.Controls.Add(this.userpanel);
            this.settinglist.Location = new System.Drawing.Point(282, 0);
            this.settinglist.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.settinglist.Name = "settinglist";
            this.settinglist.Size = new System.Drawing.Size(213, 293);
            this.settinglist.TabIndex = 0;
            // 
            // levelpanel
            // 
            this.levelpanel.Controls.Add(this.landedlevel);
            this.levelpanel.Controls.Add(this.label2);
            this.levelpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.levelpanel.Location = new System.Drawing.Point(0, 42);
            this.levelpanel.Name = "levelpanel";
            this.levelpanel.Size = new System.Drawing.Size(211, 25);
            this.levelpanel.TabIndex = 9;
            // 
            // landedlevel
            // 
            this.landedlevel.AutoSize = true;
            this.landedlevel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.landedlevel.ForeColor = System.Drawing.Color.Blue;
            this.landedlevel.Location = new System.Drawing.Point(120, 4);
            this.landedlevel.Name = "landedlevel";
            this.landedlevel.Size = new System.Drawing.Size(16, 16);
            this.landedlevel.TabIndex = 8;
            this.landedlevel.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(38, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "您的权限：";
            // 
            // userpanel
            // 
            this.userpanel.Controls.Add(this.landedname);
            this.userpanel.Controls.Add(this.label1);
            this.userpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userpanel.Location = new System.Drawing.Point(0, 0);
            this.userpanel.Name = "userpanel";
            this.userpanel.Size = new System.Drawing.Size(211, 42);
            this.userpanel.TabIndex = 0;
            // 
            // landedname
            // 
            this.landedname.AutoSize = true;
            this.landedname.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.landedname.Location = new System.Drawing.Point(126, 11);
            this.landedname.Name = "landedname";
            this.landedname.Size = new System.Drawing.Size(31, 20);
            this.landedname.TabIndex = 6;
            this.landedname.TabStop = true;
            this.landedname.Text = "  ";
            this.landedname.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.landedname_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "欢迎回来！";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 584);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.settinglist);
            this.splitContainer1.Size = new System.Drawing.Size(1139, 584);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // UImain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUI.Properties.Resources._403431;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UImain";
            this.Text = "数字研究平台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UImain_FormClosing);
            this.Load += new System.EventHandler(this.UImain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Head.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.settinglist.ResumeLayout(false);
            this.levelpanel.ResumeLayout(false);
            this.levelpanel.PerformLayout();
            this.userpanel.ResumeLayout(false);
            this.userpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox seachtype;
        private System.Windows.Forms.TextBox seach;
        private System.Windows.Forms.Label project;
        private System.Windows.Forms.Label book;
        private System.Windows.Forms.Label firepage;
        private System.Windows.Forms.Panel Head;
        private System.Windows.Forms.Panel settinglist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel userpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label landedlevel;
        private System.Windows.Forms.Panel levelpanel;
        private System.Windows.Forms.LinkLabel landedname;

    }
}