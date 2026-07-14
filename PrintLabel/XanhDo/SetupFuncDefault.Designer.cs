namespace PrintLabel.XanhDo
{
    partial class SetupFuncDefault
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
            this.btnSaveSetup = new System.Windows.Forms.Button();
            this.cboFunc = new System.Windows.Forms.ComboBox();
            this.lbTenMay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPakingList = new System.Windows.Forms.Button();
            this.btnInNhan_DongGoi = new System.Windows.Forms.Button();
            this.btnInNhanXanhDo = new System.Windows.Forms.Button();
            this.btnInNhanTrang = new System.Windows.Forms.Button();
            this.btnConfirmJIG = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cài đặt chức năng mặc định";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveSetup);
            this.groupBox1.Controls.Add(this.cboFunc);
            this.groupBox1.Controls.Add(this.lbTenMay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt chức năng in nhãn mặc định";
            // 
            // btnSaveSetup
            // 
            this.btnSaveSetup.Location = new System.Drawing.Point(577, 40);
            this.btnSaveSetup.Name = "btnSaveSetup";
            this.btnSaveSetup.Size = new System.Drawing.Size(69, 28);
            this.btnSaveSetup.TabIndex = 3;
            this.btnSaveSetup.Text = "Lưu";
            this.btnSaveSetup.UseVisualStyleBackColor = true;
            this.btnSaveSetup.Click += new System.EventHandler(this.btnSaveSetup_Click);
            // 
            // cboFunc
            // 
            this.cboFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFunc.ForeColor = System.Drawing.Color.Navy;
            this.cboFunc.FormattingEnabled = true;
            this.cboFunc.Items.AddRange(new object[] {
            "NHAN_BARCODE_KITTING",
            "NHAN_BARCODE_DONGGOI",
            "NHAN_QC",
            "PACKING_LIST",
            "None"});
            this.cboFunc.Location = new System.Drawing.Point(248, 40);
            this.cboFunc.Name = "cboFunc";
            this.cboFunc.Size = new System.Drawing.Size(323, 28);
            this.cboFunc.TabIndex = 2;
            // 
            // lbTenMay
            // 
            this.lbTenMay.AutoSize = true;
            this.lbTenMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMay.ForeColor = System.Drawing.Color.Navy;
            this.lbTenMay.Location = new System.Drawing.Point(101, 44);
            this.lbTenMay.Name = "lbTenMay";
            this.lbTenMay.Size = new System.Drawing.Size(132, 24);
            this.lbTenMay.TabIndex = 1;
            this.lbTenMay.Text = "TVC-EVS-00X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên máy:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPakingList);
            this.groupBox2.Controls.Add(this.btnInNhan_DongGoi);
            this.groupBox2.Controls.Add(this.btnInNhanXanhDo);
            this.groupBox2.Controls.Add(this.btnInNhanTrang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Truy cập chức năng";
            // 
            // btnPakingList
            // 
            this.btnPakingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPakingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPakingList.ForeColor = System.Drawing.Color.Navy;
            this.btnPakingList.Location = new System.Drawing.Point(390, 26);
            this.btnPakingList.Name = "btnPakingList";
            this.btnPakingList.Size = new System.Drawing.Size(176, 84);
            this.btnPakingList.TabIndex = 3;
            this.btnPakingList.Text = "Tạo Packing List";
            this.btnPakingList.UseVisualStyleBackColor = false;
            this.btnPakingList.Click += new System.EventHandler(this.btnPakingList_Click);
            // 
            // btnInNhan_DongGoi
            // 
            this.btnInNhan_DongGoi.BackColor = System.Drawing.Color.White;
            this.btnInNhan_DongGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInNhan_DongGoi.ForeColor = System.Drawing.Color.Black;
            this.btnInNhan_DongGoi.Location = new System.Drawing.Point(203, 26);
            this.btnInNhan_DongGoi.Name = "btnInNhan_DongGoi";
            this.btnInNhan_DongGoi.Size = new System.Drawing.Size(176, 84);
            this.btnInNhan_DongGoi.TabIndex = 2;
            this.btnInNhan_DongGoi.Text = "In nhãn Barcode\r\nĐÓNG GÓI";
            this.btnInNhan_DongGoi.UseVisualStyleBackColor = false;
            this.btnInNhan_DongGoi.Click += new System.EventHandler(this.btnInNhan_DongGoi_Click);
            // 
            // btnInNhanXanhDo
            // 
            this.btnInNhanXanhDo.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInNhanXanhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInNhanXanhDo.ForeColor = System.Drawing.Color.Red;
            this.btnInNhanXanhDo.Location = new System.Drawing.Point(577, 26);
            this.btnInNhanXanhDo.Name = "btnInNhanXanhDo";
            this.btnInNhanXanhDo.Size = new System.Drawing.Size(176, 84);
            this.btnInNhanXanhDo.TabIndex = 1;
            this.btnInNhanXanhDo.Text = "In nhãn QC";
            this.btnInNhanXanhDo.UseVisualStyleBackColor = false;
            this.btnInNhanXanhDo.Click += new System.EventHandler(this.btnInNhanXanhDo_Click);
            // 
            // btnInNhanTrang
            // 
            this.btnInNhanTrang.BackColor = System.Drawing.Color.White;
            this.btnInNhanTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInNhanTrang.ForeColor = System.Drawing.Color.Black;
            this.btnInNhanTrang.Location = new System.Drawing.Point(17, 26);
            this.btnInNhanTrang.Name = "btnInNhanTrang";
            this.btnInNhanTrang.Size = new System.Drawing.Size(176, 84);
            this.btnInNhanTrang.TabIndex = 0;
            this.btnInNhanTrang.Text = "In nhãn Barcode\r\nKITTING";
            this.btnInNhanTrang.UseVisualStyleBackColor = false;
            this.btnInNhanTrang.Click += new System.EventHandler(this.btnInNhanTrang_Click);
            // 
            // btnConfirmJIG
            // 
            this.btnConfirmJIG.BackColor = System.Drawing.Color.LightBlue;
            this.btnConfirmJIG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmJIG.Location = new System.Drawing.Point(12, 317);
            this.btnConfirmJIG.Name = "btnConfirmJIG";
            this.btnConfirmJIG.Size = new System.Drawing.Size(119, 39);
            this.btnConfirmJIG.TabIndex = 1;
            this.btnConfirmJIG.Text = "Xác nhận JIG - chưa áp dụng";
            this.btnConfirmJIG.UseVisualStyleBackColor = false;
            this.btnConfirmJIG.Visible = false;
            this.btnConfirmJIG.Click += new System.EventHandler(this.btnConfirmJIG_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Salmon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(674, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SetupFuncDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 385);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirmJIG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupFuncDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt chức năng mặc định";
            this.Load += new System.EventHandler(this.SetupFuncDefault_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTenMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInNhanTrang;
        private System.Windows.Forms.Button btnConfirmJIG;
        private System.Windows.Forms.Button btnInNhanXanhDo;
        private System.Windows.Forms.ComboBox cboFunc;
        private System.Windows.Forms.Button btnSaveSetup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInNhan_DongGoi;
        private System.Windows.Forms.Button btnPakingList;
    }
}