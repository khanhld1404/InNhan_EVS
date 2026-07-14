namespace PrintLabel
{
    partial class formPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrint));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripControl = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFuncDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHisLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHisPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScanBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_WONo = new System.Windows.Forms.Label();
            this.lbIDNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbItemNo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label4 = new System.Windows.Forms.Label();
            this.numericCopy = new System.Windows.Forms.NumericUpDown();
            this.lbRevNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTenMay = new System.Windows.Forms.Label();
            this.lbMaChucNang = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.btnInNhanDG_TAS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCopy)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.MenuAccount,
            this.menuStripControl,
            this.menuStripSetting,
            this.menuStripHistory,
            this.menuStripAbout,
            this.menuStripLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNotepad});
            this.menuStripFile.Image = global::PrintLabel.Properties.Resources.iconfinder_Open_1493293;
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(53, 20);
            this.menuStripFile.Text = "File";
            this.menuStripFile.Visible = false;
            // 
            // menuStripNotepad
            // 
            this.menuStripNotepad.Image = global::PrintLabel.Properties.Resources.iconfinder_edit_7709;
            this.menuStripNotepad.Name = "menuStripNotepad";
            this.menuStripNotepad.Size = new System.Drawing.Size(120, 22);
            this.menuStripNotepad.Text = "Notepad";
            this.menuStripNotepad.Click += new System.EventHandler(this.menuStripNotepad_Click);
            // 
            // MenuAccount
            // 
            this.MenuAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChangePass});
            this.MenuAccount.Image = global::PrintLabel.Properties.Resources.user_32x32;
            this.MenuAccount.Name = "MenuAccount";
            this.MenuAccount.Size = new System.Drawing.Size(85, 20);
            this.MenuAccount.Text = "Tài khoản";
            // 
            // menuChangePass
            // 
            this.menuChangePass.Image = global::PrintLabel.Properties.Resources.reset_password_24x24;
            this.menuChangePass.Name = "menuChangePass";
            this.menuChangePass.Size = new System.Drawing.Size(145, 22);
            this.menuChangePass.Text = "Đổi mật khẩu";
            this.menuChangePass.Click += new System.EventHandler(this.menuChangePass_Click);
            // 
            // menuStripControl
            // 
            this.menuStripControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.mnFuncDefault});
            this.menuStripControl.Image = global::PrintLabel.Properties.Resources.Control2424;
            this.menuStripControl.Name = "menuStripControl";
            this.menuStripControl.Size = new System.Drawing.Size(76, 20);
            this.menuStripControl.Text = "Quản lý";
            this.menuStripControl.Click += new System.EventHandler(this.menuStripControl_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Image = global::PrintLabel.Properties.Resources.iconfinder_Users_85409;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.accountToolStripMenuItem.Text = "Tài khoản";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // mnFuncDefault
            // 
            this.mnFuncDefault.Image = global::PrintLabel.Properties.Resources.chia_24x24;
            this.mnFuncDefault.Name = "mnFuncDefault";
            this.mnFuncDefault.Size = new System.Drawing.Size(185, 22);
            this.mnFuncDefault.Text = "Chức năng mặc định";
            this.mnFuncDefault.Click += new System.EventHandler(this.mnFuncDefault_Click);
            // 
            // menuStripSetting
            // 
            this.menuStripSetting.Image = global::PrintLabel.Properties.Resources.setting;
            this.menuStripSetting.Name = "menuStripSetting";
            this.menuStripSetting.Size = new System.Drawing.Size(72, 20);
            this.menuStripSetting.Text = "Cài đặt";
            this.menuStripSetting.Click += new System.EventHandler(this.menuStripSetting_Click);
            // 
            // menuStripHistory
            // 
            this.menuStripHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripHisLogin,
            this.menuStripHisPrint});
            this.menuStripHistory.Image = global::PrintLabel.Properties.Resources.iconfinder_Clock4_34216;
            this.menuStripHistory.Name = "menuStripHistory";
            this.menuStripHistory.Size = new System.Drawing.Size(72, 20);
            this.menuStripHistory.Text = "Lịch sử";
            this.menuStripHistory.Visible = false;
            // 
            // menuStripHisLogin
            // 
            this.menuStripHisLogin.Image = global::PrintLabel.Properties.Resources.iconfinder_history_45291;
            this.menuStripHisLogin.Name = "menuStripHisLogin";
            this.menuStripHisLogin.Size = new System.Drawing.Size(171, 22);
            this.menuStripHisLogin.Text = "Lịch sử đăng nhập";
            this.menuStripHisLogin.Click += new System.EventHandler(this.menuStripHisLogin_Click);
            // 
            // menuStripHisPrint
            // 
            this.menuStripHisPrint.Image = global::PrintLabel.Properties.Resources.historyPrint;
            this.menuStripHisPrint.Name = "menuStripHisPrint";
            this.menuStripHisPrint.Size = new System.Drawing.Size(171, 22);
            this.menuStripHisPrint.Text = "Lịch sử In nhãn";
            this.menuStripHisPrint.Click += new System.EventHandler(this.menuStripHisPrint_Click);
            // 
            // menuStripAbout
            // 
            this.menuStripAbout.Image = global::PrintLabel.Properties.Resources.info_20x20;
            this.menuStripAbout.Name = "menuStripAbout";
            this.menuStripAbout.Size = new System.Drawing.Size(86, 20);
            this.menuStripAbout.Text = "Thông tin";
            this.menuStripAbout.Click += new System.EventHandler(this.menuStripAbout_Click);
            // 
            // menuStripLogout
            // 
            this.menuStripLogout.Image = global::PrintLabel.Properties.Resources.iconfinder_exit_3855614;
            this.menuStripLogout.Name = "menuStripLogout";
            this.menuStripLogout.Size = new System.Drawing.Size(89, 20);
            this.menuStripLogout.Text = "Đăng xuất";
            this.menuStripLogout.Click += new System.EventHandler(this.menuStripLogout_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.Location = new System.Drawing.Point(163, 33);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(234, 36);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "In nhãn Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quét mã vạch";
            // 
            // txtScanBarcode
            // 
            this.txtScanBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtScanBarcode.Location = new System.Drawing.Point(128, 137);
            this.txtScanBarcode.Name = "txtScanBarcode";
            this.txtScanBarcode.Size = new System.Drawing.Size(466, 32);
            this.txtScanBarcode.TabIndex = 4;
            this.txtScanBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanBarcode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(123, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "W/O No. - ";
            // 
            // lb_WONo
            // 
            this.lb_WONo.AutoSize = true;
            this.lb_WONo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_WONo.Location = new System.Drawing.Point(263, 226);
            this.lb_WONo.Name = "lb_WONo";
            this.lb_WONo.Size = new System.Drawing.Size(96, 26);
            this.lb_WONo.TabIndex = 6;
            this.lb_WONo.Text = "W/O No";
            // 
            // lbIDNo
            // 
            this.lbIDNo.AutoSize = true;
            this.lbIDNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIDNo.Location = new System.Drawing.Point(263, 292);
            this.lbIDNo.Name = "lbIDNo";
            this.lbIDNo.Size = new System.Drawing.Size(73, 26);
            this.lbIDNo.TabIndex = 8;
            this.lbIDNo.Text = "ID No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(123, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID No. - ";
            // 
            // lbItemNo
            // 
            this.lbItemNo.AutoSize = true;
            this.lbItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbItemNo.Location = new System.Drawing.Point(263, 355);
            this.lbItemNo.Name = "lbItemNo";
            this.lbItemNo.Size = new System.Drawing.Size(96, 26);
            this.lbItemNo.TabIndex = 10;
            this.lbItemNo.Text = "Item No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(123, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Item No. - ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tài khoản:";
            // 
            // lbFullName
            // 
            this.lbFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFullName.AutoSize = true;
            this.lbFullName.BackColor = System.Drawing.Color.Yellow;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFullName.Location = new System.Drawing.Point(112, 32);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(44, 16);
            this.lbFullName.TabIndex = 13;
            this.lbFullName.Text = "Name";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(463, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số nhãn";
            // 
            // numericCopy
            // 
            this.numericCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericCopy.Location = new System.Drawing.Point(532, 176);
            this.numericCopy.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericCopy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCopy.Name = "numericCopy";
            this.numericCopy.Size = new System.Drawing.Size(62, 24);
            this.numericCopy.TabIndex = 16;
            this.numericCopy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbRevNo
            // 
            this.lbRevNo.AutoSize = true;
            this.lbRevNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRevNo.Location = new System.Drawing.Point(263, 421);
            this.lbRevNo.Name = "lbRevNo";
            this.lbRevNo.Size = new System.Drawing.Size(91, 26);
            this.lbRevNo.TabIndex = 18;
            this.lbRevNo.Text = "Rev No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(124, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rev No. - ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbTenMay);
            this.groupBox1.Controls.Add(this.lbMaChucNang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbFullName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(769, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản - Chức năng";
            // 
            // lbTenMay
            // 
            this.lbTenMay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenMay.AutoSize = true;
            this.lbTenMay.BackColor = System.Drawing.Color.Yellow;
            this.lbTenMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenMay.Location = new System.Drawing.Point(112, 60);
            this.lbTenMay.Name = "lbTenMay";
            this.lbTenMay.Size = new System.Drawing.Size(57, 16);
            this.lbTenMay.TabIndex = 18;
            this.lbTenMay.Text = "TenMay";
            // 
            // lbMaChucNang
            // 
            this.lbMaChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaChucNang.AutoSize = true;
            this.lbMaChucNang.BackColor = System.Drawing.Color.Yellow;
            this.lbMaChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaChucNang.Location = new System.Drawing.Point(112, 91);
            this.lbMaChucNang.Name = "lbMaChucNang";
            this.lbMaChucNang.Size = new System.Drawing.Size(83, 15);
            this.lbMaChucNang.TabIndex = 16;
            this.lbMaChucNang.Text = "MaChucNang";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tên máy:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã chức năng:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrint.Image = global::PrintLabel.Properties.Resources.iconfinder_print_16_22615;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(605, 137);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 32);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(127, 496);
            this.picBarcode.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(240, 16);
            this.picBarcode.TabIndex = 11;
            this.picBarcode.TabStop = false;
            // 
            // btnInNhanDG_TAS
            // 
            this.btnInNhanDG_TAS.BackColor = System.Drawing.Color.DarkGreen;
            this.btnInNhanDG_TAS.ForeColor = System.Drawing.Color.White;
            this.btnInNhanDG_TAS.Location = new System.Drawing.Point(169, 76);
            this.btnInNhanDG_TAS.Name = "btnInNhanDG_TAS";
            this.btnInNhanDG_TAS.Size = new System.Drawing.Size(218, 33);
            this.btnInNhanDG_TAS.TabIndex = 20;
            this.btnInNhanDG_TAS.Text = "In nhãn đóng gói TAS";
            this.btnInNhanDG_TAS.UseVisualStyleBackColor = false;
            this.btnInNhanDG_TAS.Click += new System.EventHandler(this.btnInNhanDG_TAS_Click);
            // 
            // formPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 669);
            this.Controls.Add(this.btnInNhanDG_TAS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRevNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.lbItemNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbIDNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_WONo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScanBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In nhãn Barcode";
            this.Load += new System.EventHandler(this.formPrint_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCopy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripControl;
        private System.Windows.Forms.ToolStripMenuItem menuStripHistory;
        private System.Windows.Forms.ToolStripMenuItem menuStripHisLogin;
        private System.Windows.Forms.ToolStripMenuItem menuStripHisPrint;
        private System.Windows.Forms.ToolStripMenuItem menuStripLogout;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScanBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_WONo;
        private System.Windows.Forms.Label lbIDNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbItemNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripNotepad;
        private System.Windows.Forms.ToolStripMenuItem menuStripAbout;
        private System.Windows.Forms.ToolStripMenuItem menuStripSetting;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericCopy;
        private System.Windows.Forms.Label lbRevNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem mnFuncDefault;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTenMay;
        private System.Windows.Forms.Label lbMaChucNang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem MenuAccount;
        private System.Windows.Forms.ToolStripMenuItem menuChangePass;
        private System.Windows.Forms.Button btnInNhanDG_TAS;
    }
}