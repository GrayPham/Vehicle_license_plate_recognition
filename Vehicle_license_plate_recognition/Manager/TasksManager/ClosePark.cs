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
    public partial class ClosePark : Form
    {
        ManagerPark mParking = new ManagerPark();
        public ClosePark()
        {
            InitializeComponent();
            fillcombo();
        }
        private void fillcombo()
        {
            comboBoxNamePark.SelectedItem = null;
            comboBoxNamePark.DisplayMember = "Name";
            comboBoxNamePark.ValueMember = "Name";
            comboBoxNamePark.DataSource = mParking.getAllUsePark();
            if (comboBoxNamePark.SelectedItem != null)
            {
                string idPark = comboBoxNamePark.SelectedValue.ToString();


            }
            else
            {
                // Thong bao
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            string idPark = comboBoxNamePark.SelectedValue.ToString();
            if (idPark != null)
            {
                mParking.ClosePark(idPark);
                lbMess.Text = lbMess.Text + " Successfull";
                fillcombo();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
