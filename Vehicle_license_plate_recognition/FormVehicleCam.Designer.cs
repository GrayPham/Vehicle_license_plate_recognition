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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehicleCam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlacePark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVThanhToan = new System.Windows.Forms.DataGridView();
            this.txtIdStaff = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Park = new System.Windows.Forms.ComboBox();
            this.lbLoaiHinh = new System.Windows.Forms.Label();
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
            this.dateTimePickerSystem = new System.Windows.Forms.DateTimePicker();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_parking = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timerSysterm = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThanhToan)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPlacePark);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DGVThanhToan);
            this.groupBox1.Controls.Add(this.txtIdStaff);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Park);
            this.groupBox1.Controls.Add(this.lbLoaiHinh);
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
            this.groupBox1.Controls.Add(this.dateTimePickerSystem);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 716);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Position";
            // 
            // txtPlacePark
            // 
            this.txtPlacePark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacePark.ForeColor = System.Drawing.Color.Red;
            this.txtPlacePark.Location = new System.Drawing.Point(803, 713);
            this.txtPlacePark.Name = "txtPlacePark";
            this.txtPlacePark.ReadOnly = true;
            this.txtPlacePark.Size = new System.Drawing.Size(273, 38);
            this.txtPlacePark.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Price";
            // 
            // DGVThanhToan
            // 
            this.DGVThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVThanhToan.Location = new System.Drawing.Point(1100, 452);
            this.DGVThanhToan.Name = "DGVThanhToan";
            this.DGVThanhToan.RowHeadersWidth = 51;
            this.DGVThanhToan.RowTemplate.Height = 24;
            this.DGVThanhToan.Size = new System.Drawing.Size(420, 196);
            this.DGVThanhToan.TabIndex = 43;
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStaff.Location = new System.Drawing.Point(803, 583);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.ReadOnly = true;
            this.txtIdStaff.Size = new System.Drawing.Size(273, 38);
            this.txtIdStaff.TabIndex = 42;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Red;
            this.txtPrice.Location = new System.Drawing.Point(803, 648);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(273, 38);
            this.txtPrice.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID Staff";
            // 
            // comboBox_Park
            // 
            this.comboBox_Park.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Park.FormattingEnabled = true;
            this.comboBox_Park.Location = new System.Drawing.Point(1100, 406);
            this.comboBox_Park.Name = "comboBox_Park";
            this.comboBox_Park.Size = new System.Drawing.Size(421, 39);
            this.comboBox_Park.TabIndex = 38;
            // 
            // lbLoaiHinh
            // 
            this.lbLoaiHinh.AutoSize = true;
            this.lbLoaiHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiHinh.ForeColor = System.Drawing.Color.Red;
            this.lbLoaiHinh.Location = new System.Drawing.Point(1097, 670);
            this.lbLoaiHinh.Name = "lbLoaiHinh";
            this.lbLoaiHinh.Size = new System.Drawing.Size(81, 29);
            this.lbLoaiHinh.TabIndex = 37;
            this.lbLoaiHinh.Text = "Check";
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.Color.Transparent;
            this.button_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_done.Location = new System.Drawing.Point(1344, 790);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(176, 36);
            this.button_done.TabIndex = 36;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // pictureBox_recognize
            // 
            this.pictureBox_recognize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_recognize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_recognize.Image")));
            this.pictureBox_recognize.Location = new System.Drawing.Point(1099, 83);
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
            this.btn_charge.Location = new System.Drawing.Point(1344, 731);
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
            this.btn_offcam.Location = new System.Drawing.Point(449, 769);
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
            this.btn_cap.Location = new System.Drawing.Point(449, 710);
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
            this.btn_cam.Location = new System.Drawing.Point(449, 651);
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
            this.panel2.Location = new System.Drawing.Point(1099, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 57);
            this.panel2.TabIndex = 34;
            // 
            // radioButton_car
            // 
            this.radioButton_car.AutoSize = true;
            this.radioButton_car.Checked = true;
            this.radioButton_car.Location = new System.Drawing.Point(317, 13);
            this.radioButton_car.Name = "radioButton_car";
            this.radioButton_car.Size = new System.Drawing.Size(60, 24);
            this.radioButton_car.TabIndex = 19;
            this.radioButton_car.TabStop = true;
            this.radioButton_car.Text = "Car";
            this.radioButton_car.UseVisualStyleBackColor = true;
            this.radioButton_car.CheckedChanged += new System.EventHandler(this.radioButton_car_CheckedChanged);
            // 
            // radioButton_bicycle
            // 
            this.radioButton_bicycle.AutoSize = true;
            this.radioButton_bicycle.Location = new System.Drawing.Point(13, 13);
            this.radioButton_bicycle.Name = "radioButton_bicycle";
            this.radioButton_bicycle.Size = new System.Drawing.Size(92, 24);
            this.radioButton_bicycle.TabIndex = 18;
            this.radioButton_bicycle.Text = "Bicycle";
            this.radioButton_bicycle.UseVisualStyleBackColor = true;
            this.radioButton_bicycle.CheckedChanged += new System.EventHandler(this.radioButton_bicycle_CheckedChanged);
            // 
            // radioButton_motorbike
            // 
            this.radioButton_motorbike.AutoSize = true;
            this.radioButton_motorbike.Location = new System.Drawing.Point(163, 13);
            this.radioButton_motorbike.Name = "radioButton_motorbike";
            this.radioButton_motorbike.Size = new System.Drawing.Size(112, 24);
            this.radioButton_motorbike.TabIndex = 17;
            this.radioButton_motorbike.Text = "Motorbike";
            this.radioButton_motorbike.UseVisualStyleBackColor = true;
            this.radioButton_motorbike.CheckedChanged += new System.EventHandler(this.radioButton_motorbike_CheckedChanged);
            // 
            // label_vehicleclassification
            // 
            this.label_vehicleclassification.AutoSize = true;
            this.label_vehicleclassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_vehicleclassification.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_vehicleclassification.Location = new System.Drawing.Point(1095, 276);
            this.label_vehicleclassification.Name = "label_vehicleclassification";
            this.label_vehicleclassification.Size = new System.Drawing.Size(192, 20);
            this.label_vehicleclassification.TabIndex = 33;
            this.label_vehicleclassification.Text = "Vehicle Classification";
            // 
            // richTextBox_licenseplates
            // 
            this.richTextBox_licenseplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_licenseplates.Location = new System.Drawing.Point(1100, 26);
            this.richTextBox_licenseplates.Name = "richTextBox_licenseplates";
            this.richTextBox_licenseplates.Size = new System.Drawing.Size(421, 51);
            this.richTextBox_licenseplates.TabIndex = 26;
            this.richTextBox_licenseplates.Text = "";
            // 
            // label_licenseplates
            // 
            this.label_licenseplates.AutoSize = true;
            this.label_licenseplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_licenseplates.Location = new System.Drawing.Point(1096, 3);
            this.label_licenseplates.Name = "label_licenseplates";
            this.label_licenseplates.Size = new System.Drawing.Size(134, 20);
            this.label_licenseplates.TabIndex = 32;
            this.label_licenseplates.Text = "License Plates";
            // 
            // dateTimePickerSystem
            // 
            this.dateTimePickerSystem.CustomFormat = " MMMM dd, yyyy | hh: mm: ss : tt";
            this.dateTimePickerSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerSystem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSystem.Location = new System.Drawing.Point(1093, 235);
            this.dateTimePickerSystem.Name = "dateTimePickerSystem";
            this.dateTimePickerSystem.Size = new System.Drawing.Size(427, 27);
            this.dateTimePickerSystem.TabIndex = 27;
            this.dateTimePickerSystem.Value = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Check.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Check.Location = new System.Drawing.Point(1144, 732);
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
            this.btn_parking.Location = new System.Drawing.Point(1144, 788);
            this.btn_parking.Name = "btn_parking";
            this.btn_parking.Size = new System.Drawing.Size(176, 38);
            this.btn_parking.TabIndex = 28;
            this.btn_parking.Text = "Parking";
            this.btn_parking.UseVisualStyleBackColor = false;
            this.btn_parking.Click += new System.EventHandler(this.btn_parking_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timerSysterm
            // 
            this.timerSysterm.Tick += new System.EventHandler(this.timerSysterm_Tick);
            // 
            // FormVehicleCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 970);
            this.Controls.Add(this.panel1);
            this.Name = "FormVehicleCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVehicleCam";
            this.Load += new System.EventHandler(this.FormVehicleCam_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThanhToan)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerSystem;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_parking;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_recognize;
        private System.Windows.Forms.Button button_done;
        public System.Windows.Forms.PictureBox pictureBox_camera;
        private System.Windows.Forms.Label lbLoaiHinh;
        private System.Windows.Forms.ComboBox comboBox_Park;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.TextBox txtIdStaff;
        private System.Windows.Forms.Timer timerSysterm;
        private System.Windows.Forms.DataGridView DGVThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlacePark;
        private System.Windows.Forms.Label label3;
    }
}