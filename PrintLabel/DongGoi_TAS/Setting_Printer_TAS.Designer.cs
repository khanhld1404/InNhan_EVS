namespace PrintLabel
{
    partial class Setting_Printer_TAS
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
            this.txtPrintName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.grSetting = new System.Windows.Forms.GroupBox();
            this.txtHeSoBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Print Name";
            // 
            // txtPrintName
            // 
            this.txtPrintName.Location = new System.Drawing.Point(96, 21);
            this.txtPrintName.Name = "txtPrintName";
            this.txtPrintName.Size = new System.Drawing.Size(206, 23);
            this.txtPrintName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(308, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(162, 31);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(194, 23);
            this.txtCopies.TabIndex = 4;
            // 
            // grSetting
            // 
            this.grSetting.Controls.Add(this.txtHeSoBarcode);
            this.grSetting.Controls.Add(this.txtCopies);
            this.grSetting.Controls.Add(this.label2);
            this.grSetting.Controls.Add(this.label5);
            this.grSetting.Location = new System.Drawing.Point(15, 79);
            this.grSetting.Name = "grSetting";
            this.grSetting.Size = new System.Drawing.Size(367, 219);
            this.grSetting.TabIndex = 12;
            this.grSetting.TabStop = false;
            this.grSetting.Text = "Setting";
            // 
            // txtHeSoBarcode
            // 
            this.txtHeSoBarcode.Location = new System.Drawing.Point(162, 70);
            this.txtHeSoBarcode.Name = "txtHeSoBarcode";
            this.txtHeSoBarcode.Size = new System.Drawing.Size(74, 23);
            this.txtHeSoBarcode.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hệ số Barcode";
            // 
            // Setting_Printer_TAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 310);
            this.Controls.Add(this.grSetting);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrintName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Setting_Printer_TAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Print";
            this.Load += new System.EventHandler(this.Setting_Printer_TAS_Load);
            this.grSetting.ResumeLayout(false);
            this.grSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrintName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.GroupBox grSetting;
        private System.Windows.Forms.TextBox txtHeSoBarcode;
        private System.Windows.Forms.Label label5;
    }
}