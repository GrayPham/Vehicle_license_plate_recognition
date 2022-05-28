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
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.OfficeStaff.Customer
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }
        CustomerBLL cBLL = new CustomerBLL();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // Hàm hiển thị combobox
        public void fillCombo(int index=0)
        {
            try
            {
                comboBox_select.DisplayMember = "Id";
                comboBox_select.ValueMember = "Id";
                comboBox_select.DataSource = cBLL.getAllCustomer();
                if (comboBox_select.Items.Count > -1)
                {
                    comboBox_select.SelectedIndex = index;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Don't enough the number of customers to update!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_fullname.Enabled = false;
                textBox_phone.Enabled = false;
                textBox_id.Enabled = false;
                nUDTypeCus.Value = 1;
                panel3.Enabled = false;
                tbEmail.Enabled = false;
                this.Close();
            }

        }
        private void button_edit_Click(object sender, EventArgs e)
        {

            string id = textBox_id.Text;
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
            cBLL.UpdateCustomerBLL(id, type, fname, birthdate, email, gender, phone);
            //fillCombo();
            
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            fillCombo();
           
        }
        // Sự kiện thay đổi combobox
        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox_select.SelectedValue);
                Model.Customer cus = cBLL.diplayCustomer(id);
                textBox_id.Text = cus.Id.ToString();
                nUDTypeCus.Value = Convert.ToDecimal(cus.TypeID);
                textBox_fullname.Text = cus.FullName.ToString();
                textBox_phone.Text = cus.Phone.ToString();
                dTPBirthDate.Value = (DateTime)cus.BirthDate;
                string gender = (string)cus.Gender;
                if (gender == "Female")
                {
                    RadioButtonMale.Checked = false;
                    RadioButtonFemale.Checked = true;
                }
                else
                {
                    RadioButtonFemale.Checked = false;
                    RadioButtonMale.Checked = true;
                }
                tbEmail.Text = cus.Email.ToString();    


            }
            catch (Exception)
            {

                MessageBox.Show("Don't enough the number of customers to update!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_select.DataSource = null;
                textBox_fullname.Enabled = false;
                textBox_phone.Enabled = false;
                textBox_id.Enabled = false;
                nUDTypeCus.Value = 1;
                panel3.Enabled = false;
                tbEmail.Enabled = false;

            }
        }
    }
}
