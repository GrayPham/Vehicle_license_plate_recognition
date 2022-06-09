using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.ComponentForm;
using Vehicle_license_plate_recognition.Controller.Login;
using Vehicle_license_plate_recognition.Model;
using Vehicle_license_plate_recognition.OfficeStaff;
//using Vehicle_license_plate_recognition.Manager;
namespace Vehicle_license_plate_recognition
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            textBox_username.ForeColor = Color.LightGray;
            textBox_username.Text = "Enter your Username";
            this.textBox_username.Leave += new System.EventHandler(this.textBox_username_Leave);
            this.textBox_username.Enter += new System.EventHandler(this.textBox_username_Enter);

            this.label_forgot.MouseEnter += new System.EventHandler(this.label_forgot_MouseEnter);
            this.label_forgot.MouseLeave += new System.EventHandler(this.label_forgot_MouseLeave);

            this.label_register.MouseEnter += new System.EventHandler(this.label_register_MouseEnter);
            this.label_register.MouseLeave += new System.EventHandler(this.label_register_MouseLeave);

        }

        // Sự kiện hiển thị chữ trong textbox username
        private void textBox_username_Enter(object sender, EventArgs e)
        {
            if (textBox_username.Text == "Enter your Username")
            {
                textBox_username.Text = "";
                textBox_username.ForeColor = Color.Black;
            }
        }
        private void textBox_username_Leave(object sender, EventArgs e)
        {
            if (textBox_username.Text == "")
            {
                textBox_username.Text = "Enter your Username";
                textBox_username.ForeColor = Color.Gray;
            }
        }

        // Sự kiện đổi màu label forgot
        private void label_forgot_MouseEnter(object sender, EventArgs e)
        {
            label_forgot.ForeColor = Color.Blue;
        }
        private void label_forgot_MouseLeave(object sender, EventArgs e)
        {
            label_forgot.ForeColor = Color.Black;
        }

        // Sự kiện đổi màu label register
        private void label_register_MouseEnter(object sender, EventArgs e)
        {
            label_register.ForeColor = Color.Blue;
        }
        private void label_register_MouseLeave(object sender, EventArgs e)
        {
            label_register.ForeColor = Color.Black;
        }

        //TẠO DATABASE
        QuanLiNhaXeEntities test = new QuanLiNhaXeEntities();
        private void button_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text) || string.IsNullOrEmpty(textBox_pass.Text))
            {
                MessageBox.Show("Please provide your Username and Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_username.Select();
                return;
            }
            try
            {
                var q = test.NVs.Where(user => user.Account == textBox_username.Text && user.Password == textBox_pass.Text).FirstOrDefault();
                //var q = (from p in test
                //             where p.username == textbox_username.text && p.password == textbox_pass.text select p).first();
                if(q != null) {
                    GlobalData.NameUser = q.HoVaTenNV;
                    GlobalData.SetIDStaff(q.IdStaff);
                    GlobalData.setImagePath(q.ImagePath);
                    int type = q.isManage == true ? 3 : q.isOfficeStaff == true ? 2 : 1;
                    GlobalData.SetTypeStaff(type);
                    if (q.LayOff == null)
                    {
                        MessageBox.Show("You need to activate your account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetFaceIDStaff getFace = new GetFaceIDStaff();
                        getFace.lbIDStaff.Text = q.IdStaff.ToString();
                        this.Hide();
                        getFace.ShowDialog();
                        this.Visible = true;
                    }
                    if (q.isOfficeStaff == true && q != null)
                    {
                        //MỞ FORM MENU SAU KHI DANG NHAP THANH CONG
                        OfficeStaffMainForm menuForm = new OfficeStaffMainForm();
                        this.Visible = false; //ẩn thôi chứ khum tắt
                        menuForm.ShowDialog();
                        this.Visible = true; //mở lại
                    }
                    if (q.isStaff == true && q != null)
                    {

                        //MỞ FORM MENU SAU KHI DANG NHAP THANH CONG
                        FormStaff staffForm = new FormStaff();
                        staffForm.txtIDStaff.Text = q.IdStaff.ToString();
                        this.Visible = false; //ẩn thôi chứ khum tắt
                        staffForm.ShowDialog();
                        this.Visible = true; //mở lại
                    }
                    if (q.isManage == true && q != null)
                    {
                        //MỞ FORM MENU SAU KHI DANG NHAP THANH CONG
                        FormManager managerForm = new FormManager();
                        this.Visible = false; //ẩn thôi chứ khum tắt
                        managerForm.ShowDialog();
                        this.Visible = true; //mở lại
                    }
                }
                else
                {
                    MessageBox.Show("Login error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                



            }
            //NOTE: "Please check your username and password again!"
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_username.Select();
                return;
            }
        }

        // Đóng form
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Mở form forgot
        private void label_forgot_Click(object sender, EventArgs e)
        {
            //label_forgot.ForeColor = Color.AliceBlue;
            FormForgotPassword q = new FormForgotPassword();
              this.Visible = false;
              q.ShowDialog();
              this.Visible = true;

        }

        // Mở form register
        private void label_register_Click(object sender, EventArgs e)
        {
            FormRegister a = new FormRegister();
            this.Visible = false; //ẩn thôi chứ khum tắt
            a.ShowDialog(); //show chạy song song khác với showDialog dừng chạy form hiện tại rồi mở form mà mình muốn mở
            this.Visible = true; //mở lại
        }

    }
}
