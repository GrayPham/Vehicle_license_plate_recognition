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

namespace Vehicle_license_plate_recognition.Manager
{
    public partial class AddPark : Form
    {
        ManagerPark mAddPark = new ManagerPark();
        public AddPark()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtNamePark.Text != "" )
            {
                // CHeck trung Ten Park
                if(numberMotorCapacity.Value != 0 || numberMaxCapacityBicycle.Value != 0 || numberMaxCapacityCar.Value != 0)
                {
                    string namePark = txtNamePark.Text;
                    int maxMotor = (int)numberMotorCapacity.Value;
                    int maxBicycle = (int)numberMaxCapacityBicycle.Value;
                    int maxCar = (int)numberMaxCapacityCar.Value;
                    mAddPark.GeneratePark(namePark, maxMotor, maxBicycle, maxCar);
                    lbThongTin.Text = "Add Thanh Cong";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNamePark.Text = "";
            numberMotorCapacity.Value = 0;
            numberMaxCapacityBicycle.Value = 0;
            numberMaxCapacityCar.Value = 0;
        }
    }
}
