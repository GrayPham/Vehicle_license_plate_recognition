namespace Vehicle_license_plate_recognition
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cONTRACTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractIsUpFor7DaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractIsStillexpiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_attendance = new System.Windows.Forms.Button();
            this.button_shift = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_logout = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONTRACTToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1514, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cONTRACTToolStripMenuItem
            // 
            this.cONTRACTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.cONTRACTToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cONTRACTToolStripMenuItem.Name = "cONTRACTToolStripMenuItem";
            this.cONTRACTToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.cONTRACTToolStripMenuItem.Text = "CONTRACT";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.editRemoveToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contractIsUpFor7DaysToolStripMenuItem,
            this.contractIsStillexpiredToolStripMenuItem});
            this.statusToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.statusToolStripMenuItem.Text = "STATUS";
            // 
            // contractIsUpFor7DaysToolStripMenuItem
            // 
            this.contractIsUpFor7DaysToolStripMenuItem.Name = "contractIsUpFor7DaysToolStripMenuItem";
            this.contractIsUpFor7DaysToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.contractIsUpFor7DaysToolStripMenuItem.Text = "Contract is up for 7 days";
            // 
            // contractIsStillexpiredToolStripMenuItem
            // 
            this.contractIsStillexpiredToolStripMenuItem.Name = "contractIsStillexpiredToolStripMenuItem";
            this.contractIsStillexpiredToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.contractIsStillexpiredToolStripMenuItem.Text = "Contract is still/expired";
            // 
            // button_attendance
            // 
            this.button_attendance.Location = new System.Drawing.Point(1380, 734);
            this.button_attendance.Name = "button_attendance";
            this.button_attendance.Size = new System.Drawing.Size(113, 49);
            this.button_attendance.TabIndex = 2;
            this.button_attendance.Text = "Attendance";
            this.button_attendance.UseVisualStyleBackColor = true;
            // 
            // button_shift
            // 
            this.button_shift.Location = new System.Drawing.Point(12, 734);
            this.button_shift.Name = "button_shift";
            this.button_shift.Size = new System.Drawing.Size(121, 49);
            this.button_shift.TabIndex = 3;
            this.button_shift.Text = "Shift";
            this.button_shift.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1481, 664);
            this.dataGridView1.TabIndex = 4;
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_logout.Location = new System.Drawing.Point(1352, 9);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(100, 29);
            this.label_logout.TabIndex = 5;
            this.label_logout.Text = "Log out";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 815);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_shift);
            this.Controls.Add(this.button_attendance);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONTRACTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractIsUpFor7DaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractIsStillexpiredToolStripMenuItem;
        private System.Windows.Forms.Button button_attendance;
        private System.Windows.Forms.Button button_shift;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_logout;
    }
}