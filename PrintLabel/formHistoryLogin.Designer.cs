namespace PrintLabel
{
    partial class formHistoryLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHistoryLogin));
            this.gvDataSearch = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.txtStrKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDataSearch
            // 
            this.gvDataSearch.AllowUserToAddRows = false;
            this.gvDataSearch.AllowUserToDeleteRows = false;
            this.gvDataSearch.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvDataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.FullName,
            this.TimeLogin,
            this.PCName,
            this.FuncDefault});
            this.gvDataSearch.Location = new System.Drawing.Point(29, 173);
            this.gvDataSearch.Name = "gvDataSearch";
            this.gvDataSearch.ReadOnly = true;
            this.gvDataSearch.Size = new System.Drawing.Size(1083, 496);
            this.gvDataSearch.TabIndex = 6;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Mã NV";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ tên";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // TimeLogin
            // 
            this.TimeLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeLogin.DataPropertyName = "TimeLogin";
            this.TimeLogin.HeaderText = "Đăng nhập";
            this.TimeLogin.Name = "TimeLogin";
            this.TimeLogin.ReadOnly = true;
            // 
            // PCName
            // 
            this.PCName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PCName.DataPropertyName = "PCName";
            this.PCName.HeaderText = "Tên máy";
            this.PCName.Name = "PCName";
            this.PCName.ReadOnly = true;
            // 
            // FuncDefault
            // 
            this.FuncDefault.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FuncDefault.DataPropertyName = "FuncDefault";
            this.FuncDefault.HeaderText = "Chức năng";
            this.FuncDefault.Name = "FuncDefault";
            this.FuncDefault.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.txtStrKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Image = global::PrintLabel.Properties.Resources.Excel;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcel.Location = new System.Drawing.Point(574, 22);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(89, 52);
            this.btnXuatExcel.TabIndex = 7;
            this.btnXuatExcel.Text = "Xuất file";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // txtStrKey
            // 
            this.txtStrKey.Location = new System.Drawing.Point(182, 55);
            this.txtStrKey.Name = "txtStrKey";
            this.txtStrKey.Size = new System.Drawing.Size(239, 22);
            this.txtStrKey.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ khóa tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearch.Image = global::PrintLabel.Properties.Resources.search20x20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(449, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 59);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(308, 20);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(113, 22);
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
            this.dtFrom.Location = new System.Drawing.Point(101, 20);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(113, 22);
            this.dtFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lịch sử đăng nhập";
            // 
            // formHistoryLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvDataSearch);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHistoryLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryLogin";
            ((System.ComponentModel.ISupportInitialize)(this.gvDataSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDataSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStrKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncDefault;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}