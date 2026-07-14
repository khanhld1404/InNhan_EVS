namespace PrintLabel
{
    partial class formSettingPrintName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettingPrintName));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrintName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtDong = new System.Windows.Forms.TextBox();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxPackingList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grSetting = new System.Windows.Forms.GroupBox();
            this.txtRevision = new System.Windows.Forms.TextBox();
            this.txtShowSetting = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeSoBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPathSavePackingList = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            // txtDong
            // 
            this.txtDong.Location = new System.Drawing.Point(162, 60);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(34, 23);
            this.txtDong.TabIndex = 5;
            // 
            // txtWO
            // 
            this.txtWO.Location = new System.Drawing.Point(202, 60);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(34, 23);
            this.txtWO.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(242, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 23);
            this.txtID.TabIndex = 7;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(282, 60);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(34, 23);
            this.txtItem.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dong-WO-ID-Item-Rev";
            // 
            // txtMaxPackingList
            // 
            this.txtMaxPackingList.Location = new System.Drawing.Point(162, 93);
            this.txtMaxPackingList.Name = "txtMaxPackingList";
            this.txtMaxPackingList.Size = new System.Drawing.Size(34, 23);
            this.txtMaxPackingList.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max PackingList";
            // 
            // grSetting
            // 
            this.grSetting.Controls.Add(this.txtPathSavePackingList);
            this.grSetting.Controls.Add(this.label7);
            this.grSetting.Controls.Add(this.txtRevision);
            this.grSetting.Controls.Add(this.txtShowSetting);
            this.grSetting.Controls.Add(this.label6);
            this.grSetting.Controls.Add(this.txtHeSoBarcode);
            this.grSetting.Controls.Add(this.txtCopies);
            this.grSetting.Controls.Add(this.label2);
            this.grSetting.Controls.Add(this.label5);
            this.grSetting.Controls.Add(this.txtMaxPackingList);
            this.grSetting.Controls.Add(this.label4);
            this.grSetting.Controls.Add(this.txtDong);
            this.grSetting.Controls.Add(this.label3);
            this.grSetting.Controls.Add(this.txtWO);
            this.grSetting.Controls.Add(this.txtItem);
            this.grSetting.Controls.Add(this.txtID);
            this.grSetting.Location = new System.Drawing.Point(15, 79);
            this.grSetting.Name = "grSetting";
            this.grSetting.Size = new System.Drawing.Size(367, 219);
            this.grSetting.TabIndex = 12;
            this.grSetting.TabStop = false;
            this.grSetting.Text = "Setting";
            this.grSetting.Visible = false;
            // 
            // txtRevision
            // 
            this.txtRevision.Location = new System.Drawing.Point(322, 60);
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.Size = new System.Drawing.Size(34, 23);
            this.txtRevision.TabIndex = 16;
            // 
            // txtShowSetting
            // 
            this.txtShowSetting.Location = new System.Drawing.Point(162, 122);
            this.txtShowSetting.Name = "txtShowSetting";
            this.txtShowSetting.Size = new System.Drawing.Size(34, 23);
            this.txtShowSetting.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ShowSetting";
            // 
            // txtHeSoBarcode
            // 
            this.txtHeSoBarcode.Location = new System.Drawing.Point(162, 151);
            this.txtHeSoBarcode.Name = "txtHeSoBarcode";
            this.txtHeSoBarcode.Size = new System.Drawing.Size(74, 23);
            this.txtHeSoBarcode.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hệ số Barcode";
            // 
            // txtPathSavePackingList
            // 
            this.txtPathSavePackingList.Location = new System.Drawing.Point(162, 180);
            this.txtPathSavePackingList.Name = "txtPathSavePackingList";
            this.txtPathSavePackingList.Size = new System.Drawing.Size(194, 23);
            this.txtPathSavePackingList.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Path Save PackingList";
            // 
            // formSettingPrintName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 310);
            this.Controls.Add(this.grSetting);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrintName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formSettingPrintName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Print";
            this.Load += new System.EventHandler(this.formSettingPrintName_Load);
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
        private System.Windows.Forms.TextBox txtDong;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxPackingList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grSetting;
        private System.Windows.Forms.TextBox txtHeSoBarcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShowSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRevision;
        private System.Windows.Forms.TextBox txtPathSavePackingList;
        private System.Windows.Forms.Label label7;
    }
}