namespace Vehicle_license_plate_recognition.Manager.TasksManager
{
    partial class EditPark
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numberMaxCapacityBicycle = new System.Windows.Forms.NumericUpDown();
            this.numberMotorCapacity = new System.Windows.Forms.NumericUpDown();
            this.numberMaxCapacityCar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamePark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNamePark = new System.Windows.Forms.Label();
            this.comboBoxNamePark = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxCapacityBicycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMotorCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxCapacityCar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Silver;
            this.btnDelete.Location = new System.Drawing.Point(60, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 51);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Clear";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(60, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 51);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Confirm";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numberMaxCapacityBicycle
            // 
            this.numberMaxCapacityBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMaxCapacityBicycle.Location = new System.Drawing.Point(508, 275);
            this.numberMaxCapacityBicycle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberMaxCapacityBicycle.Name = "numberMaxCapacityBicycle";
            this.numberMaxCapacityBicycle.Size = new System.Drawing.Size(194, 30);
            this.numberMaxCapacityBicycle.TabIndex = 13;
            // 
            // numberMotorCapacity
            // 
            this.numberMotorCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMotorCapacity.Location = new System.Drawing.Point(508, 212);
            this.numberMotorCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberMotorCapacity.Name = "numberMotorCapacity";
            this.numberMotorCapacity.Size = new System.Drawing.Size(194, 30);
            this.numberMotorCapacity.TabIndex = 14;
            // 
            // numberMaxCapacityCar
            // 
            this.numberMaxCapacityCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMaxCapacityCar.Location = new System.Drawing.Point(508, 151);
            this.numberMaxCapacityCar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberMaxCapacityCar.Name = "numberMaxCapacityCar";
            this.numberMaxCapacityCar.Size = new System.Drawing.Size(194, 30);
            this.numberMaxCapacityCar.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Capacity Bicycle";
            // 
            // txtNamePark
            // 
            this.txtNamePark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePark.Location = new System.Drawing.Point(508, 101);
            this.txtNamePark.Name = "txtNamePark";
            this.txtNamePark.Size = new System.Drawing.Size(194, 30);
            this.txtNamePark.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max Capacity Motorcycle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Max Capacity Car";
            // 
            // lbNamePark
            // 
            this.lbNamePark.AutoSize = true;
            this.lbNamePark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePark.Location = new System.Drawing.Point(259, 101);
            this.lbNamePark.Name = "lbNamePark";
            this.lbNamePark.Size = new System.Drawing.Size(109, 25);
            this.lbNamePark.TabIndex = 11;
            this.lbNamePark.Text = "Name Park";
            // 
            // comboBoxNamePark
            // 
            this.comboBoxNamePark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNamePark.FormattingEnabled = true;
            this.comboBoxNamePark.Location = new System.Drawing.Point(12, 114);
            this.comboBoxNamePark.Name = "comboBoxNamePark";
            this.comboBoxNamePark.Size = new System.Drawing.Size(205, 33);
            this.comboBoxNamePark.TabIndex = 18;
            this.comboBoxNamePark.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamePark_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name Park";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 405);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(223, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 337);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edit Garage to the system";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 72);
            this.panel1.TabIndex = 20;
            // 
            // EditPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxNamePark);
            this.Controls.Add(this.numberMaxCapacityBicycle);
            this.Controls.Add(this.numberMotorCapacity);
            this.Controls.Add(this.numberMaxCapacityCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamePark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNamePark);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPark";
            this.Text = "EditPark";
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxCapacityBicycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMotorCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxCapacityCar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numberMaxCapacityBicycle;
        private System.Windows.Forms.NumericUpDown numberMotorCapacity;
        private System.Windows.Forms.NumericUpDown numberMaxCapacityCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamePark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNamePark;
        private System.Windows.Forms.ComboBox comboBoxNamePark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}