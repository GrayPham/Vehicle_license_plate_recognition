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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" || txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please fill in the gaps!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Select();
                return;
            }
            QuanLiNhaXeEntities test = new QuanLiNhaXeEntities();
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string pass = txtPassword.Text;

            //var p = user.nvs insert into login (username, password, email)" + "values ( @un, @pw, @email)
            //command.parameters.add("@un", sqldbtype.nchar).value = txtusername.text;
            //command.parameters.add("@email", sqldbtype.nvarchar).value = txtemail.text;
            //command.parameters.add("@pw", sqldbtype.nchar).value = txtpassword.text;
            //db.openconnection();
            //if ((command.executenonquery() == 1))
            //{
            //    db.closeconnection();
            //    messagebox.show("successfully!");
            //}
            //else
            //{
            //    db.closeconnection();
            //    messagebox.show("error!");

            //}
        }
    }
}
