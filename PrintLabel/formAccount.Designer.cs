namespace PrintLabel
{
    partial class formAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvAccount = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.IDUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LeaderSX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateChangePass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 21);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 25);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvAccount
            // 
            this.gvAccount.AllowUserToAddRows = false;
            this.gvAccount.AllowUserToDeleteRows = false;
            this.gvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvAccount.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUser,
            this.UserName,
            this.Code,
            this.FullName,
            this.Active,
            this.LeaderSX,
            this.Admin,
            this.Register,
            this.Remark,
            this.DateChangePass,
            this.Edit});
            this.gvAccount.Location = new System.Drawing.Point(17, 97);
            this.gvAccount.Name = "gvAccount";
            this.gvAccount.ReadOnly = true;
            this.gvAccount.Size = new System.Drawing.Size(991, 493);
            this.gvAccount.TabIndex = 7;
            this.gvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAccount_CellClick);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.Image = global::PrintLabel.Properties.Resources.user_yellow_add_32x32;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(873, 48);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(135, 38);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm tài khoản";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // IDUser
            // 
            this.IDUser.DataPropertyName = "IDUser";
            this.IDUser.HeaderText = "IDUser";
            this.IDUser.Name = "IDUser";
            this.IDUser.ReadOnly = true;
            this.IDUser.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tài khoản";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Mã NV";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ tên";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 68;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // LeaderSX
            // 
            this.LeaderSX.DataPropertyName = "LeaderSX";
            this.LeaderSX.HeaderText = "Leader SX";
            this.LeaderSX.Name = "LeaderSX";
            this.LeaderSX.ReadOnly = true;
            this.LeaderSX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaderSX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            // 
            // Register
            // 
            this.Register.DataPropertyName = "Register";
            this.Register.HeaderText = "Ngày đăng ký";
            this.Register.Name = "Register";
            this.Register.ReadOnly = true;
            this.Register.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Register.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Ghi chú";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateChangePass
            // 
            this.DateChangePass.DataPropertyName = "DateChangePass";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.DateChangePass.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateChangePass.HeaderText = "Ngày YC đổi mk";
            this.DateChangePass.Name = "DateChangePass";
            this.DateChangePass.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.PaleGreen;
            this.btnExportExcel.Location = new System.Drawing.Point(430, 62);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(108, 27);
            this.btnExportExcel.TabIndex = 9;
            this.btnExportExcel.Text = "Xuất file Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // formAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 602);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.gvAccount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "formAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.formAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gvAccount;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LeaderSX;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateChangePass;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.Button btnExportExcel;
    }
}