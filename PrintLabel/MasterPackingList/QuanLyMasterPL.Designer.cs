namespace PrintLabel.MasterPackingList
{
    partial class QuanLyMasterPL
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewhietBi = new System.Windows.Forms.Button();
            this.gvData_ThietBi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewChungLoai = new System.Windows.Forms.Button();
            this.gvDataChungLoai = new System.Windows.Forms.DataGridView();
            this.idChungLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChungLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.mnStart_End_Data = new System.Windows.Forms.ToolStripLabel();
            this.mnbtn_LastPage = new System.Windows.Forms.ToolStripButton();
            this.mnbtn_NextPage = new System.Windows.Forms.ToolStripButton();
            this.mnPageTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mntxtPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.mnbtn_backPage = new System.Windows.Forms.ToolStripButton();
            this.mnbtn_FirstPage = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew_ItemMaster = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPageSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvData_ItemMaster = new System.Windows.Forms.DataGridView();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChungLoai2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThietBi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteTB = new System.Windows.Forms.DataGridViewLinkColumn();
            this.idChungLoai2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChungLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_ThietBi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataChungLoai)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_ItemMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chủng loại - Thiết bị";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewhietBi);
            this.groupBox2.Controls.Add(this.gvData_ThietBi);
            this.groupBox2.Location = new System.Drawing.Point(368, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 509);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết bị";
            // 
            // btnNewhietBi
            // 
            this.btnNewhietBi.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNewhietBi.Image = global::PrintLabel.Properties.Resources.createnew_24x24;
            this.btnNewhietBi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewhietBi.Location = new System.Drawing.Point(373, 55);
            this.btnNewhietBi.Name = "btnNewhietBi";
            this.btnNewhietBi.Size = new System.Drawing.Size(180, 32);
            this.btnNewhietBi.TabIndex = 3;
            this.btnNewhietBi.Text = "Thêm mới thiết bị";
            this.btnNewhietBi.UseVisualStyleBackColor = false;
            this.btnNewhietBi.Click += new System.EventHandler(this.btnNewhietBi_Click);
            // 
            // gvData_ThietBi
            // 
            this.gvData_ThietBi.AllowUserToAddRows = false;
            this.gvData_ThietBi.AllowUserToDeleteRows = false;
            this.gvData_ThietBi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvData_ThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData_ThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChungLoai2,
            this.idParents,
            this.ChungLoai,
            this.ThietBi,
            this.Delete2});
            this.gvData_ThietBi.Location = new System.Drawing.Point(6, 93);
            this.gvData_ThietBi.Name = "gvData_ThietBi";
            this.gvData_ThietBi.ReadOnly = true;
            this.gvData_ThietBi.RowHeadersWidth = 5;
            this.gvData_ThietBi.Size = new System.Drawing.Size(547, 401);
            this.gvData_ThietBi.TabIndex = 2;
            this.gvData_ThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_ThietBi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewChungLoai);
            this.groupBox1.Controls.Add(this.gvDataChungLoai);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chủng loại";
            // 
            // btnNewChungLoai
            // 
            this.btnNewChungLoai.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNewChungLoai.Image = global::PrintLabel.Properties.Resources.createnew_24x24;
            this.btnNewChungLoai.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewChungLoai.Location = new System.Drawing.Point(142, 55);
            this.btnNewChungLoai.Name = "btnNewChungLoai";
            this.btnNewChungLoai.Size = new System.Drawing.Size(193, 32);
            this.btnNewChungLoai.TabIndex = 1;
            this.btnNewChungLoai.Text = "Thêm mới chủng loại";
            this.btnNewChungLoai.UseVisualStyleBackColor = false;
            this.btnNewChungLoai.Click += new System.EventHandler(this.btnNewChungLoai_Click);
            // 
            // gvDataChungLoai
            // 
            this.gvDataChungLoai.AllowUserToAddRows = false;
            this.gvDataChungLoai.AllowUserToDeleteRows = false;
            this.gvDataChungLoai.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvDataChungLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDataChungLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChungLoai,
            this.TenChungLoai,
            this.Delete});
            this.gvDataChungLoai.Location = new System.Drawing.Point(6, 93);
            this.gvDataChungLoai.Name = "gvDataChungLoai";
            this.gvDataChungLoai.ReadOnly = true;
            this.gvDataChungLoai.RowHeadersWidth = 5;
            this.gvDataChungLoai.Size = new System.Drawing.Size(329, 401);
            this.gvDataChungLoai.TabIndex = 0;
            this.gvDataChungLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataChungLoai_CellClick);
            // 
            // idChungLoai
            // 
            this.idChungLoai.DataPropertyName = "idChungLoai";
            this.idChungLoai.HeaderText = "idChungLoai";
            this.idChungLoai.Name = "idChungLoai";
            this.idChungLoai.ReadOnly = true;
            this.idChungLoai.Visible = false;
            // 
            // TenChungLoai
            // 
            this.TenChungLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenChungLoai.DataPropertyName = "TenChungLoai";
            this.TenChungLoai.HeaderText = "Tên chủng loại";
            this.TenChungLoai.Name = "TenChungLoai";
            this.TenChungLoai.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toolStripMenu);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.gvData_ItemMaster);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 541);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Item Code";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnStart_End_Data,
            this.mnbtn_LastPage,
            this.mnbtn_NextPage,
            this.mnPageTotal,
            this.toolStripLabel1,
            this.mntxtPage,
            this.toolStripLabel2,
            this.mnbtn_backPage,
            this.mnbtn_FirstPage});
            this.toolStripMenu.Location = new System.Drawing.Point(3, 513);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(938, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // mnStart_End_Data
            // 
            this.mnStart_End_Data.Name = "mnStart_End_Data";
            this.mnStart_End_Data.Size = new System.Drawing.Size(116, 22);
            this.mnStart_End_Data.Text = "From x to page of all";
            // 
            // mnbtn_LastPage
            // 
            this.mnbtn_LastPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnbtn_LastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnbtn_LastPage.Image = global::PrintLabel.Properties.Resources.end_50x50;
            this.mnbtn_LastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnbtn_LastPage.Name = "mnbtn_LastPage";
            this.mnbtn_LastPage.Size = new System.Drawing.Size(23, 22);
            this.mnbtn_LastPage.Text = "toolStripButton1";
            this.mnbtn_LastPage.Click += new System.EventHandler(this.mnbtn_LastPage_Click);
            // 
            // mnbtn_NextPage
            // 
            this.mnbtn_NextPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnbtn_NextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnbtn_NextPage.Image = global::PrintLabel.Properties.Resources.next_50x50;
            this.mnbtn_NextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnbtn_NextPage.Name = "mnbtn_NextPage";
            this.mnbtn_NextPage.Size = new System.Drawing.Size(23, 22);
            this.mnbtn_NextPage.Text = "toolStripButton1";
            this.mnbtn_NextPage.Click += new System.EventHandler(this.mnbtn_NextPage_Click);
            // 
            // mnPageTotal
            // 
            this.mnPageTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnPageTotal.Name = "mnPageTotal";
            this.mnPageTotal.Size = new System.Drawing.Size(58, 22);
            this.mnPageTotal.Text = "pageTotal";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(12, 22);
            this.toolStripLabel1.Text = "/";
            // 
            // mntxtPage
            // 
            this.mntxtPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mntxtPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mntxtPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mntxtPage.Name = "mntxtPage";
            this.mntxtPage.ReadOnly = true;
            this.mntxtPage.Size = new System.Drawing.Size(50, 25);
            this.mntxtPage.Text = "1";
            this.mntxtPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "trang";
            // 
            // mnbtn_backPage
            // 
            this.mnbtn_backPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnbtn_backPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnbtn_backPage.Image = global::PrintLabel.Properties.Resources.left_50x50;
            this.mnbtn_backPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnbtn_backPage.Name = "mnbtn_backPage";
            this.mnbtn_backPage.Size = new System.Drawing.Size(23, 22);
            this.mnbtn_backPage.Text = "toolStripButton2";
            this.mnbtn_backPage.Click += new System.EventHandler(this.mnbtn_backPage_Click);
            // 
            // mnbtn_FirstPage
            // 
            this.mnbtn_FirstPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnbtn_FirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnbtn_FirstPage.Image = global::PrintLabel.Properties.Resources.start_50x50_22;
            this.mnbtn_FirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnbtn_FirstPage.Name = "mnbtn_FirstPage";
            this.mnbtn_FirstPage.Size = new System.Drawing.Size(23, 22);
            this.mnbtn_FirstPage.Text = "toolStripButton3";
            this.mnbtn_FirstPage.Click += new System.EventHandler(this.mnbtn_FirstPage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnNew_ItemMaster);
            this.panel1.Controls.Add(this.btnExportToExcel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboPageSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnNew_ItemMaster
            // 
            this.btnNew_ItemMaster.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNew_ItemMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew_ItemMaster.Image = global::PrintLabel.Properties.Resources.createnew_24x24;
            this.btnNew_ItemMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew_ItemMaster.Location = new System.Drawing.Point(172, 0);
            this.btnNew_ItemMaster.Name = "btnNew_ItemMaster";
            this.btnNew_ItemMaster.Size = new System.Drawing.Size(37, 33);
            this.btnNew_ItemMaster.TabIndex = 6;
            this.btnNew_ItemMaster.UseVisualStyleBackColor = false;
            this.btnNew_ItemMaster.Click += new System.EventHandler(this.btnNew_ItemMaster_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.Bisque;
            this.btnExportToExcel.Image = global::PrintLabel.Properties.Resources.Excel;
            this.btnExportToExcel.Location = new System.Drawing.Point(882, 3);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(40, 30);
            this.btnExportToExcel.TabIndex = 5;
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dữ liệu/trang";
            // 
            // cboPageSize
            // 
            this.cboPageSize.FormattingEnabled = true;
            this.cboPageSize.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100",
            "200"});
            this.cboPageSize.Location = new System.Drawing.Point(821, 5);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(55, 24);
            this.cboPageSize.TabIndex = 3;
            this.cboPageSize.Text = "10";
            this.cboPageSize.SelectedIndexChanged += new System.EventHandler(this.cboPageSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(347, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý Item master";
            // 
            // gvData_ItemMaster
            // 
            this.gvData_ItemMaster.AllowUserToAddRows = false;
            this.gvData_ItemMaster.AllowUserToDeleteRows = false;
            this.gvData_ItemMaster.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvData_ItemMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData_ItemMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.STT,
            this.ItemCode,
            this.ChungLoai2,
            this.ThietBi2,
            this.DeleteTB});
            this.gvData_ItemMaster.Location = new System.Drawing.Point(6, 39);
            this.gvData_ItemMaster.Name = "gvData_ItemMaster";
            this.gvData_ItemMaster.ReadOnly = true;
            this.gvData_ItemMaster.Size = new System.Drawing.Size(935, 471);
            this.gvData_ItemMaster.TabIndex = 0;
            this.gvData_ItemMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_ItemMaster_CellClick);
            // 
            // idItem
            // 
            this.idItem.DataPropertyName = "idItem";
            this.idItem.HeaderText = "IdItem";
            this.idItem.Name = "idItem";
            this.idItem.ReadOnly = true;
            this.idItem.Visible = false;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ChungLoai2
            // 
            this.ChungLoai2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChungLoai2.DataPropertyName = "ChungLoai";
            this.ChungLoai2.HeaderText = "Chủng loại";
            this.ChungLoai2.Name = "ChungLoai2";
            this.ChungLoai2.ReadOnly = true;
            // 
            // ThietBi2
            // 
            this.ThietBi2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThietBi2.DataPropertyName = "ThietBi";
            this.ThietBi2.HeaderText = "Thiết bị";
            this.ThietBi2.Name = "ThietBi2";
            this.ThietBi2.ReadOnly = true;
            // 
            // DeleteTB
            // 
            this.DeleteTB.HeaderText = "Delete";
            this.DeleteTB.Name = "DeleteTB";
            this.DeleteTB.ReadOnly = true;
            this.DeleteTB.Text = "Delete";
            this.DeleteTB.UseColumnTextForLinkValue = true;
            // 
            // idChungLoai2
            // 
            this.idChungLoai2.DataPropertyName = "idChungLoai";
            this.idChungLoai2.HeaderText = "idChungLoai";
            this.idChungLoai2.Name = "idChungLoai2";
            this.idChungLoai2.ReadOnly = true;
            this.idChungLoai2.Visible = false;
            // 
            // idParents
            // 
            this.idParents.DataPropertyName = "idParents";
            this.idParents.HeaderText = "idParents";
            this.idParents.Name = "idParents";
            this.idParents.ReadOnly = true;
            this.idParents.Visible = false;
            // 
            // ChungLoai
            // 
            this.ChungLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChungLoai.DataPropertyName = "ChungLoai";
            this.ChungLoai.HeaderText = "Chủng loại";
            this.ChungLoai.Name = "ChungLoai";
            this.ChungLoai.ReadOnly = true;
            // 
            // ThietBi
            // 
            this.ThietBi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThietBi.DataPropertyName = "ThietBi";
            this.ThietBi.HeaderText = "Thiết bị";
            this.ThietBi.Name = "ThietBi";
            this.ThietBi.ReadOnly = true;
            // 
            // Delete2
            // 
            this.Delete2.HeaderText = "Delete";
            this.Delete2.Name = "Delete2";
            this.Delete2.ReadOnly = true;
            this.Delete2.Text = "Delete";
            this.Delete2.UseColumnTextForLinkValue = true;
            this.Delete2.Width = 80;
            // 
            // QuanLyMasterPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 585);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyMasterPL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý master";
            this.Load += new System.EventHandler(this.QuanLyMasterPL_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvData_ThietBi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataChungLoai)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_ItemMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvDataChungLoai;
        private System.Windows.Forms.Button btnNewhietBi;
        private System.Windows.Forms.DataGridView gvData_ThietBi;
        private System.Windows.Forms.Button btnNewChungLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChungLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChungLoai;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridView gvData_ItemMaster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew_ItemMaster;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPageSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripLabel mnStart_End_Data;
        private System.Windows.Forms.ToolStripButton mnbtn_LastPage;
        private System.Windows.Forms.ToolStripButton mnbtn_NextPage;
        private System.Windows.Forms.ToolStripLabel mnPageTotal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox mntxtPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton mnbtn_backPage;
        private System.Windows.Forms.ToolStripButton mnbtn_FirstPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChungLoai2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBi2;
        private System.Windows.Forms.DataGridViewLinkColumn DeleteTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChungLoai2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChungLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBi;
        private System.Windows.Forms.DataGridViewLinkColumn Delete2;
    }
}