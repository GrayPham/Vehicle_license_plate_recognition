using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.OfficeStaff;

namespace Vehicle_license_plate_recognition.OfficeStaff.Customer
{
    public partial class AddCustomer : Form
    {
        CustomerBLL cBLL = new CustomerBLL();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string id =textBox_id.Text;
            string type = nUDTypeCus.Value.ToString();
            string fname = textBox_fullname.Text;
            DateTime birthdate = dTPBirthDate.Value;
            string email = tbEmail.Text.ToString();
            string gender = "Male";
            string phone = textBox_phone.Text.ToString();
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            cBLL.AddCustomerBLL(id, type , fname , birthdate, email, gender, phone);
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txtIDStaff.Text = GlobalData.idStaff.ToString();
            lbNameStaff.Text = GlobalData.NameUser.ToString();
        }
    }
}
