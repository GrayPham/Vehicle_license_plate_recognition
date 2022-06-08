using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.ComponentForm;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            // Hiển thị gợi í định dạng email đúng
            tbEmail.ForeColor = Color.LightGray;
            tbEmail.Text = "example(123)@gmail.com";
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);

            this.pictureBox_image.MouseEnter += new System.EventHandler(this.pictureBox_image_MouseEnter);
            this.pictureBox_image.MouseLeave += new System.EventHandler(this.pictureBox_image_MouseLeave);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_id.Text) || string.IsNullOrEmpty(textBox_fullname.Text) ||
               string.IsNullOrEmpty(textBox_account.Text) || string.IsNullOrEmpty(textBox_pass.Text) ||
               string.IsNullOrEmpty(textBox_phone.Text) || string.IsNullOrEmpty(tbEmail.Text) /*|| pictureBoxImage.Image == null*/
               || tbEmail.Text == "example(123)@gmail.com")
            {
                MessageBox.Show("Please fill all the fields!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check ma toan so hay khong
            else if (IsNumber(textBox_id.Text) == false)
            {
                MessageBox.Show("ID must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // acount toan ki tu
            else if (IsCharacter(textBox_account.Text) == false)
            {
                MessageBox.Show("Account must be characters and it has white space (or not)!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // fullname toan ki tu
            else if (IsCharacter(textBox_fullname.Text) == false)
            {
                MessageBox.Show("Full name must be characters and it has white space (or not)!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // Phone Toàn số
            else if (IsNumber(textBox_phone.Text) == false)
            {
                MessageBox.Show("Phone must be numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            // Phone number Xử lí đúng chuẩn
            else if (IsValidPhone(textBox_phone.Text) == false)
            {
                MessageBox.Show("Please enter 9 or 10 numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Email Xử lí đúng chuẩn
            else if (IsValidEmail(tbEmail.Text) == false)
            {
                MessageBox.Show("Email format error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLiNhaXeEntities test = new QuanLiNhaXeEntities();

            // NOTE: ĐỢI THẰNG HÙNG SỬA
            //MemoryStream pic = new MemoryStream();
            //pictureBoxImage.Image.Save(pic,pictureBoxImage.Image.RawFormat);
            try
            {
                // Tạo 1 NV
                NV q = new NV();
                int idStaff = Convert.ToInt32(textBox_id.Text);
                string acc = textBox_account.Text;
                string pass = textBox_pass.Text;
                string phone = textBox_phone.Text;
                string email = tbEmail.Text;
                string name = textBox_fullname.Text;
                var checkExist = test.NVs.Where(p => p.IdStaff == idStaff || p.Account == acc
                                                || p.Email == email || p.Phone == phone);
                if (checkExist.Count() == 0)
                {
                    q.IdStaff = idStaff;
                    q.Account = acc;
                    q.Password = pass;
                    q.HoVaTenNV = name;
                    q.Phone = phone;
                    q.Email = email;
                    test.NVs.Add(q);
                    test.SaveChanges();
                    MessageBox.Show("Wellcome " + textBox_account.Text + " to our service! ^.^", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Luu anh avata NV
                    MemoryStream pic = new MemoryStream();
                    pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);
                    string workingDirectory = Environment.CurrentDirectory;
                    string Dir = Directory.GetParent(workingDirectory).Parent.FullName;

                    Bitmap imageB = new Bitmap(pic);
                    string path;
                    path = Dir + "\\Image\\KhuonMat\\NhanVien\\Temp\\" + idStaff;

                        // Face recognition 
                    GetFaceIDStaff getFace = new GetFaceIDStaff();
                    getFace.lbIDStaff.Text = idStaff.ToString();
                    this.Hide();
                    getFace.ShowDialog();
                    this.Visible = true;

                }
                else
                {
                    MessageBox.Show("The information you entered already exists. Please check your ID Staff/ Account/ Email/ Phone Number/ Image) again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }    
            }
            catch (Exception)
            {
                MessageBox.Show("Registration failed. Please try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Ô nhập vào không được là kí tự, kí hiệu và khoảng trắng 
        public bool IsNumber(string pValue)
        {
            Regex isValidInput = new Regex(@"^[0-9]+$");
            if (!isValidInput.IsMatch(pValue))
            {
                return false;

            }
            return true;
        }
        // Ô nhập vào không được là số, kí hiệu
        public bool IsCharacter(string pValue)
        {
            Regex isValidInput = new Regex(@"^[a-zA-Z\s]+$");
            if (!isValidInput.IsMatch(pValue))
            {
                return false;

            }
            return true;
        }
        // Kiểm tra số nhập vào ko vượt quá 10 số
        public bool IsValidPhone(string phone)
        {
            Regex isValidInput = new Regex(@"^\d{9,10}$");
            if (!isValidInput.IsMatch(phone))
            {
                return false;

            }
            return true;
        }

        // Kiểm tra mail đúng chuẩn example123@gmail.com
        public bool IsValidEmail(string email)
        {
            Regex isValidInput = new Regex(@"^[a-zA-Z]*[0-9]*@gmail*\.com$");
            if (!isValidInput.IsMatch(email))
            {
                return false;

            }
            return true;
        }

        // Sự kiện hiển thị chữ trong textbox email
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "example(123)@gmail.com")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
            }
        }
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "example(123)@gmail.com";
                tbEmail.ForeColor = Color.Gray;
            }
        }

        private void pictureBox_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        // Sự kiện đổi màu pictureBox
        private void pictureBox_image_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_image.BackColor = Color.AliceBlue;
        }

        private void pictureBox_image_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_image.BackColor = Color.Transparent;



        private void pictureBox_image_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }

        }
    }
}
