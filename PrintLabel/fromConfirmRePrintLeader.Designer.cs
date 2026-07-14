namespace PrintLabel
{
    partial class fromConfirmRePrintLeader
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericCopy = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLyDoInLai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInLai = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận Leader: In lại nhãn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(140, 60);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(196, 23);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số nhãn in lại";
            // 
            // numericCopy
            // 
            this.numericCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericCopy.Location = new System.Drawing.Point(140, 137);
            this.numericCopy.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericCopy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCopy.Name = "numericCopy";
            this.numericCopy.Size = new System.Drawing.Size(68, 24);
            this.numericCopy.TabIndex = 17;
            this.numericCopy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lý do in lại";
            // 
            // txtLyDoInLai
            // 
            this.txtLyDoInLai.Location = new System.Drawing.Point(140, 175);
            this.txtLyDoInLai.Multiline = true;
            this.txtLyDoInLai.Name = "txtLyDoInLai";
            this.txtLyDoInLai.Size = new System.Drawing.Size(196, 55);
            this.txtLyDoInLai.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(137, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "* Tối đa 250 ký tự";
            // 
            // btnInLai
            // 
            this.btnInLai.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInLai.Location = new System.Drawing.Point(54, 260);
            this.btnInLai.Name = "btnInLai";
            this.btnInLai.Size = new System.Drawing.Size(126, 41);
            this.btnInLai.TabIndex = 21;
            this.btnInLai.Text = "Xác nhận in lại";
            this.btnInLai.UseVisualStyleBackColor = false;
            this.btnInLai.Click += new System.EventHandler(this.btnInLai_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.Location = new System.Drawing.Point(210, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 41);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fromConfirmRePrintLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 339);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInLai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLyDoInLai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericCopy);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "fromConfirmRePrintLeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận Leader - In lại nhãn";
            ((System.ComponentModel.ISupportInitialize)(this.numericCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericCopy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLyDoInLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInLai;
        private System.Windows.Forms.Button btnCancel;
    }
}