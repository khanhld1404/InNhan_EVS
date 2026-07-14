namespace PrintLabel
{
    partial class fromChangePassword
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
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yêu cầu thay đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(206, 60);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(222, 23);
            this.txtOldPass.TabIndex = 2;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(206, 102);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(222, 23);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtNewPassConfirm
            // 
            this.txtNewPassConfirm.Location = new System.Drawing.Point(206, 148);
            this.txtNewPassConfirm.Name = "txtNewPassConfirm";
            this.txtNewPassConfirm.Size = new System.Drawing.Size(222, 23);
            this.txtNewPassConfirm.TabIndex = 6;
            this.txtNewPassConfirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xác nhận mật khẩu mới";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.PaleGreen;
            this.btnChangePass.Location = new System.Drawing.Point(123, 225);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(130, 45);
            this.btnChangePass.TabIndex = 7;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnExit.Location = new System.Drawing.Point(298, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "* Mật khẩu phải có ít nhất 8 ký tự và chứa ít nhất 1 ký tự đặc biệt";
            // 
            // fromChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 309);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtNewPassConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fromChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPassConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
    }
}