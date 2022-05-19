using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_license_plate_recognition.Manager.Staff
{
    public partial class AddStaffManager : StaffManagerInheritance
    {
        public AddStaffManager()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            TimePickerDateAdd.Value = DateTime.Now;
            txtEmail.Text = "";
            txtPhone.Text = "";
            
        }
    }
}
