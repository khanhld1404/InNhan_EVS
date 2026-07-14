namespace PrintLabel.XanhDo
{
    partial class PrinterSetup
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
            this.cboGreenPrinter = new System.Windows.Forms.ComboBox();
            this.cboRedPrinter = new System.Windows.Forms.ComboBox();
            this.btnSavePrinter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cài đặt máy in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Máy in nhãn xanh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Máy in nhãn đỏ";
            // 
            // cboGreenPrinter
            // 
            this.cboGreenPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGreenPrinter.FormattingEnabled = true;
            this.cboGreenPrinter.Location = new System.Drawing.Point(138, 56);
            this.cboGreenPrinter.Name = "cboGreenPrinter";
            this.cboGreenPrinter.Size = new System.Drawing.Size(222, 24);
            this.cboGreenPrinter.TabIndex = 2;
            // 
            // cboRedPrinter
            // 
            this.cboRedPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRedPrinter.FormattingEnabled = true;
            this.cboRedPrinter.Location = new System.Drawing.Point(138, 94);
            this.cboRedPrinter.Name = "cboRedPrinter";
            this.cboRedPrinter.Size = new System.Drawing.Size(222, 24);
            this.cboRedPrinter.TabIndex = 3;
            // 
            // btnSavePrinter
            // 
            this.btnSavePrinter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSavePrinter.Location = new System.Drawing.Point(275, 124);
            this.btnSavePrinter.Name = "btnSavePrinter";
            this.btnSavePrinter.Size = new System.Drawing.Size(85, 42);
            this.btnSavePrinter.TabIndex = 4;
            this.btnSavePrinter.Text = "Lưu";
            this.btnSavePrinter.UseVisualStyleBackColor = false;
            this.btnSavePrinter.Click += new System.EventHandler(this.btnSavePrinter_Click);
            // 
            // PrinterSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 189);
            this.Controls.Add(this.btnSavePrinter);
            this.Controls.Add(this.cboRedPrinter);
            this.Controls.Add(this.cboGreenPrinter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrinterSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt máy in";
            this.Load += new System.EventHandler(this.PrinterSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGreenPrinter;
        private System.Windows.Forms.ComboBox cboRedPrinter;
        private System.Windows.Forms.Button btnSavePrinter;
    }
}