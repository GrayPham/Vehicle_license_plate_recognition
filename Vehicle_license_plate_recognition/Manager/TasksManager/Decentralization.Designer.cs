namespace Vehicle_license_plate_recognition.Manager
{
    partial class Decentralization
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
            this.DVGDecentralization = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelXuLi = new System.Windows.Forms.Panel();
            this.radioBtnManager = new System.Windows.Forms.RadioButton();
            this.radioBtnOfficer = new System.Windows.Forms.RadioButton();
            this.radioBtnCaretaker = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbRequest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DVGDecentralization)).BeginInit();
            this.panelXuLi.SuspendLayout();
            this.SuspendLayout();
            // 
            // DVGDecentralization
            // 
            this.DVGDecentralization.AllowUserToAddRows = false;
            this.DVGDecentralization.AllowUserToDeleteRows = false;
            this.DVGDecentralization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVGDecentralization.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DVGDecentralization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGDecentralization.Location = new System.Drawing.Point(13, 13);
            this.DVGDecentralization.Name = "DVGDecentralization";
            this.DVGDecentralization.RowHeadersWidth = 51;
            this.DVGDecentralization.RowTemplate.Height = 24;
            this.DVGDecentralization.Size = new System.Drawing.Size(689, 308);
            this.DVGDecentralization.TabIndex = 0;
            this.DVGDecentralization.DoubleClick += new System.EventHandler(this.DVGDecentralization_DoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(403, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 51);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Confirm";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelXuLi
            // 
            this.panelXuLi.Controls.Add(this.btnDelete);
            this.panelXuLi.Controls.Add(this.radioBtnCaretaker);
            this.panelXuLi.Controls.Add(this.btnUpdate);
            this.panelXuLi.Controls.Add(this.radioBtnOfficer);
            this.panelXuLi.Controls.Add(this.radioBtnManager);
            this.panelXuLi.Location = new System.Drawing.Point(13, 354);
            this.panelXuLi.Name = "panelXuLi";
            this.panelXuLi.Size = new System.Drawing.Size(689, 51);
            this.panelXuLi.TabIndex = 2;
            // 
            // radioBtnManager
            // 
            this.radioBtnManager.AutoSize = true;
            this.radioBtnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnManager.Location = new System.Drawing.Point(274, 11);
            this.radioBtnManager.Name = "radioBtnManager";
            this.radioBtnManager.Size = new System.Drawing.Size(102, 24);
            this.radioBtnManager.TabIndex = 0;
            this.radioBtnManager.Text = "Manager";
            this.radioBtnManager.UseVisualStyleBackColor = true;
            // 
            // radioBtnOfficer
            // 
            this.radioBtnOfficer.AutoSize = true;
            this.radioBtnOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOfficer.Location = new System.Drawing.Point(157, 11);
            this.radioBtnOfficer.Name = "radioBtnOfficer";
            this.radioBtnOfficer.Size = new System.Drawing.Size(88, 24);
            this.radioBtnOfficer.TabIndex = 1;
            this.radioBtnOfficer.Text = "Officer";
            this.radioBtnOfficer.UseVisualStyleBackColor = true;
            // 
            // radioBtnCaretaker
            // 
            this.radioBtnCaretaker.AutoSize = true;
            this.radioBtnCaretaker.Checked = true;
            this.radioBtnCaretaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCaretaker.Location = new System.Drawing.Point(3, 11);
            this.radioBtnCaretaker.Name = "radioBtnCaretaker";
            this.radioBtnCaretaker.Size = new System.Drawing.Size(112, 24);
            this.radioBtnCaretaker.TabIndex = 2;
            this.radioBtnCaretaker.TabStop = true;
            this.radioBtnCaretaker.Text = "Caretaker";
            this.radioBtnCaretaker.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Silver;
            this.btnDelete.Location = new System.Drawing.Point(548, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 51);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbRequest
            // 
            this.lbRequest.AutoSize = true;
            this.lbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequest.ForeColor = System.Drawing.Color.Red;
            this.lbRequest.Location = new System.Drawing.Point(13, 328);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(297, 20);
            this.lbRequest.TabIndex = 3;
            this.lbRequest.Text = "Select the information to be authorized";
            // 
            // Decentralization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 405);
            this.Controls.Add(this.lbRequest);
            this.Controls.Add(this.panelXuLi);
            this.Controls.Add(this.DVGDecentralization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Decentralization";
            this.Text = "Decentralization";
            this.Load += new System.EventHandler(this.Decentralization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVGDecentralization)).EndInit();
            this.panelXuLi.ResumeLayout(false);
            this.panelXuLi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DVGDecentralization;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelXuLi;
        private System.Windows.Forms.RadioButton radioBtnOfficer;
        private System.Windows.Forms.RadioButton radioBtnManager;
        private System.Windows.Forms.RadioButton radioBtnCaretaker;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbRequest;
    }
}