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

namespace Vehicle_license_plate_recognition.OfficeStaff
{
    public partial class OfficeStaffMainForm : Form
    {
        public OfficeStaffMainForm()
        {
            InitializeComponent();
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OfficeStaffMainForm_Load(object sender, EventArgs e)
        {

            txtIDStaff.Text = GlobalData.idStaff.ToString();

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

        private void mANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomer mg = new ManageCustomer();
            this.Visible = false;
            mg.ShowDialog();
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContract deleteContract = new DeleteContract();
            deleteContract.ShowDialog();
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
            addContract.ShowDialog();
        }

        private void editContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContract editContract = new EditContract();
            editContract.ShowDialog();

        }
    }
}
