namespace PrintLabel
{
    partial class formNewPackingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNewPackingList));
            this.lbTitlePackingList = new System.Windows.Forms.Label();
            this.txtScanBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gvData = new System.Windows.Forms.DataGridView();
            this.btnXuatPackingList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChungLoai = new System.Windows.Forms.TextBox();
            this.txtThietBi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPackingList = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPackingList_OLD = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.lbLoading = new System.Windows.Forms.Label();
            this.Wo_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rev_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThietBi_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateScan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitlePackingList
            // 
            this.lbTitlePackingList.AutoSize = true;
            this.lbTitlePackingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitlePackingList.Location = new System.Drawing.Point(365, 9);
            this.lbTitlePackingList.Name = "lbTitlePackingList";
            this.lbTitlePackingList.Size = new System.Drawing.Size(201, 26);
            this.lbTitlePackingList.TabIndex = 5;
            this.lbTitlePackingList.Text = "Create Packing List";
            // 
            // txtScanBarcode
            // 
            this.txtScanBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtScanBarcode.Location = new System.Drawing.Point(115, 132);
            this.txtScanBarcode.Name = "txtScanBarcode";
            this.txtScanBarcode.Size = new System.Drawing.Size(608, 24);
            this.txtScanBarcode.TabIndex = 6;
            this.txtScanBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanBarcode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đọc mã vạch";
            // 
            // gvData
            // 
            this.gvData.AllowUserToAddRows = false;
            this.gvData.AllowUserToDeleteRows = false;
            this.gvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Wo_No,
            this.ID_No,
            this.Item_No,
            this.Rev_No,
            this.Qty,
            this.ThietBi_Detail,
            this.DateScan,
            this.Delete});
            this.gvData.Location = new System.Drawing.Point(12, 182);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.Size = new System.Drawing.Size(985, 419);
            this.gvData.TabIndex = 8;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
            // 
            // btnXuatPackingList
            // 
            this.btnXuatPackingList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatPackingList.BackColor = System.Drawing.Color.PaleGreen;
            this.btnXuatPackingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatPackingList.Location = new System.Drawing.Point(836, 607);
            this.btnXuatPackingList.Name = "btnXuatPackingList";
            this.btnXuatPackingList.Size = new System.Drawing.Size(161, 46);
            this.btnXuatPackingList.TabIndex = 9;
            this.btnXuatPackingList.Text = "Xuất PackingList";
            this.btnXuatPackingList.UseVisualStyleBackColor = false;
            this.btnXuatPackingList.Click += new System.EventHandler(this.btnXuatPackingList_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Yellow;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotal.Location = new System.Drawing.Point(81, 615);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(24, 26);
            this.lbTotal.TabIndex = 11;
            this.lbTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(352, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chủng loại";
            // 
            // txtChungLoai
            // 
            this.txtChungLoai.BackColor = System.Drawing.Color.Yellow;
            this.txtChungLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChungLoai.Location = new System.Drawing.Point(355, 67);
            this.txtChungLoai.Name = "txtChungLoai";
            this.txtChungLoai.ReadOnly = true;
            this.txtChungLoai.Size = new System.Drawing.Size(165, 24);
            this.txtChungLoai.TabIndex = 13;
            // 
            // txtThietBi
            // 
            this.txtThietBi.BackColor = System.Drawing.Color.Yellow;
            this.txtThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThietBi.Location = new System.Drawing.Point(550, 67);
            this.txtThietBi.Name = "txtThietBi";
            this.txtThietBi.ReadOnly = true;
            this.txtThietBi.Size = new System.Drawing.Size(173, 24);
            this.txtThietBi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(547, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thiết bị đóng thùng";
            // 
            // txtMaPackingList
            // 
            this.txtMaPackingList.BackColor = System.Drawing.Color.Yellow;
            this.txtMaPackingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPackingList.Location = new System.Drawing.Point(115, 67);
            this.txtMaPackingList.Name = "txtMaPackingList";
            this.txtMaPackingList.ReadOnly = true;
            this.txtMaPackingList.Size = new System.Drawing.Size(220, 24);
            this.txtMaPackingList.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(112, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã Packing list";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(757, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 113);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Navy;
            this.txtTaiKhoan.Location = new System.Drawing.Point(79, 27);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(155, 14);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.Text = "txtTaiKhoan";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Navy;
            this.txtHoTen.Location = new System.Drawing.Point(79, 63);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(155, 40);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.Text = "txtHoTen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Họ tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tài khoản:";
            // 
            // btnPackingList_OLD
            // 
            this.btnPackingList_OLD.BackColor = System.Drawing.Color.LightGray;
            this.btnPackingList_OLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPackingList_OLD.Location = new System.Drawing.Point(115, 96);
            this.btnPackingList_OLD.Name = "btnPackingList_OLD";
            this.btnPackingList_OLD.Size = new System.Drawing.Size(220, 27);
            this.btnPackingList_OLD.TabIndex = 19;
            this.btnPackingList_OLD.Text = "MÃ PACKING LIST CŨ";
            this.btnPackingList_OLD.UseVisualStyleBackColor = false;
            this.btnPackingList_OLD.Click += new System.EventHandler(this.btnPackingList_OLD_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(901, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 35);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // picLoading
            // 
            this.picLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picLoading.Image = global::PrintLabel.Properties.Resources._16;
            this.picLoading.Location = new System.Drawing.Point(649, 609);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(30, 32);
            this.picLoading.TabIndex = 21;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // lbLoading
            // 
            this.lbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoading.AutoSize = true;
            this.lbLoading.ForeColor = System.Drawing.Color.Red;
            this.lbLoading.Location = new System.Drawing.Point(683, 619);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(144, 15);
            this.lbLoading.TabIndex = 22;
            this.lbLoading.Text = "Đang xuất Packing List....";
            this.lbLoading.Visible = false;
            // 
            // Wo_No
            // 
            this.Wo_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wo_No.DataPropertyName = "Wo_No";
            this.Wo_No.HeaderText = "WO No";
            this.Wo_No.Name = "Wo_No";
            this.Wo_No.ReadOnly = true;
            // 
            // ID_No
            // 
            this.ID_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_No.DataPropertyName = "ID_No";
            this.ID_No.HeaderText = "ID No";
            this.ID_No.Name = "ID_No";
            this.ID_No.ReadOnly = true;
            // 
            // Item_No
            // 
            this.Item_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_No.DataPropertyName = "Item_No";
            this.Item_No.HeaderText = "Item No";
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
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // ThietBi_Detail
            // 
            this.ThietBi_Detail.DataPropertyName = "ThietBi_Detail";
            this.ThietBi_Detail.HeaderText = "Thiết bị";
            this.ThietBi_Detail.Name = "ThietBi_Detail";
            this.ThietBi_Detail.ReadOnly = true;
            // 
            // DateScan
            // 
            this.DateScan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateScan.DataPropertyName = "DateScan";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            this.DateScan.DefaultCellStyle = dataGridViewCellStyle1;
            this.DateScan.HeaderText = "Thời gian quét";
            this.DateScan.Name = "DateScan";
            this.DateScan.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // formNewPackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1009, 670);
            this.ControlBox = false;
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPackingList_OLD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaPackingList);
            this.Controls.Add(this.txtThietBi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChungLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXuatPackingList);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScanBarcode);
            this.Controls.Add(this.lbTitlePackingList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "formNewPackingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packing List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formNewPackingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitlePackingList;
        private System.Windows.Forms.TextBox txtScanBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.Button btnXuatPackingList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChungLoai;
        private System.Windows.Forms.TextBox txtThietBi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPackingList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnPackingList_OLD;
        private System.Windows.Forms.Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wo_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rev_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBi_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateScan;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}