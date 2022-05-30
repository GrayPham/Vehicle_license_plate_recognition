namespace Vehicle_license_plate_recognition
{
    partial class FormLogin
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_register = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_forgot = new System.Windows.Forms.Label();
            this.label_tieudeLOGINFORM = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Vehicle_license_plate_recognition.Properties.Resources.lock_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(110, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 34);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Vehicle_license_plate_recognition.Properties.Resources.Male_User_Icon_clip_art_medium;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(110, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 34);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImage = global::Vehicle_license_plate_recognition.Properties.Resources.logo_CLC_Circle;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_logo.Location = new System.Drawing.Point(279, 91);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(85, 63);
            this.pictureBox_logo.TabIndex = 36;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.BackColor = System.Drawing.Color.Transparent;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_pass.Location = new System.Drawing.Point(159, 270);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(126, 29);
            this.label_pass.TabIndex = 28;
            this.label_pass.Text = "Password:";
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.BackColor = System.Drawing.Color.Transparent;
            this.label_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_register.Location = new System.Drawing.Point(201, 473);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(250, 22);
            this.label_register.TabIndex = 35;
            this.label_register.Text = ">> Don\'t you have a account?";
            this.label_register.Click += new System.EventHandler(this.label_register_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_username.Location = new System.Drawing.Point(159, 170);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(130, 29);
            this.label_username.TabIndex = 27;
            this.label_username.Text = "Username:";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_pass.Location = new System.Drawing.Point(164, 302);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(330, 34);
            this.textBox_pass.TabIndex = 34;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_username.Location = new System.Drawing.Point(164, 202);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(330, 34);
            this.textBox_username.TabIndex = 33;
            this.textBox_username.Enter += new System.EventHandler(this.textBox_username_Enter);
            this.textBox_username.Leave += new System.EventHandler(this.textBox_username_Leave);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_cancel.Location = new System.Drawing.Point(329, 374);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(142, 44);
            this.button_cancel.TabIndex = 32;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_forgot
            // 
            this.label_forgot.AutoSize = true;
            this.label_forgot.BackColor = System.Drawing.Color.Transparent;
            this.label_forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_forgot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_forgot.Location = new System.Drawing.Point(201, 442);
            this.label_forgot.Name = "label_forgot";
            this.label_forgot.Size = new System.Drawing.Size(181, 22);
            this.label_forgot.TabIndex = 31;
            this.label_forgot.Text = ">> Forgot password?";
            this.label_forgot.Click += new System.EventHandler(this.label_forgot_Click);
            this.label_forgot.MouseEnter += new System.EventHandler(this.label_forgot_MouseEnter);
            this.label_forgot.MouseLeave += new System.EventHandler(this.label_forgot_MouseLeave);
            // 
            // label_tieudeLOGINFORM
            // 
            this.label_tieudeLOGINFORM.AutoSize = true;
            this.label_tieudeLOGINFORM.BackColor = System.Drawing.Color.Transparent;
            this.label_tieudeLOGINFORM.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tieudeLOGINFORM.ForeColor = System.Drawing.Color.Navy;
            this.label_tieudeLOGINFORM.Location = new System.Drawing.Point(196, 36);
            this.label_tieudeLOGINFORM.Name = "label_tieudeLOGINFORM";
            this.label_tieudeLOGINFORM.Size = new System.Drawing.Size(243, 52);
            this.label_tieudeLOGINFORM.TabIndex = 30;
            this.label_tieudeLOGINFORM.Text = "Login Form";
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Login.Location = new System.Drawing.Point(164, 374);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(142, 44);
            this.button_Login.TabIndex = 29;
            this.button_Login.Text = "LOGIN";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Vehicle_license_plate_recognition.Properties.Resources._123_1236779_name_transparent_blue_square_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 534);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_forgot);
            this.Controls.Add(this.label_tieudeLOGINFORM);
            this.Controls.Add(this.button_Login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_forgot;
        private System.Windows.Forms.Label label_tieudeLOGINFORM;
        private System.Windows.Forms.Button button_Login;
    }
}