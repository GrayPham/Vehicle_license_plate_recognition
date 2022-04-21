namespace Vehicle_license_plate_recognition
{
    partial class FormVehicleCam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehicleCam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_done = new System.Windows.Forms.Button();
            this.pictureBox_recognize = new System.Windows.Forms.PictureBox();
            this.btn_charge = new System.Windows.Forms.Button();
            this.btn_offcam = new System.Windows.Forms.Button();
            this.btn_cap = new System.Windows.Forms.Button();
            this.btn_cam = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_car = new System.Windows.Forms.RadioButton();
            this.radioButton_bicycle = new System.Windows.Forms.RadioButton();
            this.radioButton_motorbike = new System.Windows.Forms.RadioButton();
            this.label_vehicleclassification = new System.Windows.Forms.Label();
            this.richTextBox_licenseplates = new System.Windows.Forms.RichTextBox();
            this.label_licenseplates = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_parking = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recognize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1578, 845);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_done);
            this.groupBox1.Controls.Add(this.pictureBox_recognize);
            this.groupBox1.Controls.Add(this.btn_charge);
            this.groupBox1.Controls.Add(this.btn_offcam);
            this.groupBox1.Controls.Add(this.btn_cap);
            this.groupBox1.Controls.Add(this.btn_cam);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label_vehicleclassification);
            this.groupBox1.Controls.Add(this.richTextBox_licenseplates);
            this.groupBox1.Controls.Add(this.label_licenseplates);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.btn_Check);
            this.groupBox1.Controls.Add(this.btn_parking);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pictureBox_camera);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1578, 845);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.Color.Transparent;
            this.button_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_done.Location = new System.Drawing.Point(1189, 656);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(176, 36);
            this.button_done.TabIndex = 36;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // pictureBox_recognize
            // 
            this.pictureBox_recognize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_recognize.Image")));
            this.pictureBox_recognize.Location = new System.Drawing.Point(1099, 128);
            this.pictureBox_recognize.Name = "pictureBox_recognize";
            this.pictureBox_recognize.Size = new System.Drawing.Size(421, 146);
            this.pictureBox_recognize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_recognize.TabIndex = 35;
            this.pictureBox_recognize.TabStop = false;
            // 
            // btn_charge
            // 
            this.btn_charge.BackColor = System.Drawing.Color.Transparent;
            this.btn_charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_charge.Location = new System.Drawing.Point(1189, 614);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(176, 36);
            this.btn_charge.TabIndex = 31;
            this.btn_charge.Text = "Charge";
            this.btn_charge.UseVisualStyleBackColor = false;
            this.btn_charge.Click += new System.EventHandler(this.btn_charge_Click);
            // 
            // btn_offcam
            // 
            this.btn_offcam.BackColor = System.Drawing.Color.Transparent;
            this.btn_offcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_offcam.Location = new System.Drawing.Point(575, 769);
            this.btn_offcam.Name = "btn_offcam";
            this.btn_offcam.Size = new System.Drawing.Size(221, 53);
            this.btn_offcam.TabIndex = 25;
            this.btn_offcam.Text = "Turn off Camera";
            this.btn_offcam.UseVisualStyleBackColor = false;
            this.btn_offcam.Click += new System.EventHandler(this.btn_offcam_Click);
            // 
            // btn_cap
            // 
            this.btn_cap.BackColor = System.Drawing.Color.Transparent;
            this.btn_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cap.Location = new System.Drawing.Point(575, 710);
            this.btn_cap.Name = "btn_cap";
            this.btn_cap.Size = new System.Drawing.Size(221, 53);
            this.btn_cap.TabIndex = 24;
            this.btn_cap.Text = "Capture";
            this.btn_cap.UseVisualStyleBackColor = false;
            this.btn_cap.Click += new System.EventHandler(this.btn_cap_Click);
            // 
            // btn_cam
            // 
            this.btn_cam.BackColor = System.Drawing.Color.Transparent;
            this.btn_cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cam.Location = new System.Drawing.Point(575, 651);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(221, 53);
            this.btn_cam.TabIndex = 23;
            this.btn_cam.Text = "Turn on Camera";
            this.btn_cam.UseVisualStyleBackColor = false;
            this.btn_cam.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton_car);
            this.panel2.Controls.Add(this.radioButton_bicycle);
            this.panel2.Controls.Add(this.radioButton_motorbike);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(1099, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 57);
            this.panel2.TabIndex = 34;
            // 
            // radioButton_car
            // 
            this.radioButton_car.AutoSize = true;
            this.radioButton_car.Location = new System.Drawing.Point(248, 13);
            this.radioButton_car.Name = "radioButton_car";
            this.radioButton_car.Size = new System.Drawing.Size(60, 24);
            this.radioButton_car.TabIndex = 19;
            this.radioButton_car.TabStop = true;
            this.radioButton_car.Text = "Car";
            this.radioButton_car.UseVisualStyleBackColor = true;
            // 
            // radioButton_bicycle
            // 
            this.radioButton_bicycle.AutoSize = true;
            this.radioButton_bicycle.Location = new System.Drawing.Point(141, 13);
            this.radioButton_bicycle.Name = "radioButton_bicycle";
            this.radioButton_bicycle.Size = new System.Drawing.Size(92, 24);
            this.radioButton_bicycle.TabIndex = 18;
            this.radioButton_bicycle.TabStop = true;
            this.radioButton_bicycle.Text = "Bicycle";
            this.radioButton_bicycle.UseVisualStyleBackColor = true;
            // 
            // radioButton_motorbike
            // 
            this.radioButton_motorbike.AutoSize = true;
            this.radioButton_motorbike.Location = new System.Drawing.Point(15, 13);
            this.radioButton_motorbike.Name = "radioButton_motorbike";
            this.radioButton_motorbike.Size = new System.Drawing.Size(112, 24);
            this.radioButton_motorbike.TabIndex = 17;
            this.radioButton_motorbike.TabStop = true;
            this.radioButton_motorbike.Text = "Motorbike";
            this.radioButton_motorbike.UseVisualStyleBackColor = true;
            // 
            // label_vehicleclassification
            // 
            this.label_vehicleclassification.AutoSize = true;
            this.label_vehicleclassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_vehicleclassification.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_vehicleclassification.Location = new System.Drawing.Point(1095, 377);
            this.label_vehicleclassification.Name = "label_vehicleclassification";
            this.label_vehicleclassification.Size = new System.Drawing.Size(192, 20);
            this.label_vehicleclassification.TabIndex = 33;
            this.label_vehicleclassification.Text = "Vehicle Classification";
            // 
            // richTextBox_licenseplates
            // 
            this.richTextBox_licenseplates.Enabled = false;
            this.richTextBox_licenseplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_licenseplates.Location = new System.Drawing.Point(1099, 58);
            this.richTextBox_licenseplates.Name = "richTextBox_licenseplates";
            this.richTextBox_licenseplates.Size = new System.Drawing.Size(421, 51);
            this.richTextBox_licenseplates.TabIndex = 26;
            this.richTextBox_licenseplates.Text = "";
            // 
            // label_licenseplates
            // 
            this.label_licenseplates.AutoSize = true;
            this.label_licenseplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_licenseplates.Location = new System.Drawing.Point(1095, 35);
            this.label_licenseplates.Name = "label_licenseplates";
            this.label_licenseplates.Size = new System.Drawing.Size(134, 20);
            this.label_licenseplates.TabIndex = 32;
            this.label_licenseplates.Text = "License Plates";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " MMMM dd, yyyy | hh: mm: ss : tt";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1093, 293);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(427, 27);
            this.dateTimePicker2.TabIndex = 27;
            this.dateTimePicker2.Value = new System.DateTime(2022, 4, 3, 0, 0, 0, 0);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Check.Location = new System.Drawing.Point(1189, 529);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(176, 35);
            this.btn_Check.TabIndex = 29;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_parking
            // 
            this.btn_parking.BackColor = System.Drawing.Color.Transparent;
            this.btn_parking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_parking.Location = new System.Drawing.Point(1189, 570);
            this.btn_parking.Name = "btn_parking";
            this.btn_parking.Size = new System.Drawing.Size(176, 38);
            this.btn_parking.TabIndex = 28;
            this.btn_parking.Text = "Parking";
            this.btn_parking.UseVisualStyleBackColor = false;
            this.btn_parking.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 592);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(440, 30);
            this.comboBox1.TabIndex = 21;
            // 
            // pictureBox_camera
            // 
            this.pictureBox_camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_camera.Location = new System.Drawing.Point(0, 3);
            this.pictureBox_camera.Name = "pictureBox_camera";
            this.pictureBox_camera.Size = new System.Drawing.Size(1076, 573);
            this.pictureBox_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_camera.TabIndex = 22;
            this.pictureBox_camera.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Jpeg image|*.jpeg|Png image|*.png|Gif image|*.gif";
            // 
            // FormVehicleCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 869);
            this.Controls.Add(this.panel1);
            this.Name = "FormVehicleCam";
            this.Text = "FormVehicleCam";
            this.Load += new System.EventHandler(this.FormVehicleCam_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recognize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_charge;
        private System.Windows.Forms.Button btn_offcam;
        private System.Windows.Forms.Button btn_cap;
        private System.Windows.Forms.Button btn_cam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_car;
        private System.Windows.Forms.RadioButton radioButton_bicycle;
        private System.Windows.Forms.RadioButton radioButton_motorbike;
        private System.Windows.Forms.Label label_vehicleclassification;
        private System.Windows.Forms.RichTextBox richTextBox_licenseplates;
        private System.Windows.Forms.Label label_licenseplates;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_parking;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_recognize;
        private System.Windows.Forms.Button button_done;
        public System.Windows.Forms.PictureBox pictureBox_camera;
    }
}