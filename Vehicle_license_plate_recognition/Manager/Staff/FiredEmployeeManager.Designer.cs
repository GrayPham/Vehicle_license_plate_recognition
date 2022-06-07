namespace Vehicle_license_plate_recognition.Manager.Staff
{
    partial class FiredEmployeeManager
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
            this.btnFire = new System.Windows.Forms.Button();
            this.DVGStaff = new System.Windows.Forms.DataGridView();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioBtnCaretaker = new System.Windows.Forms.RadioButton();
            this.radioBtnOfficer = new System.Windows.Forms.RadioButton();
            this.radioBtnManager = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DVGStaff)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(571, 361);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(112, 44);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // DVGStaff
            // 
            this.DVGStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGStaff.Location = new System.Drawing.Point(42, 67);
            this.DVGStaff.Name = "DVGStaff";
            this.DVGStaff.RowHeadersWidth = 51;
            this.DVGStaff.RowTemplate.Height = 24;
            this.DVGStaff.Size = new System.Drawing.Size(641, 268);
            this.DVGStaff.TabIndex = 1;
            this.DVGStaff.DoubleClick += new System.EventHandler(this.DVGStaff_DoubleClick);
            // 
            // txtStaff
            // 
            this.txtStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.Location = new System.Drawing.Point(262, 361);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(278, 38);
            this.txtStaff.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Staff";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtStaff);
            this.panel2.Controls.Add(this.DVGStaff);
            this.panel2.Controls.Add(this.btnFire);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 405);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fire employees";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioBtnCaretaker);
            this.panel3.Controls.Add(this.radioBtnOfficer);
            this.panel3.Controls.Add(this.radioBtnManager);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(361, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 52);
            this.panel3.TabIndex = 1;
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
            // FiredEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(714, 405);
            this.Name = "FiredEmployeeManager";
            this.Text = "FiredEmployeeManager";
            this.Load += new System.EventHandler(this.FiredEmployeeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVGStaff)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.DataGridView DVGStaff;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioBtnCaretaker;
        private System.Windows.Forms.RadioButton radioBtnOfficer;
        private System.Windows.Forms.RadioButton radioBtnManager;
    }
}