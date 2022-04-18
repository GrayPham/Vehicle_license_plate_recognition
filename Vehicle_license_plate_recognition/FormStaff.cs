using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_license_plate_recognition
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //TopMost = true;
        }

        private void button_working_Click(object sender, EventArgs e)
        {
            FormVehicleCam formVehicleCam = new FormVehicleCam();
            this.Visible = false;
            formVehicleCam.ShowDialog();
            this.Visible = true;
        }

        private void FormStaff_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    //FormBorderStyle = FormBorderStyle.Sizable;
            //    //WindowState = FormWindowState.Normal;
            //    //TopMost = false;
            //}
        }

    }
}
