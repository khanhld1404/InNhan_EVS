namespace PrintLabel.MasterPackingList
{
    partial class formEditThietBi
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChungLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(82, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(255, 24);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Thêm mới / Chỉnh sửa thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn chủng loại";
            // 
            // cboChungLoai
            // 
            this.cboChungLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChungLoai.FormattingEnabled = true;
            this.cboChungLoai.Location = new System.Drawing.Point(170, 53);
            this.cboChungLoai.Name = "cboChungLoai";
            this.cboChungLoai.Size = new System.Drawing.Size(183, 24);
            this.cboChungLoai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thiết bị";
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(170, 92);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(183, 23);
            this.txtTenThietBi.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Location = new System.Drawing.Point(170, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 49);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Pink;
            this.btnCancel.Location = new System.Drawing.Point(268, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 49);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // formEditThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 205);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTenThietBi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboChungLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEditThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chủng loại - thiết bị";
            this.Load += new System.EventHandler(this.formEditThietBi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChungLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}