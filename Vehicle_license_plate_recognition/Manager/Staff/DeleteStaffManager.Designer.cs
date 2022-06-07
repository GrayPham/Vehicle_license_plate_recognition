namespace Vehicle_license_plate_recognition.Manager.Staff
{
    partial class DeleteStaffManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DVGEmployMoreYear = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioBtnCaretaker = new System.Windows.Forms.RadioButton();
            this.radioBtnOfficer = new System.Windows.Forms.RadioButton();
            this.radioBtnManager = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGEmployMoreYear)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DVGEmployMoreYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 477);
            this.panel1.TabIndex = 0;
            // 
            // DVGEmployMoreYear
            // 
            this.DVGEmployMoreYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGEmployMoreYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVGEmployMoreYear.Location = new System.Drawing.Point(0, 0);
            this.DVGEmployMoreYear.Name = "DVGEmployMoreYear";
            this.DVGEmployMoreYear.RowHeadersWidth = 51;
            this.DVGEmployMoreYear.RowTemplate.Height = 24;
            this.DVGEmployMoreYear.Size = new System.Drawing.Size(972, 477);
            this.DVGEmployMoreYear.TabIndex = 0;
            this.DVGEmployMoreYear.DoubleClick += new System.EventHandler(this.DVGEmployMoreYear_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(131, 613);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(687, 613);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(47, 545);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(41, 32);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // txtStaff
            // 
            this.txtStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.Location = new System.Drawing.Point(131, 542);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(309, 38);
            this.txtStaff.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioBtnCaretaker);
            this.panel3.Controls.Add(this.radioBtnOfficer);
            this.panel3.Controls.Add(this.radioBtnManager);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 56);
            this.panel3.TabIndex = 54;
            // 
            // radioBtnCaretaker
            // 
            this.radioBtnCaretaker.AutoSize = true;
            this.radioBtnCaretaker.Checked = true;
            this.radioBtnCaretaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCaretaker.Location = new System.Drawing.Point(19, 16);
            this.radioBtnCaretaker.Name = "radioBtnCaretaker";
            this.radioBtnCaretaker.Size = new System.Drawing.Size(96, 20);
            this.radioBtnCaretaker.TabIndex = 5;
            this.radioBtnCaretaker.TabStop = true;
            this.radioBtnCaretaker.Text = "Caretaker";
            this.radioBtnCaretaker.UseVisualStyleBackColor = true;
            this.radioBtnCaretaker.CheckedChanged += new System.EventHandler(this.radioBtnCaretaker_CheckedChanged);
            // 
            // radioBtnOfficer
            // 
            this.radioBtnOfficer.AutoSize = true;
            this.radioBtnOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOfficer.Location = new System.Drawing.Point(148, 16);
            this.radioBtnOfficer.Name = "radioBtnOfficer";
            this.radioBtnOfficer.Size = new System.Drawing.Size(73, 20);
            this.radioBtnOfficer.TabIndex = 4;
            this.radioBtnOfficer.Text = "Officer";
            this.radioBtnOfficer.UseVisualStyleBackColor = true;
            this.radioBtnOfficer.CheckedChanged += new System.EventHandler(this.radioBtnOfficer_CheckedChanged);
            // 
            // radioBtnManager
            // 
            this.radioBtnManager.AutoSize = true;
            this.radioBtnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnManager.Location = new System.Drawing.Point(245, 16);
            this.radioBtnManager.Name = "radioBtnManager";
            this.radioBtnManager.Size = new System.Drawing.Size(89, 20);
            this.radioBtnManager.TabIndex = 3;
            this.radioBtnManager.Text = "Manager";
            this.radioBtnManager.UseVisualStyleBackColor = true;
            this.radioBtnManager.CheckedChanged += new System.EventHandler(this.radioBtnManager_CheckedChanged);
            // 
            // DeleteStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteStaffManager";
            this.Text = "DeleteStaffManager";
            this.Load += new System.EventHandler(this.DeleteStaffManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVGEmployMoreYear)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DVGEmployMoreYear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioBtnCaretaker;
        private System.Windows.Forms.RadioButton radioBtnOfficer;
        private System.Windows.Forms.RadioButton radioBtnManager;
    }
}