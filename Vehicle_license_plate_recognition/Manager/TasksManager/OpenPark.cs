using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.Manager;

namespace Vehicle_license_plate_recognition.Manager.TasksManager
{
    public partial class OpenPark : Form
    {
        ManagerPark mParking = new ManagerPark();
        public OpenPark()
        {
            InitializeComponent();
        }
        private void fillcombo()
        {
            comboBoxNamePark.SelectedItem = null;
            comboBoxNamePark.DisplayMember = "Name";
            comboBoxNamePark.ValueMember = "Name";
            comboBoxNamePark.DataSource = mParking.getAllNotUsePark();
            if (comboBoxNamePark.SelectedItem != null)
            {
                string idPark = comboBoxNamePark.SelectedValue.ToString();


            }
            else
            {
                // Thong bao
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            if (comboBoxNamePark.SelectedIndex != -1)
            {
                string idPark = comboBoxNamePark.SelectedValue.ToString();
                mParking.OpenPark(idPark);
                lbMess.Text = lbMess.Text + " Successfull";
                fillcombo();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenPark_Load(object sender, EventArgs e)
        {
            if (comboBoxNamePark.SelectedIndex != -1)
            {
                btnOpen.Enabled = false;
            }
        }
    }
}
