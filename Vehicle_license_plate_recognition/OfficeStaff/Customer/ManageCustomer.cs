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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }
        CustomerBLL cBLL = new CustomerBLL();

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            dataGridView_show.DataSource = cBLL.getAllCustomer();
            // Đổi màu nút reload
            this.pictureBox_reload.MouseEnter += new System.EventHandler(this.pictureBox_reload_MouseEnter);
            this.pictureBox_reload.MouseLeave += new System.EventHandler(this.pictureBox_reload_MouseLeave);
            // Đổi màu nút thoát
            this.pictureBox_exit.MouseEnter += new System.EventHandler(this.pictureBox_exit_MouseEnter);
            this.pictureBox_exit.MouseLeave += new System.EventHandler(this.pictureBox_exit_MouseLeave);
        }
        // Reload datagridview
        private void pictureBox_reload_Click(object sender, EventArgs e)
        {
            dataGridView_show.DataSource = cBLL.getAllCustomer();
            dTPBirthDate.Value = DateTime.Now;
            textBox_fullname.Text = "";
            textBox_phone.Text = "";
            textBox_id.Text = "";
            nUDTypeCus.Value = 1;
            tbEmail.Text = "";
        }
        // Hiển thị trên textbox khi click datadridview
        private void dataGridView_show_Click(object sender, EventArgs e)
        {
            try
            {
                    textBox_id.Text = dataGridView_show.CurrentRow.Cells[0].Value.ToString();
                    nUDTypeCus.Value = Convert.ToDecimal(dataGridView_show.CurrentRow.Cells[1].Value);
                    textBox_fullname.Text = dataGridView_show.CurrentRow.Cells[2].Value.ToString();
                    textBox_phone.Text = dataGridView_show.CurrentRow.Cells[3].Value.ToString();
                    dTPBirthDate.Value = (DateTime)dataGridView_show.CurrentRow.Cells[4].Value;
                    if (dataGridView_show.CurrentRow.Cells[5].Value.ToString() == "Female")
                    {
                        RadioButtonFemale.Checked = true;
                    }
                    else
                    {
                        RadioButtonMale.Checked = true;
                    }
                    tbEmail.Text = dataGridView_show.CurrentRow.Cells[6].Value.ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("List is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void pictureBox_reload_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_reload.BackColor = Color.Aqua;

        }
        
        private void pictureBox_reload_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_reload.BackColor = Color.White;
        }
        // Thoát form
        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_exit_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_exit.BackColor = Color.Aqua;
        }

        private void pictureBox_exit_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_exit.BackColor = Color.White;

        }

        // Tìm kiếm thông tin khách
        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_search.Text))
                {
                    MessageBox.Show("Please fill in the box to find Customer!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int search = Convert.ToInt32(textBox_search.Text);
                    dataGridView_show.DataSource = cBLL.diplayCustomer(search);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please only use ID to find Customer!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        // Xóa khách
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_show.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do You Want To delete This Score?", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int id = int.Parse(dataGridView_show.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Customer removed!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cBLL.DeleteCus(id);
                    dataGridView_show.DataSource = cBLL.getAllCustomer();
                }
            }
            else
            {
                MessageBox.Show("List has nothing to remove!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Thêm khách
        private void button_add_Click(object sender, EventArgs e)
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
            cBLL.AddCustomerBLL(id, type, fname, birthdate, email, gender, phone);
        }

        // Chỉnh sửa khách
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
        }
    }
}
