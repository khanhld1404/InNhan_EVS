namespace PrintLabel
{
    partial class formCreatePLChonChungLoai
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboChungLoai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPL1 = new System.Windows.Forms.TextBox();
            this.clbThietBi = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPL2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPL3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPL4 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận chủng loại tạo Packing List";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(207, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 49);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chủng loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thiết bị";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(20, 251);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(171, 49);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintLabel.Properties.Resources.next_30x30;
            this.pictureBox1.Location = new System.Drawing.Point(401, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cboChungLoai
            // 
            this.cboChungLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChungLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChungLoai.FormattingEnabled = true;
            this.cboChungLoai.Location = new System.Drawing.Point(12, 75);
            this.cboChungLoai.Name = "cboChungLoai";
            this.cboChungLoai.Size = new System.Drawing.Size(373, 46);
            this.cboChungLoai.TabIndex = 2;
            this.cboChungLoai.SelectedValueChanged += new System.EventHandler(this.cboChungLoai_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã số danh sách đóng thùng";
            // 
            // txtMaPL1
            // 
            this.txtMaPL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPL1.Location = new System.Drawing.Point(16, 165);
            this.txtMaPL1.Name = "txtMaPL1";
            this.txtMaPL1.ReadOnly = true;
            this.txtMaPL1.Size = new System.Drawing.Size(163, 38);
            this.txtMaPL1.TabIndex = 9;
            this.txtMaPL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clbThietBi
            // 
            this.clbThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbThietBi.FormattingEnabled = true;
            this.clbThietBi.Location = new System.Drawing.Point(449, 75);
            this.clbThietBi.Name = "clbThietBi";
            this.clbThietBi.Size = new System.Drawing.Size(300, 204);
            this.clbThietBi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // txtMaPL2
            // 
            this.txtMaPL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPL2.Location = new System.Drawing.Point(207, 165);
            this.txtMaPL2.Name = "txtMaPL2";
            this.txtMaPL2.Size = new System.Drawing.Size(46, 38);
            this.txtMaPL2.TabIndex = 12;
            this.txtMaPL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaPL2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaPL2_KeyPress);
            this.txtMaPL2.Leave += new System.EventHandler(this.txtMaPL2_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // txtMaPL3
            // 
            this.txtMaPL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPL3.Location = new System.Drawing.Point(280, 165);
            this.txtMaPL3.Name = "txtMaPL3";
            this.txtMaPL3.Size = new System.Drawing.Size(39, 38);
            this.txtMaPL3.TabIndex = 14;
            this.txtMaPL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaPL3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaPL3_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "/";
            // 
            // txtMaPL4
            // 
            this.txtMaPL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPL4.Location = new System.Drawing.Point(346, 165);
            this.txtMaPL4.Name = "txtMaPL4";
            this.txtMaPL4.Size = new System.Drawing.Size(39, 38);
            this.txtMaPL4.TabIndex = 16;
            this.txtMaPL4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaPL4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaPL4_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(19, 213);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(154, 24);
            this.lbThongBao.TabIndex = 17;
            this.lbThongBao.Text = "Chỉ nhập ký tự số";
            this.lbThongBao.Visible = false;
            // 
            // formCreatePLChonChungLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 324);
            this.ControlBox = false;
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.txtMaPL4);
            this.Controls.Add(this.txtMaPL3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaPL2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaPL1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clbThietBi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboChungLoai);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCreatePLChonChungLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận chủng loại";
            this.Load += new System.EventHandler(this.formCreatePLChonChungLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboChungLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPL1;
        private System.Windows.Forms.CheckedListBox clbThietBi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPL2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaPL3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPL4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbThongBao;
    }
}