namespace PrintLabel.MasterPackingList
{
    partial class form_DetailPackingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DetailPackingList));
            this.lbTitlePackingList = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPackingList = new System.Windows.Forms.TextBox();
            this.txtThietBi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChungLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gvData = new System.Windows.Forms.DataGridView();
            this.Wo_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rev_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThietBi_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateScan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateCreate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTongTB = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnBoSungTB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitlePackingList
            // 
            this.lbTitlePackingList.AutoSize = true;
            this.lbTitlePackingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitlePackingList.Location = new System.Drawing.Point(307, 8);
            this.lbTitlePackingList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitlePackingList.Name = "lbTitlePackingList";
            this.lbTitlePackingList.Size = new System.Drawing.Size(287, 26);
            this.lbTitlePackingList.TabIndex = 6;
            this.lbTitlePackingList.Text = "Thông tin chi tiết Packing list";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(40, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mã Packing list";
            // 
            // txtMaPackingList
            // 
            this.txtMaPackingList.BackColor = System.Drawing.Color.Yellow;
            this.txtMaPackingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPackingList.Location = new System.Drawing.Point(43, 71);
            this.txtMaPackingList.Name = "txtMaPackingList";
            this.txtMaPackingList.ReadOnly = true;
            this.txtMaPackingList.Size = new System.Drawing.Size(302, 24);
            this.txtMaPackingList.TabIndex = 22;
            // 
            // txtThietBi
            // 
            this.txtThietBi.BackColor = System.Drawing.Color.Yellow;
            this.txtThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThietBi.Location = new System.Drawing.Point(193, 124);
            this.txtThietBi.Name = "txtThietBi";
            this.txtThietBi.ReadOnly = true;
            this.txtThietBi.Size = new System.Drawing.Size(152, 24);
            this.txtThietBi.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(190, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Thiết bị đóng thùng";
            // 
            // txtChungLoai
            // 
            this.txtChungLoai.BackColor = System.Drawing.Color.Yellow;
            this.txtChungLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChungLoai.Location = new System.Drawing.Point(43, 124);
            this.txtChungLoai.Name = "txtChungLoai";
            this.txtChungLoai.ReadOnly = true;
            this.txtChungLoai.Size = new System.Drawing.Size(134, 24);
            this.txtChungLoai.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Chủng loại";
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
            this.DateScan});
            this.gvData.Location = new System.Drawing.Point(10, 172);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.Size = new System.Drawing.Size(1025, 487);
            this.gvData.TabIndex = 24;
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
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Yellow;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.Location = new System.Drawing.Point(425, 71);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(269, 24);
            this.txtUser.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(422, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Người tạo";
            // 
            // txtDateCreate
            // 
            this.txtDateCreate.BackColor = System.Drawing.Color.Yellow;
            this.txtDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDateCreate.Location = new System.Drawing.Point(425, 124);
            this.txtDateCreate.Name = "txtDateCreate";
            this.txtDateCreate.ReadOnly = true;
            this.txtDateCreate.Size = new System.Drawing.Size(269, 24);
            this.txtDateCreate.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(422, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Thời gian tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(715, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tổng số thiết bị:";
            // 
            // lbTongTB
            // 
            this.lbTongTB.AutoSize = true;
            this.lbTongTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTongTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTB.ForeColor = System.Drawing.Color.Brown;
            this.lbTongTB.Location = new System.Drawing.Point(838, 52);
            this.lbTongTB.Name = "lbTongTB";
            this.lbTongTB.Size = new System.Drawing.Size(55, 39);
            this.lbTongTB.TabIndex = 30;
            this.lbTongTB.Text = "00";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.PaleGreen;
            this.btnXuatExcel.Location = new System.Drawing.Point(719, 104);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(174, 44);
            this.btnXuatExcel.TabIndex = 31;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnBoSungTB
            // 
            this.btnBoSungTB.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBoSungTB.ForeColor = System.Drawing.Color.Transparent;
            this.btnBoSungTB.Location = new System.Drawing.Point(899, 103);
            this.btnBoSungTB.Name = "btnBoSungTB";
            this.btnBoSungTB.Size = new System.Drawing.Size(136, 44);
            this.btnBoSungTB.TabIndex = 32;
            this.btnBoSungTB.Text = "Bổ sung thiết bị";
            this.btnBoSungTB.UseVisualStyleBackColor = false;
            this.btnBoSungTB.Visible = false;
            this.btnBoSungTB.Click += new System.EventHandler(this.btnBoSungTB_Click);
            // 
            // form_DetailPackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 686);
            this.Controls.Add(this.btnBoSungTB);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.lbTongTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDateCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaPackingList);
            this.Controls.Add(this.txtThietBi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChungLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTitlePackingList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_DetailPackingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.form_DetailPackingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitlePackingList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaPackingList;
        private System.Windows.Forms.TextBox txtThietBi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChungLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTongTB;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wo_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rev_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBi_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateScan;
        private System.Windows.Forms.Button btnBoSungTB;
    }
}