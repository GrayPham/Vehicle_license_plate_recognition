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
    public partial class FormResetPassword : Form
    {
        public FormResetPassword()
        {
            InitializeComponent();
        }

        QuanLiNhaXeEntities test = new QuanLiNhaXeEntities();

        string emailForgot = FormForgotPassword.to;
        private void button_reset_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_newpass.Text) || string.IsNullOrEmpty(textBox_confirm.Text))
            {
                MessageBox.Show("Please provide your New Password and Confirm!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_newpass.Select();
                return;
            }    
            if (textBox_newpass.Text == textBox_confirm.Text)
            {
                var pass = (from user in test.NVs where user.Email == emailForgot select user).ToList();
                pass[0].Password = textBox_newpass.Text;
                test.SaveChanges();
                MessageBox.Show("Reset successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The new password do not match so enter the same password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin a = new FormLogin();
            a.ShowDialog();
        }
    }
}
