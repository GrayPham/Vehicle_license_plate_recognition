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
    public partial class EditContract : Form
    {
        public EditContract()
        {
            InitializeComponent();
        }
        ContractBLL cBLL = new ContractBLL();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEditCustract_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiem tra ID la so 
                if (IsNumber(textBox_idcontract.Text) == false)
                {
                    MessageBox.Show("ID must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                int id = Convert.ToInt32(textBox_idcontract.Text);
                string name = textBox_name.Text;
                string content = richTextBox_content.Text;
                int staff = Convert.ToInt32(txtIDStaff.Text);
                int idrenter = Convert.ToInt32(comboBox_select.SelectedValue.ToString());
                DateTime create = dateTimePicker_creation.Value;
                DateTime expiry = dateTimePicker_expiry.Value;
                int type = Convert.ToInt32(radioButtonRental.Checked);
                decimal unit = Convert.ToDecimal(textBox_total.Text);
                System.TimeSpan d = expiry.Subtract(create);
                decimal total = (decimal)d.TotalDays * unit;
                if (CompanyRental.Checked)
                {
                    type = 2;
                }
                cBLL.EditContractBLL(id, name, content, staff, idrenter, create, expiry, type, total);
                DVGListContract.DataSource = cBLL.getAllContract();
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

        private void EditContract_Load(object sender, EventArgs e)
        {
            if (radioButtonRental.Checked)
            {
                fillCombo();
            }
            txtIDStaff.Text = GlobalData.idStaff.ToString();
            lbNameStaff.Text = GlobalData.NameUser;

            DVGListContract.DataSource = cBLL.getAllContract();
            DVGListContract.ScrollBars = ScrollBars.Both;
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
                this.Close();
            }
        }
        private void radioButtonRental_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRental.Checked)
            {
                fillCombo(1);
            }
        }
        // Hàm hiển thị id customer trong combobox
        private void ratio_CompanyRental_CheckedChanged(object sender, EventArgs e)
        {
            if (CompanyRental.Checked)
            {
                fillCombo(2);
            }
        }
        private void DVGListContract_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox_idcontract.Text = DVGListContract.CurrentRow.Cells[0].Value.ToString();
                textBox_name.Text = DVGListContract.CurrentRow.Cells[1].Value.ToString();
                richTextBox_content.Text = DVGListContract.CurrentRow.Cells[2].Value.ToString();
                if (DVGListContract.CurrentRow.Cells[4].Value != null)
                {
                    comboBox_select.SelectedItem = DVGListContract.CurrentRow.Cells[4].Value.ToString();
                }

                if (DVGListContract.CurrentRow.Cells[5].Value.ToString() == "Female")
                {
                    radioButtonRental.Checked = true;
                }
                else
                {
                    CompanyRental.Checked = true;
                }

                dateTimePicker_creation.Value = (DateTime)DVGListContract.CurrentRow.Cells[6].Value;
                dateTimePicker_expiry.Value = (DateTime)DVGListContract.CurrentRow.Cells[7].Value;
                
                string total = DVGListContract.CurrentRow.Cells[8].Value.ToString();
                decimal to = Convert.ToDecimal(total);
                DateTime create = dateTimePicker_creation.Value;
                DateTime expiry = dateTimePicker_expiry.Value;
                if (create != expiry)
                {
                    System.TimeSpan d = expiry.Subtract(create);
                    decimal unit = to / (decimal)(d.TotalDays);
                    textBox_total.Text = unit.ToString();
                }
                else
                {
                    textBox_total.Text =to.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("List is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}

