using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) &&
               string.IsNullOrWhiteSpace(txtEmail.Text) &&
               string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all the fields!", "Warning!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            QuanLiNhaXeEntities test = new QuanLiNhaXeEntities();
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            try 
            {
                NV q = new NV();
                q.Account = username;

                test.NVs.Add(q);
                test.SaveChanges();
                MessageBox.Show("Wellcome ", txtUsername.Text + "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Select();
                return;
            }
        }
    }
}
