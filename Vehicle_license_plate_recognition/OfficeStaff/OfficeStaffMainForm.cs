using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.Login;
using Vehicle_license_plate_recognition.OfficeStaff.Customer;
using Vehicle_license_plate_recognition.OfficeStaff.Status;
using Vehicle_license_plate_recognition.OfficeStaff.Turnover;
using Vehicle_license_plate_recognition.Controller.OfficeStaff;

namespace Vehicle_license_plate_recognition.OfficeStaff
{
    public partial class OfficeStaffMainForm : Form
    {
        public OfficeStaffMainForm()
        {
            InitializeComponent();
  
        }

        OfficeMainFormBLL cBLL = new OfficeMainFormBLL();

        private void OfficeStaffMainForm_Load(object sender, EventArgs e)
        {

            txtIDStaff.Text = GlobalData.idStaff.ToString();
            if (cBLL.getAllContract() != null)
            {
                dataGridView_phancongtho.DataSource = cBLL.getAllContract();
            }
            else
            {
                MessageBox.Show("Datagridview is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            this.Visible = false;
            addCustomer.ShowDialog();
            this.Visible = true;
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer();
            this.Visible = false;
            editCustomer.ShowDialog();
            this.Visible=true;

        }

        private void rEMOVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            this.Visible = false;
            deleteCustomer.ShowDialog();
            this.Visible = true;

        }

        private void totalRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalDetail totalDetail = new TotalDetail();
            totalDetail.ShowDialog();   
        }

        private void searchlStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchContract search = new SearchContract();
            search.ShowDialog();
        }
        private void button_timekeeping_Click(object sender, EventArgs e)
        {
            FormFaceRecognition formFace = new FormFaceRecognition();
            formFace.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract();
            this.Visible = false;
            addContract.ShowDialog();
            this.Visible = true;
            if (cBLL.getAllContract() != null)
            {
                dataGridView_phancongtho.DataSource = cBLL.getAllContract();
            }
            else
            {
                MessageBox.Show("Datagridview is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer();
            this.Visible = false;
            manageCustomer.ShowDialog();
            this.Visible=true;
        }

        private void editContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContract editContract = new EditContract();
            this.Visible = false;
            editContract.ShowDialog();
            this.Visible = true;
            if (cBLL.getAllContract() != null)
            {
                dataGridView_phancongtho.DataSource = cBLL.getAllContract();
            }
            else
            {
                MessageBox.Show("Datagridview is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContract deleteContract = new DeleteContract();
            this.Visible = false;
            deleteContract.ShowDialog();
            this.Visible = true;
            if (cBLL.getAllContract() != null)
            {
                dataGridView_phancongtho.DataSource = cBLL.getAllContract();
            }
            else
            {
                MessageBox.Show("Datagridview is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
