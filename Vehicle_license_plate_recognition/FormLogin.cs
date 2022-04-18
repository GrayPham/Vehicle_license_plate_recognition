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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        Color label_forgotcolor;
        Color label_accountcolor;

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
                if (q.isOfficeStaff == true)
                {
                    //MỞ FORM MENU SAU KHI DANG NHAP THANH CONG
                    FormMenu menuForm = new FormMenu();
                    this.Visible = false; //ẩn thôi chứ khum tắt
                    menuForm.ShowDialog();
                    this.Visible = true; //mở lại
                }
                if (q.isStaff == true)
                {
                    //MỞ FORM MENU SAU KHI DANG NHAP THANH CONG
                    FormStaff staffForm = new FormStaff();
                    this.Visible = false; //ẩn thôi chứ khum tắt
                    staffForm.ShowDialog();
                    this.Visible = true; //mở lại
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_forgot_MouseLeave(object sender, EventArgs e)
        {
            //label_forgot.ForeColor = Color.AliceBlue;
        }

        private void label_forgot_Click(object sender, EventArgs e)
        {
            //label_forgot.ForeColor = Color.AliceBlue;
            FormForgotPassword q = new FormForgotPassword();
              this.Visible = false;
              q.ShowDialog();
              this.Visible = true;

        }

        private void label_register_Click(object sender, EventArgs e)
        {
            FormRegister a = new FormRegister();
            this.Visible = false; //ẩn thôi chứ khum tắt
            a.ShowDialog(); //show chạy song song khác với showDialog dừng chạy form hiện tại rồi mở form mà mình muốn mở
            this.Visible = true; //mở lại
        }
    }
}
