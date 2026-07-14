namespace PrintLabel
{
    partial class formHistoryPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHistoryPrint));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStrKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gvDataSearch = new System.Windows.Forms.DataGridView();
            this.WO_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rev_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrePrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderConfirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch sử in nhãn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportExcel);
            this.groupBox1.Controls.Add(this.txtStrKey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtStrKey
            // 
            this.txtStrKey.Location = new System.Drawing.Point(170, 60);
            this.txtStrKey.Name = "txtStrKey";
            this.txtStrKey.Size = new System.Drawing.Size(251, 21);
            this.txtStrKey.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Từ khóa tìm kiếm";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(308, 20);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(113, 21);
            this.dtTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(94, 20);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(113, 21);
            this.dtFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ";
            // 
            // gvDataSearch
            // 
            this.gvDataSearch.AllowUserToAddRows = false;
            this.gvDataSearch.AllowUserToDeleteRows = false;
            this.gvDataSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDataSearch.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvDataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WO_No,
            this.ID_No,
            this.Item_No,
            this.Rev_No,
            this.Copies,
            this.strFull,
            this.TimePrint,
            this.Col1,
            this.PrePrint,
            this.Reason,
            this.LeaderConfirm,
            this.FuncCode,
            this.Code,
            this.FullName});
            this.gvDataSearch.Location = new System.Drawing.Point(12, 182);
            this.gvDataSearch.Name = "gvDataSearch";
            this.gvDataSearch.ReadOnly = true;
            this.gvDataSearch.Size = new System.Drawing.Size(1083, 496);
            this.gvDataSearch.TabIndex = 4;
            // 
            // WO_No
            // 
            this.WO_No.DataPropertyName = "WO_No";
            this.WO_No.HeaderText = "WO_No";
            this.WO_No.Name = "WO_No";
            this.WO_No.ReadOnly = true;
            // 
            // ID_No
            // 
            this.ID_No.DataPropertyName = "ID_No";
            this.ID_No.HeaderText = "ID_No";
            this.ID_No.Name = "ID_No";
            this.ID_No.ReadOnly = true;
            // 
            // Item_No
            // 
            this.Item_No.DataPropertyName = "Item_No";
            this.Item_No.HeaderText = "Item_No";
            this.Item_No.Name = "Item_No";
            this.Item_No.ReadOnly = true;
            // 
            // Rev_No
            // 
            this.Rev_No.DataPropertyName = "Rev_No";
            this.Rev_No.HeaderText = "Rev No";
            this.Rev_No.Name = "Rev_No";
            this.Rev_No.ReadOnly = true;
            // 
            // Copies
            // 
            this.Copies.DataPropertyName = "Copies";
            this.Copies.HeaderText = "Số nhãn";
            this.Copies.Name = "Copies";
            this.Copies.ReadOnly = true;
            // 
            // strFull
            // 
            this.strFull.DataPropertyName = "strFull";
            this.strFull.HeaderText = "Barcode";
            this.strFull.Name = "strFull";
            this.strFull.ReadOnly = true;
            // 
            // TimePrint
            // 
            this.TimePrint.DataPropertyName = "TimePrint";
            this.TimePrint.HeaderText = "Thời gian in";
            this.TimePrint.Name = "TimePrint";
            this.TimePrint.ReadOnly = true;
            // 
            // Col1
            // 
            this.Col1.DataPropertyName = "Col1";
            this.Col1.HeaderText = "Tên máy";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // PrePrint
            // 
            this.PrePrint.DataPropertyName = "PrePrint";
            this.PrePrint.HeaderText = "In lại";
            this.PrePrint.Name = "PrePrint";
            this.PrePrint.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Lý do";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // LeaderConfirm
            // 
            this.LeaderConfirm.DataPropertyName = "LeaderConfirm";
            this.LeaderConfirm.HeaderText = "Leader XN";
            this.LeaderConfirm.Name = "LeaderConfirm";
            this.LeaderConfirm.ReadOnly = true;
            // 
            // FuncCode
            // 
            this.FuncCode.DataPropertyName = "FuncCode";
            this.FuncCode.HeaderText = "Mã chức năng";
            this.FuncCode.Name = "FuncCode";
            this.FuncCode.ReadOnly = true;
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
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ tên";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.LightBlue;
            this.btnExportExcel.Image = global::PrintLabel.Properties.Resources.Excel;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(560, 20);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(109, 61);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearch.Image = global::PrintLabel.Properties.Resources.search20x20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(442, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 61);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // formHistoryPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 745);
            this.Controls.Add(this.gvDataSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHistoryPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History Print";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvDataSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.TextBox txtStrKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn WO_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rev_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrePrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}