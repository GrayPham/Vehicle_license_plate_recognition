using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.BLL;

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

            txtIDStaff.Text = GlobalData.idStaff.ToString();
            fillDVG();

        }
        NVBLL nvBLL = new NVBLL();
        private void fillDVG()
        {
            int idStaff = Convert.ToInt32( txtIDStaff.Text);
            dataGridView_phancongtho.DataSource = nvBLL.GetAllBillVehicleOfNV(idStaff);
        }
        private void button_working_Click(object sender, EventArgs e)
        {
            FormVehicleCam formVehicleCam = new FormVehicleCam();
            this.Visible = false;
            formVehicleCam.txtIdStaff.Text = txtIDStaff.Text;
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

        private void button_timekeeping_Click(object sender, EventArgs e)
        {
            FormFaceRecognition formFaceRecognition = new FormFaceRecognition();
            this.Visible=false;
            formFaceRecognition.ShowDialog();
            this.Visible = true;
        }
    }
}
