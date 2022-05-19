using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.Manager;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.Manager.TasksManager
{
    public partial class EditPark : Form
    {
        ManagerPark mParking = new ManagerPark();
        public EditPark()
        {
            InitializeComponent(); fillcombo();
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
                fillPanalRight(idPark);

            }
            else
            {
                // Thong bao
            }
        }

        private void comboBoxNamePark_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idPark = comboBoxNamePark.SelectedValue.ToString();
            fillPanalRight(idPark);
        }
        private void fillPanalRight(string idPark)
        {
            idPark = comboBoxNamePark.SelectedValue.ToString();
            List<Capacity> dataCapOfPark = mParking.getCapOfPark(idPark);
            txtNamePark.Text = idPark;
            foreach (Capacity c in dataCapOfPark)
            {
                if (c.IdVehicleType == 1)
                {
                    numberMaxCapacityBicycle.Value = (decimal)c.MaxCapacity;
                }
                else if (c.IdVehicleType == 2)
                {
                    numberMotorCapacity.Value = (decimal)c.MaxCapacity;
                }
                else if (c.IdVehicleType == 3)
                {
                    numberMaxCapacityCar.Value = (decimal)c.MaxCapacity;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            numberMaxCapacityBicycle.Value = 0;
            numberMotorCapacity.Value = 0;
            numberMaxCapacityCar.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string namePark = txtNamePark.Text;
            int maxMotor = (int)numberMotorCapacity.Value;
            int maxBicycle = (int)numberMaxCapacityBicycle.Value;
            int maxCar = (int)numberMaxCapacityCar.Value;
            string oldNamePark = comboBoxNamePark.Text;
            try
            {
                mParking.UpdatePark(oldNamePark, namePark, maxMotor, maxBicycle, maxCar);
                comboBoxNamePark.DisplayMember = "Name";
                comboBoxNamePark.ValueMember = "Name";
                comboBoxNamePark.DataSource = mParking.getAllNotUsePark();
            }
            catch (Exception)
            {
                MessageBox.Show("The car is still in the parking lot", "Information");
            }
            
        }
    }
}
