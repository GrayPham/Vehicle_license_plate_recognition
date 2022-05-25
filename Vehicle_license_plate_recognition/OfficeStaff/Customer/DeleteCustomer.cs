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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        CustomerBLL cBLL = new CustomerBLL();
        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            dataGridView_show.DataSource = cBLL.getAllCustomer();
            dataGridView_show.ScrollBars = ScrollBars.Both;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView_show.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("Do You Want To delete This Score?", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (cBLL.DeleteCus(id))
                {
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_show.DataSource = cBLL.getAllCustomer();
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
