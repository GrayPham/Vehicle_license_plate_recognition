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

namespace Vehicle_license_plate_recognition.OfficeStaff
{
    public partial class AddContract : Form
    {
        public AddContract()
        {
            InitializeComponent();
        }

        ContractBLL cBLL = new ContractBLL();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiem tra ID la so 
                if (IsNumber(textBox_idcontract.Text) == false)
                {
                    MessageBox.Show("ID must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                int id = Convert.ToInt32(textBox_idcontract.Text);
                int idrenter = Convert.ToInt32(comboBox_select.SelectedValue.ToString());

                string name = textBox_name.Text;
                string content = richTextBox_content.Text;
                int staff = Convert.ToInt32(txtIDStaff.Text);
                DateTime create = dateTimePicker_creation.Value;
                DateTime expiry = dateTimePicker_expiry.Value;
                int type = Convert.ToInt32(radioButtonRental.Checked);
                decimal unit = Convert.ToDecimal(textBox_total.Text);
                System.TimeSpan d = expiry.Subtract(create);
                decimal total = (decimal)d.TotalDays * unit;
                if (ratio_CompanyRental.Checked)
                {
                    type = 2;
                }
                cBLL.AddContractBLL(id, name, content, staff, idrenter, create, expiry, type, total);
                DVGListCustomer.DataSource = cBLL.getAllContract();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your information again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsNumber(string text)
        {
            foreach (char str in text)
            {
                if (!Char.IsNumber(str))
                {
                    return false;
                }
            }
            return true;
        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            txtIDStaff.Text = GlobalData.idStaff.ToString();
            lbNameStaff.Text = GlobalData.NameUser.ToString();
            if (radioButtonRental.Checked)
            {
                fillCombo();
            }


            DVGListCustomer.DataSource = cBLL.getAllContract();
            DVGListCustomer.ScrollBars = ScrollBars.Both;

        }

        // Hàm hiển thị id customer trong combobox
        public void fillCombo(int type = 1)
        {
            try
            {
                comboBox_select.DisplayMember = "Id";
                comboBox_select.ValueMember = "Id";
                comboBox_select.DataSource = cBLL.getAllCustomer(type);
                if (comboBox_select.Items.Count > -1)
                {
                    comboBox_select.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Customer ID does not exists, you must to add new Customer. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonRental_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRental.Checked)
            {
                fillCombo(1);
            }
        }

        private void ratio_CompanyRental_CheckedChanged(object sender, EventArgs e)
        {
            if (ratio_CompanyRental.Checked)
            {
                fillCombo(2);
            }
        }
        
    }
}
