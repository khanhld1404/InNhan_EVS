namespace PrintLabel.XacNhanJIG
{
    partial class ConfirmLeader
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJigMaster = new System.Windows.Forms.TextBox();
            this.txtJigPicking = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReasonNG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserNameLerder = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận Leader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã JIG (master)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã JIG sử dụng";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Location = new System.Drawing.Point(288, 218);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 55);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kết quả";
            // 
            // txtJigMaster
            // 
            this.txtJigMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJigMaster.Location = new System.Drawing.Point(139, 43);
            this.txtJigMaster.Name = "txtJigMaster";
            this.txtJigMaster.ReadOnly = true;
            this.txtJigMaster.Size = new System.Drawing.Size(275, 26);
            this.txtJigMaster.TabIndex = 4;
            // 
            // txtJigPicking
            // 
            this.txtJigPicking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJigPicking.Location = new System.Drawing.Point(139, 82);
            this.txtJigPicking.Name = "txtJigPicking";
            this.txtJigPicking.ReadOnly = true;
            this.txtJigPicking.Size = new System.Drawing.Size(275, 26);
            this.txtJigPicking.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Pink;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(139, 116);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(275, 26);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "NG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lý do";
            // 
            // txtReasonNG
            // 
            this.txtReasonNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonNG.Location = new System.Drawing.Point(139, 152);
            this.txtReasonNG.Multiline = true;
            this.txtReasonNG.Name = "txtReasonNG";
            this.txtReasonNG.Size = new System.Drawing.Size(275, 38);
            this.txtReasonNG.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tài khoản";
            // 
            // txtUserNameLerder
            // 
            this.txtUserNameLerder.Location = new System.Drawing.Point(139, 218);
            this.txtUserNameLerder.Name = "txtUserNameLerder";
            this.txtUserNameLerder.Size = new System.Drawing.Size(136, 23);
            this.txtUserNameLerder.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 247);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // ConfirmLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(433, 302);
            this.ControlBox = false;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserNameLerder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReasonNG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtJigPicking);
            this.Controls.Add(this.txtJigMaster);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmLeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận Leader";
            this.Load += new System.EventHandler(this.ConfirmLeader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJigMaster;
        private System.Windows.Forms.TextBox txtJigPicking;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReasonNG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserNameLerder;
        private System.Windows.Forms.TextBox txtPassword;
    }
}