namespace PrintLabel
{
    partial class formCreatePL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCreatePL));
            this.label1 = new System.Windows.Forms.Label();
            this.gvData = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnMaster_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMasterPackingList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateMasterPackingList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDefaultFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPathSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreatePL = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.idPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPL_OLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChungLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPL_OLD = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ViewDetail = new System.Windows.Forms.DataGridViewImageColumn();
            this.ReCreatePackingList = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(356, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Packing List";
            // 
            // gvData
            // 
            this.gvData.AllowUserToAddRows = false;
            this.gvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPL,
            this.idPL_OLD,
            this.MaPL,
            this.ChungLoai,
            this.ThietBi,
            this.DateTimeCreated,
            this.UserName1,
            this.FullName,
            this.MaPL_OLD,
            this.ViewDetail,
            this.ReCreatePackingList});
            this.gvData.Location = new System.Drawing.Point(12, 129);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.Size = new System.Drawing.Size(923, 424);
            this.gvData.TabIndex = 0;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMaster_Item,
            this.menuSetting,
            this.menuThongTin,
            this.menuDangXuat,
            this.menuAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnMaster_Item
            // 
            this.mnMaster_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTaiKhoan,
            this.mnMasterPackingList,
            this.mnUpdateMasterPackingList,
            this.menuDefaultFunc});
            this.mnMaster_Item.Image = global::PrintLabel.Properties.Resources.Control2424;
            this.mnMaster_Item.Name = "mnMaster_Item";
            this.mnMaster_Item.Size = new System.Drawing.Size(76, 20);
            this.mnMaster_Item.Text = "Quản lý";
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.Image = global::PrintLabel.Properties.Resources.iconfinder_Users_85409;
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(239, 22);
            this.menuTaiKhoan.Text = "Tài khoản";
            this.menuTaiKhoan.Click += new System.EventHandler(this.menuTaiKhoan_Click);
            // 
            // mnMasterPackingList
            // 
            this.mnMasterPackingList.Image = global::PrintLabel.Properties.Resources.system32x32;
            this.mnMasterPackingList.Name = "mnMasterPackingList";
            this.mnMasterPackingList.Size = new System.Drawing.Size(239, 22);
            this.mnMasterPackingList.Text = "Master Packing List";
            this.mnMasterPackingList.Click += new System.EventHandler(this.mnMasterPackingList_Click);
            // 
            // mnUpdateMasterPackingList
            // 
            this.mnUpdateMasterPackingList.Image = global::PrintLabel.Properties.Resources.Excel;
            this.mnUpdateMasterPackingList.Name = "mnUpdateMasterPackingList";
            this.mnUpdateMasterPackingList.Size = new System.Drawing.Size(239, 22);
            this.mnUpdateMasterPackingList.Text = "Cập nhật Template Packing List";
            this.mnUpdateMasterPackingList.Click += new System.EventHandler(this.mnUpdateMasterPackingList_Click);
            // 
            // menuDefaultFunc
            // 
            this.menuDefaultFunc.Image = global::PrintLabel.Properties.Resources.chia_24x24;
            this.menuDefaultFunc.Name = "menuDefaultFunc";
            this.menuDefaultFunc.Size = new System.Drawing.Size(239, 22);
            this.menuDefaultFunc.Text = "Chức năng mặc định";
            this.menuDefaultFunc.Click += new System.EventHandler(this.menuDefaultFunc_Click);
            // 
            // menuSetting
            // 
            this.menuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPathSaveFile});
            this.menuSetting.Image = global::PrintLabel.Properties.Resources.setting;
            this.menuSetting.Name = "menuSetting";
            this.menuSetting.Size = new System.Drawing.Size(72, 20);
            this.menuSetting.Text = "Cài đặt";
            // 
            // menuPathSaveFile
            // 
            this.menuPathSaveFile.Image = global::PrintLabel.Properties.Resources.iconfinder_Open_1493293;
            this.menuPathSaveFile.Name = "menuPathSaveFile";
            this.menuPathSaveFile.Size = new System.Drawing.Size(172, 22);
            this.menuPathSaveFile.Text = "Đường dẫn lưu file";
            this.menuPathSaveFile.Click += new System.EventHandler(this.menuPathSaveFile_Click);
            // 
            // menuThongTin
            // 
            this.menuThongTin.Image = global::PrintLabel.Properties.Resources.info_20x20;
            this.menuThongTin.Name = "menuThongTin";
            this.menuThongTin.Size = new System.Drawing.Size(86, 20);
            this.menuThongTin.Text = "Thông tin";
            this.menuThongTin.Click += new System.EventHandler(this.menuThongTin_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuDangXuat.Image = global::PrintLabel.Properties.Resources.iconfinder_exit_3855614;
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(89, 20);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuAccount
            // 
            this.menuAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChangePass});
            this.menuAccount.Image = global::PrintLabel.Properties.Resources.user_32x32;
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(85, 20);
            this.menuAccount.Text = "Tài khoản";
            // 
            // menuChangePass
            // 
            this.menuChangePass.Image = global::PrintLabel.Properties.Resources.reset_password_24x24;
            this.menuChangePass.Name = "menuChangePass";
            this.menuChangePass.Size = new System.Drawing.Size(145, 22);
            this.menuChangePass.Text = "Đổi mật khẩu";
            this.menuChangePass.Click += new System.EventHandler(this.menuChangePass_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::PrintLabel.Properties.Resources.refresh_24x24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(12, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 35);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Tải lại dữ liệu";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreatePL
            // 
            this.btnCreatePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreatePL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreatePL.Image = global::PrintLabel.Properties.Resources.createnew_24x24;
            this.btnCreatePL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatePL.Location = new System.Drawing.Point(762, 70);
            this.btnCreatePL.Name = "btnCreatePL";
            this.btnCreatePL.Size = new System.Drawing.Size(174, 53);
            this.btnCreatePL.TabIndex = 0;
            this.btnCreatePL.Text = "Tạo mới Packing List";
            this.btnCreatePL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreatePL.UseVisualStyleBackColor = true;
            this.btnCreatePL.Click += new System.EventHandler(this.btnCreatePL_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(12, 95);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(367, 29);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearch.Location = new System.Drawing.Point(385, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // idPL
            // 
            this.idPL.DataPropertyName = "idPL";
            this.idPL.HeaderText = "idPL";
            this.idPL.Name = "idPL";
            this.idPL.ReadOnly = true;
            this.idPL.Visible = false;
            // 
            // idPL_OLD
            // 
            this.idPL_OLD.DataPropertyName = "idPL_OLD";
            this.idPL_OLD.HeaderText = "idPL_OLD";
            this.idPL_OLD.Name = "idPL_OLD";
            this.idPL_OLD.ReadOnly = true;
            this.idPL_OLD.Visible = false;
            // 
            // MaPL
            // 
            this.MaPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaPL.DataPropertyName = "MaPL";
            this.MaPL.HeaderText = "Mã PL";
            this.MaPL.Name = "MaPL";
            this.MaPL.ReadOnly = true;
            this.MaPL.Width = 68;
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
            // DateTimeCreated
            // 
            this.DateTimeCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateTimeCreated.DataPropertyName = "DateTimeCreated";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            this.DateTimeCreated.DefaultCellStyle = dataGridViewCellStyle2;
            this.DateTimeCreated.HeaderText = "Thời gian tạo";
            this.DateTimeCreated.Name = "DateTimeCreated";
            this.DateTimeCreated.ReadOnly = true;
            // 
            // UserName1
            // 
            this.UserName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName1.DataPropertyName = "UserName";
            this.UserName1.HeaderText = "Mã NV";
            this.UserName1.Name = "UserName1";
            this.UserName1.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ tên";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // MaPL_OLD
            // 
            this.MaPL_OLD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaPL_OLD.DataPropertyName = "MaPL_OLD";
            this.MaPL_OLD.HeaderText = "Mã PL thay thế";
            this.MaPL_OLD.Name = "MaPL_OLD";
            this.MaPL_OLD.ReadOnly = true;
            this.MaPL_OLD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaPL_OLD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaPL_OLD.Visible = false;
            this.MaPL_OLD.Width = 113;
            // 
            // ViewDetail
            // 
            this.ViewDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ViewDetail.HeaderText = "Chi tiết";
            this.ViewDetail.Image = global::PrintLabel.Properties.Resources.info_20x20;
            this.ViewDetail.Name = "ViewDetail";
            this.ViewDetail.ReadOnly = true;
            this.ViewDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ReCreatePackingList
            // 
            this.ReCreatePackingList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReCreatePackingList.HeaderText = "Tạo lại PL";
            this.ReCreatePackingList.Image = global::PrintLabel.Properties.Resources.edit_20x20_2;
            this.ReCreatePackingList.Name = "ReCreatePackingList";
            this.ReCreatePackingList.ReadOnly = true;
            this.ReCreatePackingList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReCreatePackingList.Visible = false;
            // 
            // formCreatePL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(947, 565);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreatePL);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "formCreatePL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packing List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formCreatePL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnMaster_Item;
        private System.Windows.Forms.ToolStripMenuItem mnMasterPackingList;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateMasterPackingList;
        private System.Windows.Forms.ToolStripMenuItem menuDefaultFunc;
        private System.Windows.Forms.ToolStripMenuItem menuThongTin;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuAccount;
        private System.Windows.Forms.ToolStripMenuItem menuChangePass;
        private System.Windows.Forms.ToolStripMenuItem menuSetting;
        private System.Windows.Forms.ToolStripMenuItem menuPathSaveFile;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPL_OLD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChungLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewLinkColumn MaPL_OLD;
        private System.Windows.Forms.DataGridViewImageColumn ViewDetail;
        private System.Windows.Forms.DataGridViewImageColumn ReCreatePackingList;
    }
}