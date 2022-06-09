namespace Vehicle_license_plate_recognition.Manager.Assignment
{
    partial class NomalStaffAssig
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
            this.DVGStaff = new System.Windows.Forms.DataGridView();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.DVGAssigment = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSveAssig = new System.Windows.Forms.Button();
            this.EditAssig = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCountStaff = new System.Windows.Forms.TextBox();
            this.txbNumberStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DVGStaff)).BeginInit();
            this.panelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGAssigment)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DVGStaff
            // 
            this.DVGStaff.AllowUserToResizeColumns = false;
            this.DVGStaff.AllowUserToResizeRows = false;
            this.DVGStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVGStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DVGStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVGStaff.Location = new System.Drawing.Point(0, 0);
            this.DVGStaff.Name = "DVGStaff";
            this.DVGStaff.RowHeadersWidth = 51;
            this.DVGStaff.RowTemplate.Height = 24;
            this.DVGStaff.Size = new System.Drawing.Size(398, 513);
            this.DVGStaff.TabIndex = 0;
            this.DVGStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVGStaff_CellContentClick);
            // 
            // panelStaff
            // 
            this.panelStaff.Controls.Add(this.DVGStaff);
            this.panelStaff.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStaff.Location = new System.Drawing.Point(987, 152);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(398, 513);
            this.panelStaff.TabIndex = 1;
            this.panelStaff.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStaff_Paint);
            // 
            // DVGAssigment
            // 
            this.DVGAssigment.AllowUserToResizeColumns = false;
            this.DVGAssigment.AllowUserToResizeRows = false;
            this.DVGAssigment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVGAssigment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DVGAssigment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGAssigment.Dock = System.Windows.Forms.DockStyle.Top;
            this.DVGAssigment.Location = new System.Drawing.Point(0, 0);
            this.DVGAssigment.Name = "DVGAssigment";
            this.DVGAssigment.RowHeadersWidth = 51;
            this.DVGAssigment.RowTemplate.Height = 24;
            this.DVGAssigment.Size = new System.Drawing.Size(987, 431);
            this.DVGAssigment.TabIndex = 0;
            this.DVGAssigment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVGAssigment_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.DVGAssigment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 513);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.EditAssig);
            this.panel2.Controls.Add(this.btnSveAssig);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(272, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 82);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSveAssig
            // 
            this.btnSveAssig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSveAssig.Location = new System.Drawing.Point(79, 24);
            this.btnSveAssig.Name = "btnSveAssig";
            this.btnSveAssig.Size = new System.Drawing.Size(136, 48);
            this.btnSveAssig.TabIndex = 2;
            this.btnSveAssig.Text = "Update";
            this.btnSveAssig.UseVisualStyleBackColor = true;
            this.btnSveAssig.Click += new System.EventHandler(this.btnSveAssig_Click);
            // 
            // EditAssig
            // 
            this.EditAssig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAssig.Location = new System.Drawing.Point(258, 24);
            this.EditAssig.Name = "EditAssig";
            this.EditAssig.Size = new System.Drawing.Size(137, 48);
            this.EditAssig.TabIndex = 3;
            this.EditAssig.Text = "Edit";
            this.EditAssig.UseVisualStyleBackColor = true;
            this.EditAssig.Click += new System.EventHandler(this.EditAssig_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(441, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCountStaff
            // 
            this.tbCountStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountStaff.Location = new System.Drawing.Point(220, 106);
            this.tbCountStaff.Name = "tbCountStaff";
            this.tbCountStaff.Size = new System.Drawing.Size(139, 30);
            this.tbCountStaff.TabIndex = 1;
            this.tbCountStaff.TextChanged += new System.EventHandler(this.tbCountStaff_TextChanged);
            // 
            // txbNumberStaff
            // 
            this.txbNumberStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumberStaff.Location = new System.Drawing.Point(693, 106);
            this.txbNumberStaff.Name = "txbNumberStaff";
            this.txbNumberStaff.Size = new System.Drawing.Size(147, 30);
            this.txbNumberStaff.TabIndex = 2;
            this.txbNumberStaff.TextChanged += new System.EventHandler(this.txbNumberStaff_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number Staff Of Shift";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(1121, 107);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 30);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adjusting work assignments";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbNumberStaff);
            this.panel1.Controls.Add(this.tbCountStaff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 152);
            this.panel1.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(98, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(102, 44);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFind);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 431);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 82);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // NomalStaffAssig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelStaff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NomalStaffAssig";
            this.Text = "NomalStaffAssig";
            this.Load += new System.EventHandler(this.NomalStaffAssig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVGStaff)).EndInit();
            this.panelStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVGAssigment)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DVGStaff;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.DataGridView DVGAssigment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button EditAssig;
        private System.Windows.Forms.Button btnSveAssig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCountStaff;
        private System.Windows.Forms.TextBox txbNumberStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}