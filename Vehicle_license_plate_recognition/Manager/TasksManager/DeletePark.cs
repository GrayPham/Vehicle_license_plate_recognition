﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.Manager;

namespace Vehicle_license_plate_recognition.Manager.TasksManager
{
    public partial class DeletePark : Form
    {
        ManagerPark mParking = new ManagerPark();
        public DeletePark()
        {
            InitializeComponent();
            
            
        }
        private void fillcombo()
        {
            comboBoxNamePark.SelectedItem = null;
            comboBoxNamePark.DisplayMember = "Name";
            comboBoxNamePark.ValueMember = "Name";
            comboBoxNamePark.DataSource = mParking.getAllNotUsePark();
            if (comboBoxNamePark.SelectedItem != null)
            {
                string idPark = comboBoxNamePark.SelectedValue.ToString();
                

            }
            else
            {
                // Thong bao
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Loi khi nut Delete Xoa comboBox rỗng
            if (comboBoxNamePark.SelectedIndex != -1)
            {
                string idPark = comboBoxNamePark.SelectedValue.ToString();
                mParking.DeletePark(idPark);
                fillcombo();
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeletePark_Load(object sender, EventArgs e)
        {
            fillcombo();
            if (comboBoxNamePark.SelectedIndex != -1)
            {
                btnDelete.Enabled = false;
            }
        }
    }
}
