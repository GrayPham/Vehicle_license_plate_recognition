namespace Vehicle_license_plate_recognition.Manager.TasksManager
{
    partial class DeletePark
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDone = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNamePark = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbMess = new System.Windows.Forms.Label();
            this.pictureBoxPark = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPark)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delete the park in the system";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 72);
            this.panel1.TabIndex = 21;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(487, 253);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(139, 51);
            this.btnDone.TabIndex = 22;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Park\'s name needs to be deleted";
            // 
            // comboBoxNamePark
            // 
            this.comboBoxNamePark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNamePark.FormattingEnabled = true;
            this.comboBoxNamePark.Location = new System.Drawing.Point(318, 161);
            this.comboBoxNamePark.Name = "comboBoxNamePark";
            this.comboBoxNamePark.Size = new System.Drawing.Size(291, 33);
            this.comboBoxNamePark.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(298, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 51);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMess.Location = new System.Drawing.Point(313, 210);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(93, 25);
            this.lbMess.TabIndex = 28;
            this.lbMess.Text = "Messege";
            // 
            // pictureBoxPark
            // 
            this.pictureBoxPark.Image = global::Vehicle_license_plate_recognition.Properties.Resources.park1;
            this.pictureBoxPark.Location = new System.Drawing.Point(0, 130);
            this.pictureBoxPark.Name = "pictureBoxPark";
            this.pictureBoxPark.Size = new System.Drawing.Size(239, 174);
            this.pictureBoxPark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPark.TabIndex = 26;
            this.pictureBoxPark.TabStop = false;
            // 
            // DeletePark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 405);
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBoxPark);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxNamePark);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletePark";
            this.Text = "DeletePark";
            this.Load += new System.EventHandler(this.DeletePark_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNamePark;
        private System.Windows.Forms.PictureBox pictureBoxPark;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbMess;
    }
}