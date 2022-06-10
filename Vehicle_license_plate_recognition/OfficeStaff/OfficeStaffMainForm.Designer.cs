namespace Vehicle_license_plate_recognition.OfficeStaff
{
    partial class OfficeStaffMainForm
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
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mANAGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalRevenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.turnoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchlStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_timekeeping = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView_phancongtho = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phancongtho)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStaff.Location = new System.Drawing.Point(136, 68);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.ReadOnly = true;
            this.txtIDStaff.Size = new System.Drawing.Size(198, 38);
            this.txtIDStaff.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 59;
            this.label1.Text = "ID Staff";
            // 
            // mANAGEToolStripMenuItem
            // 
            this.mANAGEToolStripMenuItem.Name = "mANAGEToolStripMenuItem";
            this.mANAGEToolStripMenuItem.Size = new System.Drawing.Size(298, 36);
            this.mANAGEToolStripMenuItem.Text = "Manager Customer";
            this.mANAGEToolStripMenuItem.Click += new System.EventHandler(this.mANAGEToolStripMenuItem_Click);
            // 
            // rEMOVEToolStripMenuItem
            // 
            this.rEMOVEToolStripMenuItem.Name = "rEMOVEToolStripMenuItem";
            this.rEMOVEToolStripMenuItem.Size = new System.Drawing.Size(298, 36);
            this.rEMOVEToolStripMenuItem.Text = "Remove Customer";
            this.rEMOVEToolStripMenuItem.Click += new System.EventHandler(this.rEMOVEToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(298, 36);
            this.eDITToolStripMenuItem.Text = "Edit Customer";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(298, 36);
            this.aDDToolStripMenuItem.Text = "Add Customer";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // cUSTOMERToolStripMenuItem
            // 
            this.cUSTOMERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.rEMOVEToolStripMenuItem,
            this.mANAGEToolStripMenuItem});
            this.cUSTOMERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.cUSTOMERToolStripMenuItem.Name = "cUSTOMERToolStripMenuItem";
            this.cUSTOMERToolStripMenuItem.Size = new System.Drawing.Size(145, 35);
            this.cUSTOMERToolStripMenuItem.Text = "CUSTOMER";
            // 
            // totalRevenueToolStripMenuItem
            // 
            this.totalRevenueToolStripMenuItem.Name = "totalRevenueToolStripMenuItem";
            this.totalRevenueToolStripMenuItem.Size = new System.Drawing.Size(238, 36);
            this.totalRevenueToolStripMenuItem.Text = "Total revenue";
            this.totalRevenueToolStripMenuItem.Click += new System.EventHandler(this.totalRevenueToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Location = new System.Drawing.Point(1152, 62);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(167, 44);
            this.btnLogout.TabIndex = 61;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // turnoverToolStripMenuItem
            // 
            this.turnoverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalRevenueToolStripMenuItem});
            this.turnoverToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoverToolStripMenuItem.Name = "turnoverToolStripMenuItem";
            this.turnoverToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.turnoverToolStripMenuItem.Text = "TURNOVER";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchlStripMenuItem});
            this.statusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(103, 35);
            this.statusToolStripMenuItem.Text = "STATUS";
            // 
            // searchlStripMenuItem
            // 
            this.searchlStripMenuItem.Name = "searchlStripMenuItem";
            this.searchlStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.searchlStripMenuItem.Text = "Search";
            this.searchlStripMenuItem.Click += new System.EventHandler(this.searchlStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editContractToolStripMenuItem
            // 
            this.editContractToolStripMenuItem.Name = "editContractToolStripMenuItem";
            this.editContractToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.editContractToolStripMenuItem.Text = "Edit contract";
            this.editContractToolStripMenuItem.Click += new System.EventHandler(this.editContractToolStripMenuItem_Click);
            // 
            // addContractToolStripMenuItem
            // 
            this.addContractToolStripMenuItem.Name = "addContractToolStripMenuItem";
            this.addContractToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.addContractToolStripMenuItem.Text = "Add contract";
            this.addContractToolStripMenuItem.Click += new System.EventHandler(this.addContractToolStripMenuItem_Click);
            // 
            // contractToolStripMenuItem
            // 
            this.contractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContractToolStripMenuItem,
            this.editContractToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contractToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            this.contractToolStripMenuItem.Size = new System.Drawing.Size(142, 35);
            this.contractToolStripMenuItem.Text = "CONTRACT";
            // 
            // button_timekeeping
            // 
            this.button_timekeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_timekeeping.Location = new System.Drawing.Point(519, 683);
            this.button_timekeeping.Name = "button_timekeeping";
            this.button_timekeeping.Size = new System.Drawing.Size(312, 44);
            this.button_timekeeping.TabIndex = 57;
            this.button_timekeeping.Text = "TIMEKEEPING";
            this.button_timekeeping.UseVisualStyleBackColor = true;
            this.button_timekeeping.Click += new System.EventHandler(this.button_timekeeping_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contractToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.turnoverToolStripMenuItem,
            this.cUSTOMERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1335, 39);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStripOffice";
            // 
            // dataGridView_phancongtho
            // 
            this.dataGridView_phancongtho.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_phancongtho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phancongtho.Location = new System.Drawing.Point(12, 122);
            this.dataGridView_phancongtho.Name = "dataGridView_phancongtho";
            this.dataGridView_phancongtho.RowHeadersWidth = 51;
            this.dataGridView_phancongtho.RowTemplate.Height = 24;
            this.dataGridView_phancongtho.Size = new System.Drawing.Size(1307, 544);
            this.dataGridView_phancongtho.TabIndex = 55;
            // 
            // OfficeStaffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 739);
            this.Controls.Add(this.txtIDStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button_timekeeping);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView_phancongtho);
            this.Name = "OfficeStaffMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfficeStaffMainForm";
            this.Load += new System.EventHandler(this.OfficeStaffMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phancongtho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mANAGEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalRevenueToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem turnoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchlStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractToolStripMenuItem;
        private System.Windows.Forms.Button button_timekeeping;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView_phancongtho;
    }
}