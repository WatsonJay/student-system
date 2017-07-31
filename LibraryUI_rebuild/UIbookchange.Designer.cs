namespace LibraryUI_rebuild
{
    partial class UIbookchange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIbookchange));
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.bookinfo = new CCWin.SkinControl.SkinTabPage();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.bookimg = new CCWin.SkinControl.SkinPanel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.page = new System.Windows.Forms.TextBox();
            this.cancle = new CCWin.SkinControl.SkinButton();
            this.sure = new CCWin.SkinControl.SkinButton();
            this.bookname = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.codeword = new CCWin.SkinControl.SkinLabel();
            this.type = new CCWin.SkinControl.SkinTextBox();
            this.pubname = new CCWin.SkinControl.SkinTextBox();
            this.date = new CCWin.SkinControl.SkinTextBox();
            this.autor = new CCWin.SkinControl.SkinTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.skinLabel20 = new CCWin.SkinControl.SkinLabel();
            this.bookIntro = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel17 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel16 = new CCWin.SkinControl.SkinLabel();
            this.bookreview = new CCWin.SkinControl.SkinTabPage();
            this.commentList = new CCWin.SkinControl.SkinDataGridView();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commenterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbbookcommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_libaryDataSet2 = new LibraryUI_rebuild.db_libaryDataSet2();
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tb_bookcommentTableAdapter = new LibraryUI_rebuild.db_libaryDataSet2TableAdapters.tb_bookcommentTableAdapter();
            this.skinTabControl1.SuspendLayout();
            this.bookinfo.SuspendLayout();
            this.bookreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbookcommentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_libaryDataSet2)).BeginInit();
            this.skinToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.bookinfo);
            this.skinTabControl1.Controls.Add(this.bookreview);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 28);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 1;
            this.skinTabControl1.Size = new System.Drawing.Size(463, 555);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.skinTabControl1.TabIndex = 0;
            // 
            // bookinfo
            // 
            this.bookinfo.AutoScroll = true;
            this.bookinfo.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.bookinfo.BackColor = System.Drawing.Color.Transparent;
            this.bookinfo.Controls.Add(this.skinLabel6);
            this.bookinfo.Controls.Add(this.textBox1);
            this.bookinfo.Controls.Add(this.skinLabel5);
            this.bookinfo.Controls.Add(this.bookimg);
            this.bookinfo.Controls.Add(this.skinLabel4);
            this.bookinfo.Controls.Add(this.page);
            this.bookinfo.Controls.Add(this.cancle);
            this.bookinfo.Controls.Add(this.sure);
            this.bookinfo.Controls.Add(this.bookname);
            this.bookinfo.Controls.Add(this.skinLabel3);
            this.bookinfo.Controls.Add(this.skinLabel1);
            this.bookinfo.Controls.Add(this.skinLabel2);
            this.bookinfo.Controls.Add(this.codeword);
            this.bookinfo.Controls.Add(this.type);
            this.bookinfo.Controls.Add(this.pubname);
            this.bookinfo.Controls.Add(this.date);
            this.bookinfo.Controls.Add(this.autor);
            this.bookinfo.Controls.Add(this.linkLabel1);
            this.bookinfo.Controls.Add(this.skinLabel20);
            this.bookinfo.Controls.Add(this.bookIntro);
            this.bookinfo.Controls.Add(this.skinLabel19);
            this.bookinfo.Controls.Add(this.skinLabel18);
            this.bookinfo.Controls.Add(this.skinLabel17);
            this.bookinfo.Controls.Add(this.skinLabel16);
            this.bookinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookinfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookinfo.Location = new System.Drawing.Point(0, 36);
            this.bookinfo.Name = "bookinfo";
            this.bookinfo.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.bookinfo.Size = new System.Drawing.Size(463, 519);
            this.bookinfo.TabIndex = 0;
            this.bookinfo.TabItemImage = null;
            this.bookinfo.Text = "书本信息修改";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.Black;
            this.skinLabel6.Location = new System.Drawing.Point(109, 295);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(20, 17);
            this.skinLabel6.TabIndex = 53;
            this.skinLabel6.Text = "元";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 21);
            this.textBox1.TabIndex = 52;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.Black;
            this.skinLabel5.Location = new System.Drawing.Point(12, 291);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(44, 17);
            this.skinLabel5.TabIndex = 51;
            this.skinLabel5.Text = "定价：";
            // 
            // bookimg
            // 
            this.bookimg.BackColor = System.Drawing.Color.Transparent;
            this.bookimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookimg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bookimg.DownBack = null;
            this.bookimg.Location = new System.Drawing.Point(300, 27);
            this.bookimg.MouseBack = null;
            this.bookimg.Name = "bookimg";
            this.bookimg.NormlBack = null;
            this.bookimg.Size = new System.Drawing.Size(140, 140);
            this.bookimg.TabIndex = 50;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(109, 258);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(20, 17);
            this.skinLabel4.TabIndex = 49;
            this.skinLabel4.Text = "页";
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(71, 255);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(32, 21);
            this.page.TabIndex = 48;
            this.page.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.page_KeyPress);
            // 
            // cancle
            // 
            this.cancle.BackColor = System.Drawing.Color.Transparent;
            this.cancle.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cancle.DownBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_down;
            this.cancle.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.cancle.Location = new System.Drawing.Point(275, 578);
            this.cancle.MouseBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_hover;
            this.cancle.Name = "cancle";
            this.cancle.NormlBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_normal;
            this.cancle.Size = new System.Drawing.Size(75, 23);
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
            this.sure.Location = new System.Drawing.Point(106, 578);
            this.sure.MouseBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_hover;
            this.sure.Name = "sure";
            this.sure.NormlBack = global::LibraryUI_rebuild.Properties.Resources.button_loginchange_normal;
            this.sure.Size = new System.Drawing.Size(75, 23);
            this.sure.TabIndex = 46;
            this.sure.Text = "确认";
            this.sure.UseVisualStyleBackColor = false;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // bookname
            // 
            this.bookname.BackColor = System.Drawing.Color.Transparent;
            this.bookname.DownBack = null;
            this.bookname.Icon = null;
            this.bookname.IconIsButton = false;
            this.bookname.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.bookname.IsPasswordChat = '\0';
            this.bookname.IsSystemPasswordChar = false;
            this.bookname.Lines = new string[0];
            this.bookname.Location = new System.Drawing.Point(57, 27);
            this.bookname.Margin = new System.Windows.Forms.Padding(0);
            this.bookname.MaxLength = 32767;
            this.bookname.MinimumSize = new System.Drawing.Size(28, 12);
            this.bookname.MouseBack = null;
            this.bookname.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.bookname.Multiline = false;
            this.bookname.Name = "bookname";
            this.bookname.NormlBack = null;
            this.bookname.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.bookname.ReadOnly = false;
            this.bookname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookname.Size = new System.Drawing.Size(120, 21);
            // 
            // 
            // 
            this.bookname.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookname.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookname.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.bookname.SkinTxt.Location = new System.Drawing.Point(2, 2);
            this.bookname.SkinTxt.Name = "BaseText";
            this.bookname.SkinTxt.Size = new System.Drawing.Size(116, 18);
            this.bookname.SkinTxt.TabIndex = 0;
            this.bookname.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.bookname.SkinTxt.WaterText = "";
            this.bookname.TabIndex = 28;
            this.bookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bookname.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.bookname.WaterText = "";
            this.bookname.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Black;
            this.skinLabel3.Location = new System.Drawing.Point(13, 258);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 33;
            this.skinLabel3.Text = "页码数：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Black;
            this.skinLabel1.Location = new System.Drawing.Point(13, 221);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 32;
            this.skinLabel1.Text = "标识码：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Black;
            this.skinLabel2.Location = new System.Drawing.Point(12, 179);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 31;
            this.skinLabel2.Text = "出版日期：";
            // 
            // codeword
            // 
            this.codeword.AutoSize = true;
            this.codeword.BackColor = System.Drawing.Color.Transparent;
            this.codeword.BorderColor = System.Drawing.Color.White;
            this.codeword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.codeword.ForeColor = System.Drawing.Color.Black;
            this.codeword.Location = new System.Drawing.Point(75, 221);
            this.codeword.Name = "codeword";
            this.codeword.Size = new System.Drawing.Size(44, 17);
            this.codeword.TabIndex = 30;
            this.codeword.Text = "书名：";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.DownBack = null;
            this.type.Icon = null;
            this.type.IconIsButton = false;
            this.type.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.type.IsPasswordChat = '\0';
            this.type.IsSystemPasswordChar = false;
            this.type.Lines = new string[0];
            this.type.Location = new System.Drawing.Point(60, 139);
            this.type.Margin = new System.Windows.Forms.Padding(0);
            this.type.MaxLength = 32767;
            this.type.MinimumSize = new System.Drawing.Size(28, 12);
            this.type.MouseBack = null;
            this.type.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.type.Multiline = false;
            this.type.Name = "type";
            this.type.NormlBack = null;
            this.type.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.type.ReadOnly = false;
            this.type.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.type.Size = new System.Drawing.Size(120, 21);
            // 
            // 
            // 
            this.type.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.type.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.type.SkinTxt.Location = new System.Drawing.Point(2, 2);
            this.type.SkinTxt.Name = "BaseText";
            this.type.SkinTxt.Size = new System.Drawing.Size(116, 18);
            this.type.SkinTxt.TabIndex = 0;
            this.type.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.type.SkinTxt.WaterText = "";
            this.type.TabIndex = 29;
            this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.type.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.type.WaterText = "";
            this.type.WordWrap = true;
            // 
            // pubname
            // 
            this.pubname.BackColor = System.Drawing.Color.Transparent;
            this.pubname.DownBack = null;
            this.pubname.Icon = null;
            this.pubname.IconIsButton = false;
            this.pubname.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.pubname.IsPasswordChat = '\0';
            this.pubname.IsSystemPasswordChar = false;
            this.pubname.Lines = new string[0];
            this.pubname.Location = new System.Drawing.Point(72, 102);
            this.pubname.Margin = new System.Windows.Forms.Padding(0);
            this.pubname.MaxLength = 32767;
            this.pubname.MinimumSize = new System.Drawing.Size(28, 12);
            this.pubname.MouseBack = null;
            this.pubname.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.pubname.Multiline = false;
            this.pubname.Name = "pubname";
            this.pubname.NormlBack = null;
            this.pubname.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pubname.ReadOnly = false;
            this.pubname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pubname.Size = new System.Drawing.Size(120, 21);
            // 
            // 
            // 
            this.pubname.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pubname.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pubname.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.pubname.SkinTxt.Location = new System.Drawing.Point(2, 2);
            this.pubname.SkinTxt.Name = "BaseText";
            this.pubname.SkinTxt.Size = new System.Drawing.Size(116, 18);
            this.pubname.SkinTxt.TabIndex = 0;
            this.pubname.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pubname.SkinTxt.WaterText = "";
            this.pubname.TabIndex = 28;
            this.pubname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pubname.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pubname.WaterText = "";
            this.pubname.WordWrap = true;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.DownBack = null;
            this.date.Icon = null;
            this.date.IconIsButton = false;
            this.date.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.date.IsPasswordChat = '\0';
            this.date.IsSystemPasswordChar = false;
            this.date.Lines = new string[0];
            this.date.Location = new System.Drawing.Point(88, 178);
            this.date.Margin = new System.Windows.Forms.Padding(0);
            this.date.MaxLength = 32767;
            this.date.MinimumSize = new System.Drawing.Size(28, 12);
            this.date.MouseBack = null;
            this.date.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.date.Multiline = false;
            this.date.Name = "date";
            this.date.NormlBack = null;
            this.date.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.date.ReadOnly = false;
            this.date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.date.Size = new System.Drawing.Size(118, 21);
            // 
            // 
            // 
            this.date.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.date.SkinTxt.Location = new System.Drawing.Point(2, 2);
            this.date.SkinTxt.Name = "BaseText";
            this.date.SkinTxt.Size = new System.Drawing.Size(114, 18);
            this.date.SkinTxt.TabIndex = 0;
            this.date.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.date.SkinTxt.WaterText = "";
            this.date.TabIndex = 27;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.date.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.date.WaterText = "";
            this.date.WordWrap = true;
            // 
            // autor
            // 
            this.autor.BackColor = System.Drawing.Color.Transparent;
            this.autor.DownBack = null;
            this.autor.Icon = null;
            this.autor.IconIsButton = false;
            this.autor.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.autor.IsPasswordChat = '\0';
            this.autor.IsSystemPasswordChar = false;
            this.autor.Lines = new string[0];
            this.autor.Location = new System.Drawing.Point(57, 64);
            this.autor.Margin = new System.Windows.Forms.Padding(0);
            this.autor.MaxLength = 32767;
            this.autor.MinimumSize = new System.Drawing.Size(28, 12);
            this.autor.MouseBack = null;
            this.autor.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.autor.Multiline = false;
            this.autor.Name = "autor";
            this.autor.NormlBack = null;
            this.autor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.autor.ReadOnly = false;
            this.autor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.autor.Size = new System.Drawing.Size(120, 21);
            // 
            // 
            // 
            this.autor.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autor.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autor.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.autor.SkinTxt.Location = new System.Drawing.Point(2, 2);
            this.autor.SkinTxt.Name = "BaseText";
            this.autor.SkinTxt.Size = new System.Drawing.Size(116, 18);
            this.autor.SkinTxt.TabIndex = 0;
            this.autor.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.autor.SkinTxt.WaterText = "";
            this.autor.TabIndex = 26;
            this.autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.autor.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.autor.WaterText = "";
            this.autor.WordWrap = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(351, 186);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 12);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "更换封面";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // skinLabel20
            // 
            this.skinLabel20.AutoSize = true;
            this.skinLabel20.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel20.BorderColor = System.Drawing.Color.White;
            this.skinLabel20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel20.ForeColor = System.Drawing.Color.Black;
            this.skinLabel20.Location = new System.Drawing.Point(14, 324);
            this.skinLabel20.Name = "skinLabel20";
            this.skinLabel20.Size = new System.Drawing.Size(44, 17);
            this.skinLabel20.TabIndex = 19;
            this.skinLabel20.Text = "简介：";
            // 
            // bookIntro
            // 
            this.bookIntro.AutoScroll = true;
            this.bookIntro.BackColor = System.Drawing.Color.Transparent;
            this.bookIntro.DownBack = null;
            this.bookIntro.Icon = null;
            this.bookIntro.IconIsButton = false;
            this.bookIntro.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.bookIntro.IsPasswordChat = '\0';
            this.bookIntro.IsSystemPasswordChar = false;
            this.bookIntro.Lines = new string[] {
        "简介"};
            this.bookIntro.Location = new System.Drawing.Point(15, 352);
            this.bookIntro.Margin = new System.Windows.Forms.Padding(0);
            this.bookIntro.MaxLength = 32767;
            this.bookIntro.MinimumSize = new System.Drawing.Size(28, 28);
            this.bookIntro.MouseBack = null;
            this.bookIntro.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.bookIntro.Multiline = true;
            this.bookIntro.Name = "bookIntro";
            this.bookIntro.NormlBack = null;
            this.bookIntro.Padding = new System.Windows.Forms.Padding(5);
            this.bookIntro.ReadOnly = false;
            this.bookIntro.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bookIntro.Size = new System.Drawing.Size(425, 212);
            // 
            // 
            // 
            this.bookIntro.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookIntro.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookIntro.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.bookIntro.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.bookIntro.SkinTxt.Multiline = true;
            this.bookIntro.SkinTxt.Name = "BaseText";
            this.bookIntro.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bookIntro.SkinTxt.Size = new System.Drawing.Size(415, 202);
            this.bookIntro.SkinTxt.TabIndex = 0;
            this.bookIntro.SkinTxt.Text = "简介";
            this.bookIntro.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.bookIntro.SkinTxt.WaterText = "";
            this.bookIntro.TabIndex = 18;
            this.bookIntro.Text = "简介";
            this.bookIntro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bookIntro.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.bookIntro.WaterText = "";
            this.bookIntro.WordWrap = true;
            // 
            // skinLabel19
            // 
            this.skinLabel19.AutoSize = true;
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel19.ForeColor = System.Drawing.Color.Black;
            this.skinLabel19.Location = new System.Drawing.Point(13, 139);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(44, 17);
            this.skinLabel19.TabIndex = 17;
            this.skinLabel19.Text = "分类：";
            // 
            // skinLabel18
            // 
            this.skinLabel18.AutoSize = true;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel18.ForeColor = System.Drawing.Color.Black;
            this.skinLabel18.Location = new System.Drawing.Point(13, 102);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(56, 17);
            this.skinLabel18.TabIndex = 16;
            this.skinLabel18.Text = "出版社：";
            // 
            // skinLabel17
            // 
            this.skinLabel17.AutoSize = true;
            this.skinLabel17.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel17.BorderColor = System.Drawing.Color.White;
            this.skinLabel17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel17.ForeColor = System.Drawing.Color.Black;
            this.skinLabel17.Location = new System.Drawing.Point(13, 64);
            this.skinLabel17.Name = "skinLabel17";
            this.skinLabel17.Size = new System.Drawing.Size(44, 17);
            this.skinLabel17.TabIndex = 15;
            this.skinLabel17.Text = "作者：";
            // 
            // skinLabel16
            // 
            this.skinLabel16.AutoSize = true;
            this.skinLabel16.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel16.BorderColor = System.Drawing.Color.White;
            this.skinLabel16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel16.ForeColor = System.Drawing.Color.Black;
            this.skinLabel16.Location = new System.Drawing.Point(13, 31);
            this.skinLabel16.Name = "skinLabel16";
            this.skinLabel16.Size = new System.Drawing.Size(44, 17);
            this.skinLabel16.TabIndex = 14;
            this.skinLabel16.Text = "书名：";
            // 
            // bookreview
            // 
            this.bookreview.BackColor = System.Drawing.Color.White;
            this.bookreview.Controls.Add(this.commentList);
            this.bookreview.Controls.Add(this.skinToolStrip1);
            this.bookreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookreview.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookreview.Location = new System.Drawing.Point(0, 36);
            this.bookreview.Name = "bookreview";
            this.bookreview.Size = new System.Drawing.Size(463, 519);
            this.bookreview.TabIndex = 1;
            this.bookreview.TabItemImage = null;
            this.bookreview.Text = "书本评论";
            // 
            // commentList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.commentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.commentList.AutoGenerateColumns = false;
            this.commentList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.commentList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.commentList.ColumnFont = null;
            this.commentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.commentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choose,
            this.booknameDataGridViewTextBoxColumn,
            this.commenterDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.commentList.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.commentList.DataSource = this.tbbookcommentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commentList.DefaultCellStyle = dataGridViewCellStyle3;
            this.commentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentList.EnableHeadersVisualStyles = false;
            this.commentList.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.commentList.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commentList.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.commentList.Location = new System.Drawing.Point(0, 0);
            this.commentList.Name = "commentList";
            this.commentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.commentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.commentList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.commentList.RowTemplate.Height = 23;
            this.commentList.Size = new System.Drawing.Size(463, 494);
            this.commentList.TabIndex = 2;
            this.commentList.TitleBack = null;
            this.commentList.TitleBackColorBegin = System.Drawing.Color.White;
            this.commentList.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // choose
            // 
            this.choose.FalseValue = "False";
            this.choose.Frozen = true;
            this.choose.HeaderText = "选择";
            this.choose.Name = "choose";
            this.choose.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.choose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.choose.TrueValue = "True";
            this.choose.Width = 40;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "bookname";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "书名";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            this.booknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.booknameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.booknameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.booknameDataGridViewTextBoxColumn.Width = 80;
            // 
            // commenterDataGridViewTextBoxColumn
            // 
            this.commenterDataGridViewTextBoxColumn.DataPropertyName = "commenter";
            this.commenterDataGridViewTextBoxColumn.HeaderText = "评论人";
            this.commenterDataGridViewTextBoxColumn.Name = "commenterDataGridViewTextBoxColumn";
            this.commenterDataGridViewTextBoxColumn.ReadOnly = true;
            this.commenterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.commenterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.commenterDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateDataGridViewTextBoxColumn.Width = 80;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "评论内容";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.commentDataGridViewTextBoxColumn.Width = 300;
            // 
            // tbbookcommentBindingSource
            // 
            this.tbbookcommentBindingSource.DataMember = "tb_bookcomment";
            this.tbbookcommentBindingSource.DataSource = this.db_libaryDataSet2;
            // 
            // db_libaryDataSet2
            // 
            this.db_libaryDataSet2.DataSetName = "db_libaryDataSet2";
            this.db_libaryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skinToolStrip1
            // 
            this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip1.Back = System.Drawing.Color.White;
            this.skinToolStrip1.BackRadius = 4;
            this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinToolStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip1.BaseForeAnamorphosis = false;
            this.skinToolStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.BaseItemAnamorphosis = true;
            this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemBorderShow = true;
            this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
            this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
            this.skinToolStrip1.BaseItemNorml = null;
            this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemRadius = 4;
            this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BindTabControl = null;
            this.skinToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip1.Fore = System.Drawing.Color.Black;
            this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip1.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.ItemAnamorphosis = true;
            this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemBorderShow = true;
            this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemRadius = 4;
            this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.skinToolStrip1.Location = new System.Drawing.Point(0, 494);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Size = new System.Drawing.Size(463, 25);
            this.skinToolStrip1.SkinAllColor = true;
            this.skinToolStrip1.TabIndex = 1;
            this.skinToolStrip1.Text = "skinToolStrip1";
            this.skinToolStrip1.TitleAnamorphosis = true;
            this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip1.TitleRadius = 4;
            this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tb_bookcommentTableAdapter
            // 
            this.tb_bookcommentTableAdapter.ClearBeforeFill = true;
            // 
            // UIbookchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUI_rebuild.Properties.Resources._3db11210366998daacff2d9419348b70;
            this.ClientSize = new System.Drawing.Size(471, 587);
            this.CloseDownBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::LibraryUI_rebuild.Properties.Resources.btn_close_disable;
            this.Controls.Add(this.skinTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIbookchange";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIbookchange_FormClosing);
            this.Load += new System.EventHandler(this.UIbookchange_Load);
            this.skinTabControl1.ResumeLayout(false);
            this.bookinfo.ResumeLayout(false);
            this.bookinfo.PerformLayout();
            this.bookreview.ResumeLayout(false);
            this.bookreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbookcommentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_libaryDataSet2)).EndInit();
            this.skinToolStrip1.ResumeLayout(false);
            this.skinToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage bookinfo;
        private CCWin.SkinControl.SkinTabPage bookreview;
        private CCWin.SkinControl.SkinLabel skinLabel20;
        private CCWin.SkinControl.SkinTextBox bookIntro;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private CCWin.SkinControl.SkinLabel skinLabel17;
        private CCWin.SkinControl.SkinLabel skinLabel16;
        private CCWin.SkinControl.SkinTextBox autor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private CCWin.SkinControl.SkinLabel codeword;
        private CCWin.SkinControl.SkinTextBox type;
        private CCWin.SkinControl.SkinTextBox pubname;
        private CCWin.SkinControl.SkinTextBox date;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox bookname;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton cancle;
        private CCWin.SkinControl.SkinButton sure;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.TextBox page;
        private CCWin.SkinControl.SkinPanel bookimg;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.TextBox textBox1;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private db_libaryDataSet2 db_libaryDataSet2;
        private System.Windows.Forms.BindingSource tbbookcommentBindingSource;
        private db_libaryDataSet2TableAdapters.tb_bookcommentTableAdapter tb_bookcommentTableAdapter;
        private CCWin.SkinControl.SkinDataGridView commentList;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commenterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;


    }
}