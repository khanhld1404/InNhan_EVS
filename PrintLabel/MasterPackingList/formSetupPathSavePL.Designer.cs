namespace PrintLabel.MasterPackingList
{
    partial class formSetupPathSavePL
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
            this.txtPathExcel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPathPDF = new System.Windows.Forms.TextBox();
            this.btnPathExcel = new System.Windows.Forms.Button();
            this.btnPathPDF = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cài đặt đường dẫn lưu Packing List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "File excel";
            // 
            // txtPathExcel
            // 
            this.txtPathExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathExcel.Location = new System.Drawing.Point(94, 55);
            this.txtPathExcel.Name = "txtPathExcel";
            this.txtPathExcel.ReadOnly = true;
            this.txtPathExcel.Size = new System.Drawing.Size(359, 24);
            this.txtPathExcel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "File PDF";
            // 
            // txtPathPDF
            // 
            this.txtPathPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathPDF.Location = new System.Drawing.Point(94, 121);
            this.txtPathPDF.Name = "txtPathPDF";
            this.txtPathPDF.ReadOnly = true;
            this.txtPathPDF.Size = new System.Drawing.Size(359, 24);
            this.txtPathPDF.TabIndex = 4;
            // 
            // btnPathExcel
            // 
            this.btnPathExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathExcel.Location = new System.Drawing.Point(459, 46);
            this.btnPathExcel.Name = "btnPathExcel";
            this.btnPathExcel.Size = new System.Drawing.Size(75, 39);
            this.btnPathExcel.TabIndex = 5;
            this.btnPathExcel.Text = "Chọn";
            this.btnPathExcel.UseVisualStyleBackColor = true;
            this.btnPathExcel.Click += new System.EventHandler(this.btnPathExcel_Click);
            // 
            // btnPathPDF
            // 
            this.btnPathPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathPDF.Location = new System.Drawing.Point(459, 114);
            this.btnPathPDF.Name = "btnPathPDF";
            this.btnPathPDF.Size = new System.Drawing.Size(75, 39);
            this.btnPathPDF.TabIndex = 6;
            this.btnPathPDF.Text = "Chọn";
            this.btnPathPDF.UseVisualStyleBackColor = true;
            this.btnPathPDF.Click += new System.EventHandler(this.btnPathPDF_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(305, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 43);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formSetupPathSavePL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 233);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPathPDF);
            this.Controls.Add(this.btnPathExcel);
            this.Controls.Add(this.txtPathPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPathExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSetupPathSavePL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt đường dẫn lưu Paking list";
            this.Load += new System.EventHandler(this.formSetupPathSavePL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPathPDF;
        private System.Windows.Forms.Button btnPathExcel;
        private System.Windows.Forms.Button btnPathPDF;
        private System.Windows.Forms.Button btnSave;
    }
}