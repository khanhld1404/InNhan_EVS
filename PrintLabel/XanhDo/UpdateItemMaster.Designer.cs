namespace PrintLabel.XanhDo
{
    partial class UpdateItemMaster
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
            this.lbHeaderForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericFrom = new System.Windows.Forms.NumericUpDown();
            this.numericTo = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeaderForm
            // 
            this.lbHeaderForm.AutoSize = true;
            this.lbHeaderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderForm.Location = new System.Drawing.Point(83, 9);
            this.lbHeaderForm.Name = "lbHeaderForm";
            this.lbHeaderForm.Size = new System.Drawing.Size(110, 22);
            this.lbHeaderForm.TabIndex = 0;
            this.lbHeaderForm.Text = "HeaderForm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item No";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo.Location = new System.Drawing.Point(68, 46);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(186, 21);
            this.txtItemNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            this.label3.Visible = false;
            // 
            // numericFrom
            // 
            this.numericFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFrom.Location = new System.Drawing.Point(68, 79);
            this.numericFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFrom.Name = "numericFrom";
            this.numericFrom.Size = new System.Drawing.Size(67, 21);
            this.numericFrom.TabIndex = 3;
            this.numericFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericFrom.Visible = false;
            // 
            // numericTo
            // 
            this.numericTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTo.Location = new System.Drawing.Point(182, 79);
            this.numericTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericTo.Name = "numericTo";
            this.numericTo.Size = new System.Drawing.Size(72, 21);
            this.numericTo.TabIndex = 4;
            this.numericTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericTo.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(68, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(179, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 211);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericTo);
            this.Controls.Add(this.numericFrom);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHeaderForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateItemMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật Item Master";
            this.Load += new System.EventHandler(this.UpdateItemMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeaderForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericFrom;
        private System.Windows.Forms.NumericUpDown numericTo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}