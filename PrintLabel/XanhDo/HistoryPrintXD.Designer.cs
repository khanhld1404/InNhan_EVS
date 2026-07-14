namespace PrintLabel.XanhDo
{
    partial class HistoryPrintXD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.txtStrKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gvDataSearch = new System.Windows.Forms.DataGridView();
            this.WONo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimesPrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminConfirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoInLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 3;
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
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1098, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.LightBlue;
            this.btnExportExcel.Image = global::PrintLabel.Properties.Resources.Excel;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(636, 23);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(110, 67);
            this.btnExportExcel.TabIndex = 14;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // txtStrKey
            // 
            this.txtStrKey.Location = new System.Drawing.Point(198, 69);
            this.txtStrKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStrKey.Name = "txtStrKey";
            this.txtStrKey.Size = new System.Drawing.Size(292, 21);
            this.txtStrKey.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Từ khóa tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearch.Image = global::PrintLabel.Properties.Resources.search20x20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(516, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 70);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(359, 23);
            this.dtTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(131, 21);
            this.dtTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(110, 23);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(131, 21);
            this.dtFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.WONo,
            this.IDNo,
            this.ItemNo,
            this.RevNo,
            this.TimesPrint,
            this.strFull,
            this.DatePrint,
            this.Status,
            this.Reason2,
            this.UserPrint,
            this.AdminConfirm,
            this.LyDoInLai,
            this.PCName});
            this.gvDataSearch.Location = new System.Drawing.Point(13, 192);
            this.gvDataSearch.Name = "gvDataSearch";
            this.gvDataSearch.ReadOnly = true;
            this.gvDataSearch.Size = new System.Drawing.Size(1098, 496);
            this.gvDataSearch.TabIndex = 5;
            // 
            // WONo
            // 
            this.WONo.DataPropertyName = "WONo";
            this.WONo.HeaderText = "WO No";
            this.WONo.Name = "WONo";
            this.WONo.ReadOnly = true;
            // 
            // IDNo
            // 
            this.IDNo.DataPropertyName = "IDNo";
            this.IDNo.HeaderText = "ID No";
            this.IDNo.Name = "IDNo";
            this.IDNo.ReadOnly = true;
            // 
            // ItemNo
            // 
            this.ItemNo.DataPropertyName = "ItemNo";
            this.ItemNo.HeaderText = "Item No";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.ReadOnly = true;
            // 
            // RevNo
            // 
            this.RevNo.DataPropertyName = "RevNo";
            this.RevNo.HeaderText = "Rev No";
            this.RevNo.Name = "RevNo";
            this.RevNo.ReadOnly = true;
            // 
            // TimesPrint
            // 
            this.TimesPrint.DataPropertyName = "TimesPrint";
            this.TimesPrint.HeaderText = "SL thiết bị";
            this.TimesPrint.Name = "TimesPrint";
            this.TimesPrint.ReadOnly = true;
            // 
            // strFull
            // 
            this.strFull.DataPropertyName = "strFull";
            this.strFull.HeaderText = "Barcode";
            this.strFull.Name = "strFull";
            this.strFull.ReadOnly = true;
            // 
            // DatePrint
            // 
            this.DatePrint.DataPropertyName = "DatePrint";
            this.DatePrint.HeaderText = "Thời gian in";
            this.DatePrint.Name = "DatePrint";
            this.DatePrint.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Nhãn in";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Reason2
            // 
            this.Reason2.DataPropertyName = "Reason";
            this.Reason2.HeaderText = "Ghi chú";
            this.Reason2.Name = "Reason2";
            this.Reason2.ReadOnly = true;
            // 
            // UserPrint
            // 
            this.UserPrint.DataPropertyName = "UserPrint";
            this.UserPrint.HeaderText = "Mã NV";
            this.UserPrint.Name = "UserPrint";
            this.UserPrint.ReadOnly = true;
            // 
            // AdminConfirm
            // 
            this.AdminConfirm.DataPropertyName = "AdminConfirm";
            this.AdminConfirm.HeaderText = "Leader XN";
            this.AdminConfirm.Name = "AdminConfirm";
            this.AdminConfirm.ReadOnly = true;
            // 
            // LyDoInLai
            // 
            this.LyDoInLai.DataPropertyName = "LyDoInLai";
            this.LyDoInLai.HeaderText = "Lý do";
            this.LyDoInLai.Name = "LyDoInLai";
            this.LyDoInLai.ReadOnly = true;
            // 
            // PCName
            // 
            this.PCName.DataPropertyName = "PCName";
            this.PCName.HeaderText = "Tên máy";
            this.PCName.Name = "PCName";
            this.PCName.ReadOnly = true;
            // 
            // HistoryPrintXD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 739);
            this.Controls.Add(this.gvDataSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HistoryPrintXD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử in nhãn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStrKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridView gvDataSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn WONo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimesPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoInLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCName;
    }
}