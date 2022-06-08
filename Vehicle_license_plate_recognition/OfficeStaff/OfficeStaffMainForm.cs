﻿using System;
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
            txtIDStaff.Text = GlobalData.NameUser;
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

        private void addContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract();
            this.Visible = false;
            addContract.ShowDialog();
            this.Visible = true;
        }
    }
}
