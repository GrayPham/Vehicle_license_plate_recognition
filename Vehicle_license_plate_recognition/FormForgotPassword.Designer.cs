namespace Vehicle_license_plate_recognition
{
    partial class FormForgotPassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_syntax = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.button_verifycode = new System.Windows.Forms.Button();
            this.textBox_zipcode = new System.Windows.Forms.TextBox();
            this.label_zipcode = new System.Windows.Forms.Label();
            this.button_getcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.pictureBox_close);
            this.groupBox1.Controls.Add(this.pictureBox_logo);
            this.groupBox1.Controls.Add(this.label_syntax);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.button_verifycode);
            this.groupBox1.Controls.Add(this.textBox_zipcode);
            this.groupBox1.Controls.Add(this.label_zipcode);
            this.groupBox1.Controls.Add(this.button_getcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label_syntax
            // 
            this.label_syntax.AutoSize = true;
            this.label_syntax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_syntax.ForeColor = System.Drawing.Color.Red;
            this.label_syntax.Location = new System.Drawing.Point(239, 193);
            this.label_syntax.Name = "label_syntax";
            this.label_syntax.Size = new System.Drawing.Size(56, 22);
            this.label_syntax.TabIndex = 28;
            this.label_syntax.Text = "Event";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_status.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_status.Location = new System.Drawing.Point(142, 40);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(484, 29);
            this.label_status.TabIndex = 27;
            this.label_status.Text = "You can reset your password using this form";
            // 
            // button_verifycode
            // 
            this.button_verifycode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_verifycode.Location = new System.Drawing.Point(242, 338);
            this.button_verifycode.Name = "button_verifycode";
            this.button_verifycode.Size = new System.Drawing.Size(348, 36);
            this.button_verifycode.TabIndex = 26;
            this.button_verifycode.Text = "VERIFY CODE";
            this.button_verifycode.UseVisualStyleBackColor = true;
            this.button_verifycode.Click += new System.EventHandler(this.button_verifycode_Click);
            // 
            // textBox_zipcode
            // 
            this.textBox_zipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_zipcode.Location = new System.Drawing.Point(242, 298);
            this.textBox_zipcode.Name = "textBox_zipcode";
            this.textBox_zipcode.Size = new System.Drawing.Size(348, 34);
            this.textBox_zipcode.TabIndex = 25;
            // 
            // label_zipcode
            // 
            this.label_zipcode.AutoSize = true;
            this.label_zipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_zipcode.Location = new System.Drawing.Point(118, 301);
            this.label_zipcode.Name = "label_zipcode";
            this.label_zipcode.Size = new System.Drawing.Size(118, 29);
            this.label_zipcode.TabIndex = 24;
            this.label_zipcode.Text = "Zip Code:";
            // 
            // button_getcode
            // 
            this.button_getcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_getcode.Location = new System.Drawing.Point(242, 222);
            this.button_getcode.Name = "button_getcode";
            this.button_getcode.Size = new System.Drawing.Size(348, 36);
            this.button_getcode.TabIndex = 23;
            this.button_getcode.Text = "GET CODE";
            this.button_getcode.UseVisualStyleBackColor = true;
            this.button_getcode.Click += new System.EventHandler(this.button_getcode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "Forgot Password";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_email.Location = new System.Drawing.Point(242, 153);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(348, 34);
            this.textBox_email.TabIndex = 18;
            this.textBox_email.Click += new System.EventHandler(this.textBox_email_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_email.Location = new System.Drawing.Point(118, 156);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(80, 29);
            this.label_email.TabIndex = 16;
            this.label_email.Text = "Email:";
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox_close.BackgroundImage = global::Vehicle_license_plate_recognition.Properties.Resources.free_exit_icon_2860_thumb;
            this.pictureBox_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_close.Location = new System.Drawing.Point(741, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(47, 40);
            this.pictureBox_close.TabIndex = 38;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            this.pictureBox_close.MouseEnter += new System.EventHandler(this.pictureBox_close_MouseEnter);
            this.pictureBox_close.MouseLeave += new System.EventHandler(this.pictureBox_close_MouseLeave);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImage = global::Vehicle_license_plate_recognition.Properties.Resources.logo_CLC_Circle;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_logo.Location = new System.Drawing.Point(338, 72);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(85, 63);
            this.pictureBox_logo.TabIndex = 37;
            this.pictureBox_logo.TabStop = false;
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(848, 499);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForgotPassword";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_verifycode;
        private System.Windows.Forms.TextBox textBox_zipcode;
        private System.Windows.Forms.Label label_zipcode;
        private System.Windows.Forms.Button button_getcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_syntax;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox_close;
    }
}