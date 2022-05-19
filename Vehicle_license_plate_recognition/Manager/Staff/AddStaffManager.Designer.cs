namespace Vehicle_license_plate_recognition.Manager.Staff
{
    partial class AddStaffManager
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
            this.panelXuLi = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.radioBtnCaretaker = new System.Windows.Forms.RadioButton();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.radioBtnOfficer = new System.Windows.Forms.RadioButton();
            this.radioBtnManager = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelXuLi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 655);
            this.btnCancel.Size = new System.Drawing.Size(126, 47);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.panelXuLi);
            this.panel2.Controls.Add(this.btnAddStaff);
            this.panel2.Controls.SetChildIndex(this.btnAddStaff, 0);
            this.panel2.Controls.SetChildIndex(this.btnCancel, 0);
            this.panel2.Controls.SetChildIndex(this.panelXuLi, 0);
            this.panel2.Controls.SetChildIndex(this.btnClear, 0);
            // 
            // panelXuLi
            // 
            this.panelXuLi.Controls.Add(this.radioBtnCaretaker);
            this.panelXuLi.Controls.Add(this.radioBtnOfficer);
            this.panelXuLi.Controls.Add(this.radioBtnManager);
            this.panelXuLi.Location = new System.Drawing.Point(634, 114);
            this.panelXuLi.Name = "panelXuLi";
            this.panelXuLi.Size = new System.Drawing.Size(308, 51);
            this.panelXuLi.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Silver;
            this.btnClear.Location = new System.Drawing.Point(683, 653);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 51);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radioBtnCaretaker
            // 
            this.radioBtnCaretaker.AutoSize = true;
            this.radioBtnCaretaker.Checked = true;
            this.radioBtnCaretaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCaretaker.Location = new System.Drawing.Point(22, 14);
            this.radioBtnCaretaker.Name = "radioBtnCaretaker";
            this.radioBtnCaretaker.Size = new System.Drawing.Size(96, 20);
            this.radioBtnCaretaker.TabIndex = 2;
            this.radioBtnCaretaker.TabStop = true;
            this.radioBtnCaretaker.Text = "Caretaker";
            this.radioBtnCaretaker.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(839, 653);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(139, 51);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Confirm";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // radioBtnOfficer
            // 
            this.radioBtnOfficer.AutoSize = true;
            this.radioBtnOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOfficer.Location = new System.Drawing.Point(124, 14);
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
            this.radioBtnManager.Location = new System.Drawing.Point(206, 14);
            this.radioBtnManager.Name = "radioBtnManager";
            this.radioBtnManager.Size = new System.Drawing.Size(89, 20);
            this.radioBtnManager.TabIndex = 0;
            this.radioBtnManager.Text = "Manager";
            this.radioBtnManager.UseVisualStyleBackColor = true;
            // 
            // AddStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 712);
            this.Name = "AddStaffManager";
            this.Text = "AddStaffManager";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelXuLi.ResumeLayout(false);
            this.panelXuLi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelXuLi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radioBtnCaretaker;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.RadioButton radioBtnOfficer;
        private System.Windows.Forms.RadioButton radioBtnManager;
    }
}