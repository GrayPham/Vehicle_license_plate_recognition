using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.Manager;

namespace Vehicle_license_plate_recognition.Manager.Staff
{
    public partial class AddStaffManager : StaffManagerInheritance
    {
        public AddStaffManager()
        {
            InitializeComponent();
        }
        ManagerStaff mStaff = new ManagerStaff();
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtID.Text))
                {
                    int idStaff = Convert.ToInt32(txtID.Text);
                    if(idStaff > 0)
                    {
                        if (mStaff.checkIDStaff(idStaff))
                        {

                            if (mStaff.checkAccount(txtAccount.Text))
                            {
                                if (mStaff.checkEmail(txtEmail.Text))
                                {
                                    string account = txtAccount.Text;
                                    string email = txtEmail.Text;
                                    string phone = txtPhone.Text;
                                    MemoryStream pic = new MemoryStream();
                                    PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);
                                    // Kiểm tra phone và email

                                    string pass = txtPassword.Text;
                                    string fname = txtFullName.Text;

                                    DateTime adddate = TimePickerDateAdd.Value;
                                    int type = checkTypeStaff();
                                    if (mStaff.AddStaff(idStaff,account,pass, fname,email,phone,adddate, type, pic))
                                    {
                                        MessageBox.Show("Successfully added employees", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Add employee failed", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Email already exists", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }
                            else
                            {
                                MessageBox.Show("Employee account already exists", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Employee code already exists", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee ID must be a positive number greater than 0", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Employee code must be number", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter full information", "Add Staff",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnUploadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private int checkTypeStaff()
        {
            int type = 1;
            if(radioBtnOfficer.Checked)
                type = 2;
            else if (radioBtnManager.Checked)
            {
                type = 3;
            }
            return type;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            TimePickerDateAdd.Value = DateTime.Now;
            txtEmail.Text = "";
            txtPhone.Text = "";
            
        }
        bool verif()
        {
            if ((txtID.Text.Trim() == "") || 
                (txtAccount.Text.Trim() == "") || 
                (txtPassword.Text.Trim() == "") || 
                (txtFullName.Text.Trim() == "") || 
                (PictureBoxImage.Image == null) || 
                txtPhone.Text.Trim() == "" ||
                txtEmail.Text.Trim()== "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void AddStaffManager_Load(object sender, EventArgs e)
        {
            TimePickerDateAdd.Value = DateTime.Now;
        }
    }
}
