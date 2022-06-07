namespace Vehicle_license_plate_recognition.Manager.Staff
{
    partial class UpdateStaffManager
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
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DVGStaff = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelXuLi = new System.Windows.Forms.Panel();
            this.radioBtnCaretaker = new System.Windows.Forms.RadioButton();
            this.radioBtnOfficer = new System.Windows.Forms.RadioButton();
            this.radioBtnManager = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGStaff)).BeginInit();
            this.panelXuLi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click_1);
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.Click += new System.EventHandler(this.PictureBoxImage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1801, 80);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelXuLi);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnUpdateStaff);
            this.panel2.Size = new System.Drawing.Size(1801, 717);
            this.panel2.Controls.SetChildIndex(this.btnCancel, 0);
            this.panel2.Controls.SetChildIndex(this.btnUpdateStaff, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.btnSearch, 0);
            this.panel2.Controls.SetChildIndex(this.textBox1, 0);
            this.panel2.Controls.SetChildIndex(this.panelXuLi, 0);
            // 
            // txtID
            // 
            this.txtID.ReadOnly = true;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(785, 662);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(122, 38);
            this.btnUpdateStaff.TabIndex = 58;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DVGStaff);
            this.panel3.Location = new System.Drawing.Point(948, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 549);
            this.panel3.TabIndex = 59;
            // 
            // DVGStaff
            // 
            this.DVGStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVGStaff.Location = new System.Drawing.Point(0, 0);
            this.DVGStaff.Name = "DVGStaff";
            this.DVGStaff.RowHeadersWidth = 51;
            this.DVGStaff.RowTemplate.Height = 24;
            this.DVGStaff.Size = new System.Drawing.Size(841, 549);
            this.DVGStaff.TabIndex = 1;
            this.DVGStaff.DoubleClick += new System.EventHandler(this.DVGStaff_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1321, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 34);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(948, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 34);
            this.textBox1.TabIndex = 61;
            // 
            // panelXuLi
            // 
            this.panelXuLi.Controls.Add(this.radioBtnCaretaker);
            this.panelXuLi.Controls.Add(this.radioBtnOfficer);
            this.panelXuLi.Controls.Add(this.radioBtnManager);
            this.panelXuLi.Location = new System.Drawing.Point(596, 109);
            this.panelXuLi.Name = "panelXuLi";
            this.panelXuLi.Size = new System.Drawing.Size(346, 51);
            this.panelXuLi.TabIndex = 62;
            // 
            // radioBtnCaretaker
            // 
            this.radioBtnCaretaker.AutoSize = true;
            this.radioBtnCaretaker.Checked = true;
            this.radioBtnCaretaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCaretaker.Location = new System.Drawing.Point(5, 14);
            this.radioBtnCaretaker.Name = "radioBtnCaretaker";
            this.radioBtnCaretaker.Size = new System.Drawing.Size(96, 20);
            this.radioBtnCaretaker.TabIndex = 2;
            this.radioBtnCaretaker.TabStop = true;
            this.radioBtnCaretaker.Text = "Caretaker";
            this.radioBtnCaretaker.UseVisualStyleBackColor = true;
            // 
            // radioBtnOfficer
            // 
            this.radioBtnOfficer.AutoSize = true;
            this.radioBtnOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOfficer.Location = new System.Drawing.Point(134, 14);
            this.radioBtnOfficer.Name = "radioBtnOfficer";
            this.radioBtnOfficer.Size = new System.Drawing.Size(73, 20);
            this.radioBtnOfficer.TabIndex = 1;
            this.radioBtnOfficer.Text = "Officer";
            this.radioBtnOfficer.UseVisualStyleBackColor = true;
            // 
            // radioBtnManager
            // 
            this.radioBtnManager.AutoSize = true;
            this.radioBtnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnManager.Location = new System.Drawing.Point(231, 14);
            this.radioBtnManager.Name = "radioBtnManager";
            this.radioBtnManager.Size = new System.Drawing.Size(89, 20);
            this.radioBtnManager.TabIndex = 0;
            this.radioBtnManager.Text = "Manager";
            this.radioBtnManager.UseVisualStyleBackColor = true;
            // 
            // UpdateStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1801, 717);
            this.MinimumSize = new System.Drawing.Size(1008, 759);
            this.Name = "UpdateStaffManager";
            this.Text = "Update Staff";
            this.Load += new System.EventHandler(this.UpdateStaffManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVGStaff)).EndInit();
            this.panelXuLi.ResumeLayout(false);
            this.panelXuLi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelXuLi;
        private System.Windows.Forms.RadioButton radioBtnCaretaker;
        private System.Windows.Forms.RadioButton radioBtnOfficer;
        private System.Windows.Forms.RadioButton radioBtnManager;
        private System.Windows.Forms.DataGridView DVGStaff;
    }
}