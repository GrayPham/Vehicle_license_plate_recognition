namespace Vehicle_license_plate_recognition.ComponentForm
{
    partial class GetFaceIDStaff
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbIDStaff = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.lbInfor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Face ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Staff";
            // 
            // lbIDStaff
            // 
            this.lbIDStaff.AutoSize = true;
            this.lbIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDStaff.Location = new System.Drawing.Point(236, 127);
            this.lbIDStaff.Name = "lbIDStaff";
            this.lbIDStaff.Size = new System.Drawing.Size(41, 32);
            this.lbIDStaff.TabIndex = 2;
            this.lbIDStaff.Text = "ID";
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Red;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnStaff.Location = new System.Drawing.Point(209, 241);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(154, 39);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Start";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // lbInfor
            // 
            this.lbInfor.AutoSize = true;
            this.lbInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfor.ForeColor = System.Drawing.Color.Red;
            this.lbInfor.Location = new System.Drawing.Point(92, 189);
            this.lbInfor.Name = "lbInfor";
            this.lbInfor.Size = new System.Drawing.Size(178, 29);
            this.lbInfor.TabIndex = 4;
            this.lbInfor.Text = "Push the button";
            // 
            // GetFaceIDStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 302);
            this.Controls.Add(this.lbInfor);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.lbIDStaff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GetFaceIDStaff";
            this.Text = "GetFaceIDStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label lbInfor;
        internal System.Windows.Forms.Label lbIDStaff;
    }
}