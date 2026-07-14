namespace PrintLabel.XacNhanJIG
{
    partial class MainConfirmJIG
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnQLMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemJigMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSetupFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripUser = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtScanBarcode = new System.Windows.Forms.TextBox();
            this.lbScan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gvData = new System.Windows.Forms.DataGridView();
            this.IDCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JIGMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JIGPicking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JIGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyPickMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyPickActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManualPicking = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.XuatLai = new System.Windows.Forms.DataGridViewImageColumn();
            this.XoaJig = new System.Windows.Forms.DataGridViewImageColumn();
            this.Re_Picking = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtIDCheck_nextStep = new System.Windows.Forms.TextBox();
            this.txtCongDoan_nextStep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtJigMaster_nextStep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNameJig_nextStep = new System.Windows.Forms.TextBox();
            this.txtStep_nextStep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQtyMaster_nextStep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtWO_info = new System.Windows.Forms.TextBox();
            this.txtRevNo_Info = new System.Windows.Forms.TextBox();
            this.txtItemNo_info = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDNo_info = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnChangeWO = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQLMaster,
            this.mnAbout});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnQLMaster
            // 
            this.mnQLMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemJigMaster,
            this.mnAccount,
            this.mnSetupFunction});
            this.mnQLMaster.Image = global::PrintLabel.Properties.Resources.system32x32;
            this.mnQLMaster.Name = "mnQLMaster";
            this.mnQLMaster.Size = new System.Drawing.Size(115, 20);
            this.mnQLMaster.Text = "Quản lý master";
            // 
            // mnItemJigMaster
            // 
            this.mnItemJigMaster.Image = global::PrintLabel.Properties.Resources.edit_20x20_2;
            this.mnItemJigMaster.Name = "mnItemJigMaster";
            this.mnItemJigMaster.Size = new System.Drawing.Size(170, 22);
            this.mnItemJigMaster.Text = "Item- Jig master";
            // 
            // mnAccount
            // 
            this.mnAccount.Image = global::PrintLabel.Properties.Resources.iconfinder_Users_85409;
            this.mnAccount.Name = "mnAccount";
            this.mnAccount.Size = new System.Drawing.Size(170, 22);
            this.mnAccount.Text = "Account";
            // 
            // mnSetupFunction
            // 
            this.mnSetupFunction.Image = global::PrintLabel.Properties.Resources.chia_24x24;
            this.mnSetupFunction.Name = "mnSetupFunction";
            this.mnSetupFunction.Size = new System.Drawing.Size(170, 22);
            this.mnSetupFunction.Text = "Cài đặt chức năng";
            // 
            // mnAbout
            // 
            this.mnAbout.Image = global::PrintLabel.Properties.Resources.info_20x20;
            this.mnAbout.Name = "mnAbout";
            this.mnAbout.Size = new System.Drawing.Size(68, 20);
            this.mnAbout.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 750);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1152, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripUser
            // 
            this.toolStripUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripUser.Image = global::PrintLabel.Properties.Resources.user_32x32;
            this.toolStripUser.Name = "toolStripUser";
            this.toolStripUser.Size = new System.Drawing.Size(78, 22);
            this.toolStripUser.Text = "UserName";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtScanBarcode);
            this.groupBox1.Controls.Add(this.lbScan);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1128, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtScanBarcode
            // 
            this.txtScanBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScanBarcode.BackColor = System.Drawing.Color.Yellow;
            this.txtScanBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanBarcode.Location = new System.Drawing.Point(244, 28);
            this.txtScanBarcode.Name = "txtScanBarcode";
            this.txtScanBarcode.Size = new System.Drawing.Size(878, 29);
            this.txtScanBarcode.TabIndex = 1;
            this.txtScanBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanBarcodeWO_KeyDown);
            // 
            // lbScan
            // 
            this.lbScan.AutoSize = true;
            this.lbScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScan.ForeColor = System.Drawing.Color.Navy;
            this.lbScan.Location = new System.Drawing.Point(6, 30);
            this.lbScan.Name = "lbScan";
            this.lbScan.Size = new System.Drawing.Size(235, 26);
            this.lbScan.TabIndex = 0;
            this.lbScan.Text = "Quét mã vạch trên WO";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1128, 625);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gvData);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(269, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(853, 608);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin xác nhận";
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
            this.IDCheck,
            this.TenCD,
            this.Step,
            this.JIGMaster,
            this.JIGPicking,
            this.JIGName,
            this.QtyPickMaster,
            this.QtyPickActual,
            this.Result,
            this.Remark,
            this.ItemName,
            this.ManualPicking,
            this.XuatLai,
            this.XoaJig,
            this.Re_Picking});
            this.gvData.Location = new System.Drawing.Point(6, 27);
            this.gvData.MultiSelect = false;
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowHeadersWidth = 4;
            this.gvData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gvData.Size = new System.Drawing.Size(841, 575);
            this.gvData.TabIndex = 0;
            this.gvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellContentClick);
            // 
            // IDCheck
            // 
            this.IDCheck.DataPropertyName = "IDCheck";
            this.IDCheck.HeaderText = "IDCheck";
            this.IDCheck.Name = "IDCheck";
            this.IDCheck.ReadOnly = true;
            this.IDCheck.Visible = false;
            // 
            // TenCD
            // 
            this.TenCD.DataPropertyName = "TenCD";
            this.TenCD.HeaderText = "Công đoạn";
            this.TenCD.Name = "TenCD";
            this.TenCD.ReadOnly = true;
            this.TenCD.Width = 70;
            // 
            // Step
            // 
            this.Step.DataPropertyName = "Step";
            this.Step.HeaderText = "Bước SD";
            this.Step.Name = "Step";
            this.Step.ReadOnly = true;
            this.Step.Width = 50;
            // 
            // JIGMaster
            // 
            this.JIGMaster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JIGMaster.DataPropertyName = "JIGMaster";
            this.JIGMaster.HeaderText = "Mã JIG";
            this.JIGMaster.Name = "JIGMaster";
            this.JIGMaster.ReadOnly = true;
            // 
            // JIGPicking
            // 
            this.JIGPicking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JIGPicking.DataPropertyName = "JIGPicking";
            this.JIGPicking.HeaderText = "Mã JIG SD";
            this.JIGPicking.Name = "JIGPicking";
            this.JIGPicking.ReadOnly = true;
            // 
            // JIGName
            // 
            this.JIGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JIGName.DataPropertyName = "JIGName";
            this.JIGName.HeaderText = "Tên JIG";
            this.JIGName.Name = "JIGName";
            this.JIGName.ReadOnly = true;
            // 
            // QtyPickMaster
            // 
            this.QtyPickMaster.DataPropertyName = "QtyPickMaster";
            this.QtyPickMaster.HeaderText = "QtyPickMaster";
            this.QtyPickMaster.Name = "QtyPickMaster";
            this.QtyPickMaster.ReadOnly = true;
            this.QtyPickMaster.Visible = false;
            this.QtyPickMaster.Width = 60;
            // 
            // QtyPickActual
            // 
            this.QtyPickActual.DataPropertyName = "QtyPickActual";
            this.QtyPickActual.HeaderText = "Số lượng";
            this.QtyPickActual.Name = "QtyPickActual";
            this.QtyPickActual.ReadOnly = true;
            this.QtyPickActual.Width = 60;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Kết quả";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 90;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Ghi chú";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Visible = false;
            // 
            // ManualPicking
            // 
            this.ManualPicking.DataPropertyName = "ManualPicking";
            this.ManualPicking.HeaderText = "ManualPicking";
            this.ManualPicking.Name = "ManualPicking";
            this.ManualPicking.ReadOnly = true;
            this.ManualPicking.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ManualPicking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ManualPicking.Visible = false;
            // 
            // XuatLai
            // 
            this.XuatLai.Description = "Xuất lại Jig";
            this.XuatLai.HeaderText = "";
            this.XuatLai.Image = global::PrintLabel.Properties.Resources.synchronize_16x16;
            this.XuatLai.Name = "XuatLai";
            this.XuatLai.ReadOnly = true;
            this.XuatLai.Width = 30;
            // 
            // XoaJig
            // 
            this.XoaJig.HeaderText = "";
            this.XoaJig.Image = global::PrintLabel.Properties.Resources.cancel_16x16;
            this.XoaJig.Name = "XoaJig";
            this.XoaJig.ReadOnly = true;
            this.XoaJig.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XoaJig.ToolTipText = "Hủy";
            this.XoaJig.Width = 30;
            // 
            // Re_Picking
            // 
            this.Re_Picking.DataPropertyName = "Re_Picking";
            this.Re_Picking.HeaderText = "RePicking";
            this.Re_Picking.Name = "Re_Picking";
            this.Re_Picking.ReadOnly = true;
            this.Re_Picking.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.btnLogout);
            this.groupBox3.Controls.Add(this.btnChangeWO);
            this.groupBox3.Controls.Add(this.btnExportFile);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(6, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 608);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thực hiện";
            // 
            // btnExportFile
            // 
            this.btnExportFile.BackColor = System.Drawing.Color.PaleGreen;
            this.btnExportFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.Location = new System.Drawing.Point(6, 532);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(246, 44);
            this.btnExportFile.TabIndex = 21;
            this.btnExportFile.Text = "Xuất file thống kê Jig";
            this.btnExportFile.UseVisualStyleBackColor = false;
            this.btnExportFile.Visible = false;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox6.Controls.Add(this.txtIDCheck_nextStep);
            this.groupBox6.Controls.Add(this.txtCongDoan_nextStep);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtJigMaster_nextStep);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtNameJig_nextStep);
            this.groupBox6.Controls.Add(this.txtStep_nextStep);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtQtyMaster_nextStep);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Navy;
            this.groupBox6.Location = new System.Drawing.Point(5, 226);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 246);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bước tiếp theo";
            // 
            // txtIDCheck_nextStep
            // 
            this.txtIDCheck_nextStep.Location = new System.Drawing.Point(72, 202);
            this.txtIDCheck_nextStep.Name = "txtIDCheck_nextStep";
            this.txtIDCheck_nextStep.ReadOnly = true;
            this.txtIDCheck_nextStep.Size = new System.Drawing.Size(50, 22);
            this.txtIDCheck_nextStep.TabIndex = 19;
            this.txtIDCheck_nextStep.Visible = false;
            // 
            // txtCongDoan_nextStep
            // 
            this.txtCongDoan_nextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCongDoan_nextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongDoan_nextStep.Location = new System.Drawing.Point(72, 32);
            this.txtCongDoan_nextStep.Name = "txtCongDoan_nextStep";
            this.txtCongDoan_nextStep.ReadOnly = true;
            this.txtCongDoan_nextStep.Size = new System.Drawing.Size(169, 23);
            this.txtCongDoan_nextStep.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tên Jig";
            // 
            // txtJigMaster_nextStep
            // 
            this.txtJigMaster_nextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtJigMaster_nextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJigMaster_nextStep.Location = new System.Drawing.Point(72, 102);
            this.txtJigMaster_nextStep.Name = "txtJigMaster_nextStep";
            this.txtJigMaster_nextStep.ReadOnly = true;
            this.txtJigMaster_nextStep.Size = new System.Drawing.Size(169, 23);
            this.txtJigMaster_nextStep.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mã Jig";
            // 
            // txtNameJig_nextStep
            // 
            this.txtNameJig_nextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNameJig_nextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameJig_nextStep.Location = new System.Drawing.Point(72, 137);
            this.txtNameJig_nextStep.Name = "txtNameJig_nextStep";
            this.txtNameJig_nextStep.ReadOnly = true;
            this.txtNameJig_nextStep.Size = new System.Drawing.Size(169, 23);
            this.txtNameJig_nextStep.TabIndex = 17;
            // 
            // txtStep_nextStep
            // 
            this.txtStep_nextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStep_nextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStep_nextStep.Location = new System.Drawing.Point(72, 67);
            this.txtStep_nextStep.Name = "txtStep_nextStep";
            this.txtStep_nextStep.ReadOnly = true;
            this.txtStep_nextStep.Size = new System.Drawing.Size(169, 23);
            this.txtStep_nextStep.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "C.Đoạn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Số lượng";
            // 
            // txtQtyMaster_nextStep
            // 
            this.txtQtyMaster_nextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQtyMaster_nextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyMaster_nextStep.Location = new System.Drawing.Point(72, 172);
            this.txtQtyMaster_nextStep.Name = "txtQtyMaster_nextStep";
            this.txtQtyMaster_nextStep.ReadOnly = true;
            this.txtQtyMaster_nextStep.Size = new System.Drawing.Size(169, 23);
            this.txtQtyMaster_nextStep.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bước SD";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.txtWO_info);
            this.groupBox5.Controls.Add(this.txtRevNo_Info);
            this.groupBox5.Controls.Add(this.txtItemNo_info);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtIDNo_info);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(5, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(246, 179);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chỉ thị sản xuất";
            // 
            // txtWO_info
            // 
            this.txtWO_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWO_info.Location = new System.Drawing.Point(72, 33);
            this.txtWO_info.Name = "txtWO_info";
            this.txtWO_info.ReadOnly = true;
            this.txtWO_info.Size = new System.Drawing.Size(169, 23);
            this.txtWO_info.TabIndex = 2;
            // 
            // txtRevNo_Info
            // 
            this.txtRevNo_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevNo_Info.Location = new System.Drawing.Point(72, 124);
            this.txtRevNo_Info.Name = "txtRevNo_Info";
            this.txtRevNo_Info.ReadOnly = true;
            this.txtRevNo_Info.Size = new System.Drawing.Size(169, 23);
            this.txtRevNo_Info.TabIndex = 8;
            // 
            // txtItemNo_info
            // 
            this.txtItemNo_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo_info.Location = new System.Drawing.Point(72, 94);
            this.txtItemNo_info.Name = "txtItemNo_info";
            this.txtItemNo_info.ReadOnly = true;
            this.txtItemNo_info.Size = new System.Drawing.Size(169, 23);
            this.txtItemNo_info.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "IDNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "WONo";
            // 
            // txtIDNo_info
            // 
            this.txtIDNo_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNo_info.Location = new System.Drawing.Point(72, 65);
            this.txtIDNo_info.Name = "txtIDNo_info";
            this.txtIDNo_info.ReadOnly = true;
            this.txtIDNo_info.Size = new System.Drawing.Size(169, 23);
            this.txtIDNo_info.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "ItemNo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "RevNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(423, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xác nhận JIG";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Xuất lại";
            this.dataGridViewImageColumn1.Image = global::PrintLabel.Properties.Resources.restart_16x16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.ToolTipText = "Xuất lại";
            this.dataGridViewImageColumn1.Width = 45;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PrintLabel.Properties.Resources.cancel_16x16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Hủy";
            this.dataGridViewImageColumn2.Width = 45;
            // 
            // btnChangeWO
            // 
            this.btnChangeWO.BackColor = System.Drawing.Color.PowderBlue;
            this.btnChangeWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeWO.Location = new System.Drawing.Point(5, 478);
            this.btnChangeWO.Name = "btnChangeWO";
            this.btnChangeWO.Size = new System.Drawing.Size(135, 44);
            this.btnChangeWO.TabIndex = 22;
            this.btnChangeWO.Text = "Thay đổi WO";
            this.btnChangeWO.UseVisualStyleBackColor = false;
            this.btnChangeWO.Click += new System.EventHandler(this.btnChangeWO_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Pink;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(150, 478);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 44);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainConfirmJIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1152, 775);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "MainConfirmJIG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận Jig ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainConfirmJIG_FormClosing);
            this.Load += new System.EventHandler(this.MainConfirmJIG_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnQLMaster;
        private System.Windows.Forms.ToolStripMenuItem mnAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripUser;
        private System.Windows.Forms.ToolStripMenuItem mnItemJigMaster;
        private System.Windows.Forms.ToolStripMenuItem mnAccount;
        private System.Windows.Forms.ToolStripMenuItem mnSetupFunction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScan;
        private System.Windows.Forms.TextBox txtScanBarcode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtRevNo_Info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemNo_info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDNo_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWO_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCongDoan_nextStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStep_nextStep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNameJig_nextStep;
        private System.Windows.Forms.TextBox txtQtyMaster_nextStep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJigMaster_nextStep;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnExportFile;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.TextBox txtIDCheck_nextStep;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn JIGMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn JIGPicking;
        private System.Windows.Forms.DataGridViewTextBoxColumn JIGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyPickMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyPickActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ManualPicking;
        private System.Windows.Forms.DataGridViewImageColumn XuatLai;
        private System.Windows.Forms.DataGridViewImageColumn XoaJig;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Re_Picking;
        private System.Windows.Forms.Button btnChangeWO;
        private System.Windows.Forms.Button btnLogout;
    }
}