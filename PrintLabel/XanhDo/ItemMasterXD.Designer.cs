namespace PrintLabel.XanhDo
{
    partial class ItemMasterXD
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew_ItemMaster = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPageSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gvData = new System.Windows.Forms.DataGridView();
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
            this.IDItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rownum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 34);
            this.panel1.TabIndex = 1;
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
            this.btnExportToExcel.Location = new System.Drawing.Point(845, 2);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(40, 30);
            this.btnExportToExcel.TabIndex = 5;
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number record/page";
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
            this.cboPageSize.Location = new System.Drawing.Point(783, 6);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(55, 21);
            this.cboPageSize.TabIndex = 3;
            this.cboPageSize.Text = "10";
            this.cboPageSize.SelectedIndexChanged += new System.EventHandler(this.cboPageSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(349, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gvData
            // 
            this.gvData.AllowUserToAddRows = false;
            this.gvData.AllowUserToDeleteRows = false;
            this.gvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDItem,
            this.rownum,
            this.ItemNo,
            this.intFrom,
            this.intTo,
            this.Edit,
            this.Delete});
            this.gvData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvData.Location = new System.Drawing.Point(0, 34);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowHeadersWidth = 15;
            this.gvData.Size = new System.Drawing.Size(896, 338);
            this.gvData.TabIndex = 2;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
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
            this.toolStripMenu.Location = new System.Drawing.Point(0, 380);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(896, 25);
            this.toolStripMenu.TabIndex = 3;
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
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel2.Text = "page";
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
            // IDItem
            // 
            this.IDItem.DataPropertyName = "IDItem";
            this.IDItem.HeaderText = "IDItem";
            this.IDItem.Name = "IDItem";
            this.IDItem.ReadOnly = true;
            this.IDItem.Visible = false;
            // 
            // rownum
            // 
            this.rownum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rownum.DataPropertyName = "rownum";
            this.rownum.HeaderText = "STT";
            this.rownum.Name = "rownum";
            this.rownum.ReadOnly = true;
            // 
            // ItemNo
            // 
            this.ItemNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNo.DataPropertyName = "ItemNo";
            this.ItemNo.HeaderText = "ItemNo";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.ReadOnly = true;
            // 
            // intFrom
            // 
            this.intFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.intFrom.DataPropertyName = "intFrom";
            this.intFrom.HeaderText = "From";
            this.intFrom.Name = "intFrom";
            this.intFrom.ReadOnly = true;
            this.intFrom.Visible = false;
            // 
            // intTo
            // 
            this.intTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.intTo.DataPropertyName = "intTo";
            this.intTo.HeaderText = "To";
            this.intTo.Name = "intTo";
            this.intTo.ReadOnly = true;
            this.intTo.Visible = false;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Visible = false;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // ItemMasterXD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 405);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemMasterXD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Item master";
            this.Load += new System.EventHandler(this.ItemMasterXD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPageSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ToolStripLabel mnStart_End_Data;
        private System.Windows.Forms.ToolStripButton mnbtn_LastPage;
        private System.Windows.Forms.ToolStripButton mnbtn_NextPage;
        private System.Windows.Forms.ToolStripLabel mnPageTotal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox mntxtPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton mnbtn_backPage;
        private System.Windows.Forms.ToolStripButton mnbtn_FirstPage;
        private System.Windows.Forms.Button btnNew_ItemMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn rownum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn intTo;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}