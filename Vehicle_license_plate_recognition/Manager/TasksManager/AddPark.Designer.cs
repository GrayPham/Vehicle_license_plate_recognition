namespace Vehicle_license_plate_recognition.Manager
{
    partial class AddPark
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNamePark = new System.Windows.Forms.Label();
            this.txtNamePark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberMaxCapacityCar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numberMotorCapacity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numberMaxCapacityBicycle = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbThongTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxCapacityCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMotorCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxCapacityBicycle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Garage to the system";
            // 
            // lbNamePark
            // 
            this.lbNamePark.AutoSize = true;
            this.lbNamePark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePark.Location = new System.Drawing.Point(91, 83);
            this.lbNamePark.Name = "lbNamePark";
            this.lbNamePark.Size = new System.Drawing.Size(109, 25);
            this.lbNamePark.TabIndex = 1;
            this.lbNamePark.Text = "Name Park";
            // 
            // txtNamePark
            // 
            this.txtNamePark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePark.Location = new System.Drawing.Point(340, 83);
            this.txtNamePark.Name = "txtNamePark";
            this.txtNamePark.Size = new System.Drawing.Size(194, 30);
            this.txtNamePark.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Capacity Car";
            // 
            // numberMaxCapacityCar
            // 
            this.numberMaxCapacityCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMaxCapacityCar.Location = new System.Drawing.Point(340, 156);
            this.numberMaxCapacityCar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberMaxCapacityCar.Name = "numberMaxCapacityCar";
            this.numberMaxCapacityCar.Size = new System.Drawing.Size(194, 30);
            this.numberMaxCapacityCar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max Capacity Motorcycle";
            // 
            // numberMotorCapacity
            // 
            this.numberMotorCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMotorCapacity.Location = new System.Drawing.Point(340, 217);
            this.numberMotorCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberMotorCapacity.Name = "numberMotorCapacity";
            this.numberMotorCapacity.Size = new System.Drawing.Size(194, 30);
            this.numberMotorCapacity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max Capacity Bicycle";
            // 
            // numberMaxCapacityBicycle
            // 
            this.numberMaxCapacityBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMaxCapacityBicycle.Location = new System.Drawing.Point(340, 280);
            this.numberMaxCapacityBicycle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberMaxCapacityBicycle.Name = "numberMaxCapacityBicycle";
            this.numberMaxCapacityBicycle.Size = new System.Drawing.Size(194, 30);
            this.numberMaxCapacityBicycle.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(419, 342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 51);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Confirm";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Silver;
            this.btnDelete.Location = new System.Drawing.Point(564, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 51);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Clear";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Location = new System.Drawing.Point(96, 361);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(34, 16);
            this.lbThongTin.TabIndex = 6;
            this.lbThongTin.Text = "Test";
            // 
            // AddPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 405);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numberMaxCapacityBicycle);
            this.Controls.Add(this.numberMotorCapacity);
            this.Controls.Add(this.numberMaxCapacityCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamePark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNamePark);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPark";
            this.Text = "AddPark";
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxCapacityCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMotorCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxCapacityBicycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNamePark;
        private System.Windows.Forms.TextBox txtNamePark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberMaxCapacityCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberMotorCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberMaxCapacityBicycle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbThongTin;
    }
}