namespace Vehicle_license_plate_recognition
{
    partial class FormStaff
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
            this.button_timekeeping = new System.Windows.Forms.Button();
            this.button_working = new System.Windows.Forms.Button();
            this.dataGridView_phancongtho = new System.Windows.Forms.DataGridView();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phancongtho)).BeginInit();
            this.SuspendLayout();
            // 
            // button_timekeeping
            // 
            this.button_timekeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_timekeeping.Location = new System.Drawing.Point(1082, 610);
            this.button_timekeeping.Name = "button_timekeeping";
            this.button_timekeeping.Size = new System.Drawing.Size(237, 44);
            this.button_timekeeping.TabIndex = 8;
            this.button_timekeeping.Text = "Timekeeping";
            this.button_timekeeping.UseVisualStyleBackColor = true;
            this.button_timekeeping.Click += new System.EventHandler(this.button_timekeeping_Click);
            // 
            // button_working
            // 
            this.button_working.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_working.Location = new System.Drawing.Point(439, 610);
            this.button_working.Name = "button_working";
            this.button_working.Size = new System.Drawing.Size(390, 44);
            this.button_working.TabIndex = 7;
            this.button_working.Text = "Working";
            this.button_working.UseVisualStyleBackColor = true;
            this.button_working.Click += new System.EventHandler(this.button_working_Click);
            // 
            // dataGridView_phancongtho
            // 
            this.dataGridView_phancongtho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phancongtho.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_phancongtho.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_phancongtho.Name = "dataGridView_phancongtho";
            this.dataGridView_phancongtho.RowHeadersWidth = 51;
            this.dataGridView_phancongtho.RowTemplate.Height = 24;
            this.dataGridView_phancongtho.Size = new System.Drawing.Size(1319, 556);
            this.dataGridView_phancongtho.TabIndex = 6;
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStaff.Location = new System.Drawing.Point(0, 610);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.ReadOnly = true;
            this.txtIDStaff.Size = new System.Drawing.Size(198, 38);
            this.txtIDStaff.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID Staff";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 692);
            this.Controls.Add(this.txtIDStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_timekeeping);
            this.Controls.Add(this.button_working);
            this.Controls.Add(this.dataGridView_phancongtho);
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormStaff_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phancongtho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_timekeeping;
        private System.Windows.Forms.Button button_working;
        private System.Windows.Forms.DataGridView dataGridView_phancongtho;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtIDStaff;
    }
}