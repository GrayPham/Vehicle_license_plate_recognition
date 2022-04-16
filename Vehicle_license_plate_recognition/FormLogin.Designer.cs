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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_signup = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_forgot = new System.Windows.Forms.Label();
            this.label_tieudeLOGINFORM = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_logo);
            this.groupBox1.Controls.Add(this.label_pass);
            this.groupBox1.Controls.Add(this.label_signup);
            this.groupBox1.Controls.Add(this.label_username);
            this.groupBox1.Controls.Add(this.textBox_pass);
            this.groupBox1.Controls.Add(this.textBox_username);
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.label_forgot);
            this.groupBox1.Controls.Add(this.label_tieudeLOGINFORM);
            this.groupBox1.Controls.Add(this.button_Login);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(87, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackgroundImage = global::Vehicle_license_plate_recognition.Properties.Resources.logo_CLC_Circle;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_logo.Location = new System.Drawing.Point(215, 45);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(107, 67);
            this.pictureBox_logo.TabIndex = 24;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(30, 181);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(97, 20);
            this.label_pass.TabIndex = 12;
            this.label_pass.Text = "Password:";
            // 
            // label_signup
            // 
            this.label_signup.AutoSize = true;
            this.label_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_signup.Location = new System.Drawing.Point(34, 272);
            this.label_signup.Name = "label_signup";
            this.label_signup.Size = new System.Drawing.Size(183, 18);
            this.label_signup.TabIndex = 23;
            this.label_signup.Text = "Don\'t you have a account?";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(30, 132);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(100, 20);
            this.label_username.TabIndex = 11;
            this.label_username.Text = "Username:";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox_pass.Location = new System.Drawing.Point(146, 177);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(308, 28);
            this.textBox_pass.TabIndex = 22;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(146, 132);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(308, 27);
            this.textBox_username.TabIndex = 21;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(273, 335);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(93, 44);
            this.button_cancel.TabIndex = 20;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_forgot
            // 
            this.label_forgot.AutoSize = true;
            this.label_forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_forgot.Location = new System.Drawing.Point(34, 238);
            this.label_forgot.Name = "label_forgot";
            this.label_forgot.Size = new System.Drawing.Size(129, 18);
            this.label_forgot.TabIndex = 19;
            this.label_forgot.Text = "Forgot password?";
            this.label_forgot.Click += new System.EventHandler(this.label_forgot_Click);
            // 
            // label_tieudeLOGINFORM
            // 
            this.label_tieudeLOGINFORM.AutoSize = true;
            this.label_tieudeLOGINFORM.Font = new System.Drawing.Font("Lucida Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tieudeLOGINFORM.Location = new System.Drawing.Point(153, 0);
            this.label_tieudeLOGINFORM.Name = "label_tieudeLOGINFORM";
            this.label_tieudeLOGINFORM.Size = new System.Drawing.Size(233, 42);
            this.label_tieudeLOGINFORM.TabIndex = 18;
            this.label_tieudeLOGINFORM.Text = "Login Form";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(169, 335);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(98, 44);
            this.button_Login.TabIndex = 17;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 534);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_signup;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_forgot;
        private System.Windows.Forms.Label label_tieudeLOGINFORM;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}