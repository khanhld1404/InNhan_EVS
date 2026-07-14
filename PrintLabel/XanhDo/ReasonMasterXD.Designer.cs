namespace PrintLabel.XanhDo
{
    partial class ReasonMasterXD
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
            this.gvData = new System.Windows.Forms.DataGridView();
            this.btnNew_Reason = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveReason = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvData
            // 
            this.gvData.AllowUserToAddRows = false;
            this.gvData.AllowUserToDeleteRows = false;
            this.gvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Description,
            this.ActiveReason,
            this.Edit,
            this.Delete});
            this.gvData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvData.Location = new System.Drawing.Point(0, 34);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowHeadersWidth = 15;
            this.gvData.Size = new System.Drawing.Size(715, 338);
            this.gvData.TabIndex = 5;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
            // 
            // btnNew_Reason
            // 
            this.btnNew_Reason.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNew_Reason.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew_Reason.Image = global::PrintLabel.Properties.Resources.createnew_24x24;
            this.btnNew_Reason.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew_Reason.Location = new System.Drawing.Point(197, 0);
            this.btnNew_Reason.Name = "btnNew_Reason";
            this.btnNew_Reason.Size = new System.Drawing.Size(37, 33);
            this.btnNew_Reason.TabIndex = 6;
            this.btnNew_Reason.UseVisualStyleBackColor = false;
            this.btnNew_Reason.Click += new System.EventHandler(this.btnNew_Reason_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.Bisque;
            this.btnExportToExcel.Image = global::PrintLabel.Properties.Resources.Excel;
            this.btnExportToExcel.Location = new System.Drawing.Point(592, 2);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(40, 30);
            this.btnExportToExcel.TabIndex = 5;
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(326, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnNew_Reason);
            this.panel1.Controls.Add(this.btnExportToExcel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 34);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý master Reason";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(537, 378);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 47);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Reason";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ActiveReason
            // 
            this.ActiveReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActiveReason.DataPropertyName = "ActiveReason";
            this.ActiveReason.HeaderText = "Active";
            this.ActiveReason.Name = "ActiveReason";
            this.ActiveReason.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // ReasonMasterXD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 457);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReasonMasterXD";
            this.Text = "Reason";
            this.Load += new System.EventHandler(this.ReasonMasterXD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.Button btnNew_Reason;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActiveReason;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}