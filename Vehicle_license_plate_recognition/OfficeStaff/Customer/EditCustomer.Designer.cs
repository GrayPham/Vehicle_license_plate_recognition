namespace Vehicle_license_plate_recognition.OfficeStaff.Customer
{
    partial class EditCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_select = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nUDTypeCus = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fullname = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTypeCus)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox_select);
            this.panel1.Controls.Add(this.nUDTypeCus);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dTPBirthDate);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_fullname);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.lbNameStaff);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtIDStaff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 745);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 29);
            this.label9.TabIndex = 151;
            this.label9.Text = "Select Customer";
            // 
            // comboBox_select
            // 
            this.comboBox_select.DataSource = this.customerBindingSource;
            this.comboBox_select.DisplayMember = "Id";
            this.comboBox_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_select.FormattingEnabled = true;
            this.comboBox_select.Location = new System.Drawing.Point(297, 125);
            this.comboBox_select.Name = "comboBox_select";
            this.comboBox_select.Size = new System.Drawing.Size(265, 39);
            this.comboBox_select.TabIndex = 150;
            this.comboBox_select.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Vehicle_license_plate_recognition.Model.Customer);
            // 
            // nUDTypeCus
            // 
            this.nUDTypeCus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nUDTypeCus.Location = new System.Drawing.Point(299, 235);
            this.nUDTypeCus.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUDTypeCus.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDTypeCus.Name = "nUDTypeCus";
            this.nUDTypeCus.Size = new System.Drawing.Size(132, 38);
            this.nUDTypeCus.TabIndex = 148;
            this.nUDTypeCus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(334, 651);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 59);
            this.btnClose.TabIndex = 147;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(139, 651);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(156, 59);
            this.button_edit.TabIndex = 146;
            this.button_edit.Text = "Edit Customer";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.RadioButtonFemale);
            this.panel3.Controls.Add(this.RadioButtonMale);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(297, 477);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 65);
            this.panel3.TabIndex = 145;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Location = new System.Drawing.Point(139, 16);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(108, 35);
            this.RadioButtonFemale.TabIndex = 6;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Checked = true;
            this.RadioButtonMale.Location = new System.Drawing.Point(17, 16);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(86, 35);
            this.RadioButtonMale.TabIndex = 5;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 477);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 31);
            this.label8.TabIndex = 144;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 29);
            this.label7.TabIndex = 143;
            this.label7.Text = "TypeID";
            // 
            // dTPBirthDate
            // 
            this.dTPBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dTPBirthDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dTPBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPBirthDate.Location = new System.Drawing.Point(297, 413);
            this.dTPBirthDate.Name = "dTPBirthDate";
            this.dTPBirthDate.Size = new System.Drawing.Size(265, 38);
            this.dTPBirthDate.TabIndex = 142;
            this.dTPBirthDate.Value = new System.DateTime(2022, 5, 20, 0, 0, 0, 0);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_id.Location = new System.Drawing.Point(299, 177);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(265, 38);
            this.textBox_id.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 140;
            this.label5.Text = "ID Customer";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_phone.Location = new System.Drawing.Point(297, 354);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(265, 38);
            this.textBox_phone.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 138;
            this.label4.Text = "Phone Number";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbEmail.Location = new System.Drawing.Point(297, 563);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(265, 38);
            this.tbEmail.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 136;
            this.label3.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 135;
            this.label2.Text = "BirthDate";
            // 
            // textBox_fullname
            // 
            this.textBox_fullname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_fullname.Location = new System.Drawing.Point(297, 293);
            this.textBox_fullname.Name = "textBox_fullname";
            this.textBox_fullname.Size = new System.Drawing.Size(265, 38);
            this.textBox_fullname.TabIndex = 134;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(87, 293);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(124, 29);
            this.lbId.TabIndex = 133;
            this.lbId.Text = "Full Name";
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.AutoSize = true;
            this.lbNameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameStaff.Location = new System.Drawing.Point(191, 67);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(211, 32);
            this.lbNameStaff.TabIndex = 132;
            this.lbNameStaff.Text = "InputNameStaff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 32);
            this.label6.TabIndex = 131;
            this.label6.Text = "Name Staff";
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStaff.Location = new System.Drawing.Point(154, 16);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.ReadOnly = true;
            this.txtIDStaff.Size = new System.Drawing.Size(198, 38);
            this.txtIDStaff.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 129;
            this.label1.Text = "ID Staff";
            // 
            // customerDTOBindingSource
            // 
            this.customerDTOBindingSource.DataSource = typeof(Vehicle_license_plate_recognition.DAL.OfficeStaff.CustomerDTO);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 745);
            this.Controls.Add(this.panel1);
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTypeCus)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox comboBox_select;
        private System.Windows.Forms.NumericUpDown nUDTypeCus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTPBirthDate;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fullname;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNameStaff;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource customerDTOBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}