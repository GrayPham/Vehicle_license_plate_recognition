using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller.Manager;
using Vehicle_license_plate_recognition.NomalObject;

namespace Vehicle_license_plate_recognition.Manager.Staff
{
    public partial class UpdateStaffManager : StaffManagerInheritance
    {
        private int idstaffOld;
        private int typeOld;
        public UpdateStaffManager()
        {
            InitializeComponent();
        }
        ManagerStaff mStaff = new ManagerStaff();
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
        private void fillDVGStaff()
        {
            DVGStaff.ReadOnly = true;
            //DataGridViewImageColumn picol = new DataGridViewImageColumn();
            DVGStaff.RowTemplate.Height = 80;
            //DVGStaff.DataSource = mStaff.getAllStaff();
            ;

            
            
            //Bitmap imageB = new Bitmap(pic);
            //string path;
            //if (type == 1)
            //{
            //    path = Dir + "\\Image\\KhuonMat\\NhanVien\\NomalStaff\\" + idStaff;
            //}
            //else if (type == 2)
            //{
            //    path = Dir + "\\Image\\KhuonMat\\NhanVien\\OfficeStaff\\" + idStaff;
            //}
            //else
            //{
            //    path = Dir + "\\Image\\KhuonMat\\NhanVien\\Manager\\" + idStaff;
            //}
            DVGStaff.DataSource = mStaff.getAllStaff();
            
            
            //picol = (DataGridViewImageColumn)DVGStaff.Columns["Picture"];
            //picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DVGStaff.AllowUserToAddRows = false;
        }

        private void UpdateStaffManager_Load(object sender, EventArgs e)
        {
            fillDVGStaff();
        }

        private void DVGStaff_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text =DVGStaff.CurrentRow.Cells["Id"].Value.ToString();
            idstaffOld = Convert.ToInt32(txtID.Text);
            txtAccount.Text = DVGStaff.CurrentRow.Cells["Account"].Value.ToString();
            txtPassword.Text = DVGStaff.CurrentRow.Cells["Password"].Value.ToString();
            txtFullName.Text = DVGStaff.CurrentRow.Cells["Name"].Value.ToString();
            txtPhone.Text = DVGStaff.CurrentRow.Cells["Phone"].Value.ToString();
            string pathImageName;
            string workingDirectory = Environment.CurrentDirectory;
            string Dir = Directory.GetParent(workingDirectory).Parent.FullName;

            if (DVGStaff.CurrentRow.Cells["Position"].Value.ToString() == "Manager")
            {
                if (DVGStaff.CurrentRow.Cells["Picture"].Value != null)
                {
                    typeOld = 3;
                    pathImageName = DVGStaff.CurrentRow.Cells["Picture"].Value.ToString();
                    string path = Dir + "\\Image\\KhuonMat\\NhanVien\\Manager\\"  + pathImageName + ".Png";
                    PictureBoxImage.Image = Image.FromFile(path);
                }
                else
                {
                    PictureBoxImage.Image = null;
                }
                radioBtnManager.Checked = true;
            }
                
            if (DVGStaff.CurrentRow.Cells["Position"].Value.ToString() == "Staff")
            {
                if (DVGStaff.CurrentRow.Cells["Picture"].Value != null)
                {
                    typeOld = 1;
                    pathImageName = DVGStaff.CurrentRow.Cells["Picture"].Value.ToString();
                    string path = Dir + "\\Image\\KhuonMat\\NhanVien\\NomalStaff\\" + pathImageName + ".Png";
                    PictureBoxImage.Image = Image.FromFile(path);

                }
                else
                {
                    PictureBoxImage.Image = null;
                }
                radioBtnCaretaker.Checked = true;
            }
                
            if (DVGStaff.CurrentRow.Cells["Position"].Value.ToString() == "OfficeStaff")
            {
                if (DVGStaff.CurrentRow.Cells["Picture"].Value != null)
                {
                    typeOld = 2;
                    pathImageName = DVGStaff.CurrentRow.Cells["Picture"].Value.ToString();
                    string path = Dir + "\\Image\\KhuonMat\\NhanVien\\OfficeStaff\\" + pathImageName + ".Png";
                    PictureBoxImage.Image = Image.FromFile(path);
                }
                else
                {
                    PictureBoxImage.Image = null;
                }
                radioBtnOfficer.Checked = true;
            }
                
            txtEmail.Text = DVGStaff.CurrentRow.Cells["Email"].Value.ToString();


        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtID.Text))
                {
                    int idStaff = Convert.ToInt32(txtID.Text);
                    if (idStaff > 0)
                    {
                        if (!mStaff.checkIDStaff(idStaff))
                        {

                            if (mStaff.checkAccount(txtAccount.Text, idStaff))
                            {
                                if (mStaff.checkEmail(txtEmail.Text, idStaff))
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
                                    if (mStaff.UpdateStaff(idStaff,idstaffOld,typeOld, account, pass, fname, email, phone, adddate, type, pic))
                                    {
                                        MessageBox.Show("Successfully added employees", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Update employee failed", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Email already exists", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }
                            else
                            {
                                MessageBox.Show("Employee account already exists", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Employee code not already exists", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee ID must be a positive number greater than 0", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Employee code must be number", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter full information", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool verif()
        {
            if ((txtID.Text.Trim() == "") ||
                (txtAccount.Text.Trim() == "") ||
                (txtPassword.Text.Trim() == "") ||
                (txtFullName.Text.Trim() == "") ||
                (PictureBoxImage.Image == null) ||
                txtPhone.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "")
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
        private int checkTypeStaff()
        {
            int type = 1;
            if (radioBtnOfficer.Checked)
                type = 2;
            else if (radioBtnManager.Checked)
            {
                type = 3;
            }
            return type;
        }

        private void PictureBoxImage_Click(object sender, EventArgs e)
        {

        }
    }
}
