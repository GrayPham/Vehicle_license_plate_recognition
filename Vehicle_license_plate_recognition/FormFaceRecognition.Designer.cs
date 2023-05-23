namespace Vehicle_license_plate_recognition
{
    partial class FormFaceRecognition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaceRecognition));
            this.saveFileDialog_face = new System.Windows.Forms.SaveFileDialog();
            this.btn_offcam = new System.Windows.Forms.Button();
            this.btn_cap = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_staffphoto = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox_recognize = new System.Windows.Forms.PictureBox();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.btn_cam = new System.Windows.Forms.Button();
            this.button_attendance = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.richTextBox_licenseplates = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnConfim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recognize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_offcam
            // 
            this.btn_offcam.BackColor = System.Drawing.Color.Transparent;
            this.btn_offcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_offcam.Location = new System.Drawing.Point(464, 691);
            this.btn_offcam.Name = "btn_offcam";
            this.btn_offcam.Size = new System.Drawing.Size(221, 53);
            this.btn_offcam.TabIndex = 29;
            this.btn_offcam.Text = "Turn off Camera";
            this.btn_offcam.UseVisualStyleBackColor = false;
            // 
            // btn_cap
            // 
            this.btn_cap.BackColor = System.Drawing.Color.Transparent;
            this.btn_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cap.Location = new System.Drawing.Point(464, 632);
            this.btn_cap.Name = "btn_cap";
            this.btn_cap.Size = new System.Drawing.Size(221, 53);
            this.btn_cap.TabIndex = 28;
            this.btn_cap.Text = "Capture";
            this.btn_cap.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 498);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(440, 30);
            this.comboBox1.TabIndex = 26;
            // 
            // label_staffphoto
            // 
            this.label_staffphoto.AutoSize = true;
            this.label_staffphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_staffphoto.Location = new System.Drawing.Point(1118, 28);
            this.label_staffphoto.Name = "label_staffphoto";
            this.label_staffphoto.Size = new System.Drawing.Size(103, 20);
            this.label_staffphoto.TabIndex = 38;
            this.label_staffphoto.Text = "Staff Photo";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " MMMM dd, yyyy | hh: mm: ss : tt";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1122, 324);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(421, 27);
            this.dateTimePicker2.TabIndex = 37;
            this.dateTimePicker2.Value = new System.DateTime(2022, 4, 3, 0, 0, 0, 0);
            // 
            // pictureBox_recognize
            // 
            this.pictureBox_recognize.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_recognize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_recognize.Image")));
            this.pictureBox_recognize.Location = new System.Drawing.Point(1122, 51);
            this.pictureBox_recognize.Name = "pictureBox_recognize";
            this.pictureBox_recognize.Size = new System.Drawing.Size(421, 216);
            this.pictureBox_recognize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_recognize.TabIndex = 39;
            this.pictureBox_recognize.TabStop = false;
            // 
            // pictureBox_camera
            // 
            this.pictureBox_camera.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox_camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_camera.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_camera.Name = "pictureBox_camera";
            this.pictureBox_camera.Size = new System.Drawing.Size(1076, 470);
            this.pictureBox_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_camera.TabIndex = 23;
            this.pictureBox_camera.TabStop = false;
            this.pictureBox_camera.Click += new System.EventHandler(this.pictureBox_camera_Click);
            // 
            // btn_cam
            // 
            this.btn_cam.BackColor = System.Drawing.Color.Transparent;
            this.btn_cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cam.Location = new System.Drawing.Point(464, 573);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(221, 53);
            this.btn_cam.TabIndex = 27;
            this.btn_cam.Text = "Turn on Camera";
            this.btn_cam.UseVisualStyleBackColor = false;
            // 
            // button_attendance
            // 
            this.button_attendance.BackColor = System.Drawing.Color.Transparent;
            this.button_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_attendance.Location = new System.Drawing.Point(1257, 519);
            this.button_attendance.Name = "button_attendance";
            this.button_attendance.Size = new System.Drawing.Size(168, 53);
            this.button_attendance.TabIndex = 40;
            this.button_attendance.Text = "Attendance";
            this.button_attendance.UseVisualStyleBackColor = false;
            this.button_attendance.Click += new System.EventHandler(this.button_attendance_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Transparent;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_cancel.Location = new System.Drawing.Point(1257, 670);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(168, 53);
            this.button_cancel.TabIndex = 41;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // richTextBox_licenseplates
            // 
            this.richTextBox_licenseplates.Location = new System.Drawing.Point(1122, 388);
            this.richTextBox_licenseplates.Name = "richTextBox_licenseplates";
            this.richTextBox_licenseplates.Size = new System.Drawing.Size(421, 96);
            this.richTextBox_licenseplates.TabIndex = 42;
            this.richTextBox_licenseplates.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " MMMM dd, yyyy | hh: mm: ss : tt";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(667, 501);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(421, 27);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 3, 0, 0, 0, 0);
            // 
            // btnConfim
            // 
            this.btnConfim.BackColor = System.Drawing.Color.Transparent;
            this.btnConfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConfim.Location = new System.Drawing.Point(1257, 593);
            this.btnConfim.Name = "btnConfim";
            this.btnConfim.Size = new System.Drawing.Size(168, 53);
            this.btnConfim.TabIndex = 44;
            this.btnConfim.Text = "Confirm";
            this.btnConfim.UseVisualStyleBackColor = false;
            this.btnConfim.Click += new System.EventHandler(this.btnConfim_Click);
            // 
            // FormFaceRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1657, 783);
            this.Controls.Add(this.btnConfim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBox_licenseplates);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_attendance);
            this.Controls.Add(this.pictureBox_recognize);
            this.Controls.Add(this.label_staffphoto);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btn_offcam);
            this.Controls.Add(this.btn_cap);
            this.Controls.Add(this.btn_cam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox_camera);
            this.Name = "FormFaceRecognition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFaceRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recognize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_camera;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_face;
        private System.Windows.Forms.Button btn_offcam;
        private System.Windows.Forms.Button btn_cap;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox_recognize;
        private System.Windows.Forms.Label label_staffphoto;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_cam;
        private System.Windows.Forms.Button button_attendance;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.RichTextBox richTextBox_licenseplates;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnConfim;
    }
}