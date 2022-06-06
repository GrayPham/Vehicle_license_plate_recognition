using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Hỗ trợ gửi mail
using System.Net;
using System.Net.Mail;
using Vehicle_license_plate_recognition.Model;
// Hỗ trợ kiểm tra chuỗi nhập đúng định dạng
using System.Text.RegularExpressions;

namespace Vehicle_license_plate_recognition
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
            textBox_email.ForeColor = Color.LightGray;
            textBox_email.Text = "example(123)@gmail.com";
            this.textBox_email.Leave += new System.EventHandler(this.textBox_email_Leave);
            this.textBox_email.Enter += new System.EventHandler(this.textBox_email_Enter);

            textBox_zipcode.ForeColor = Color.LightGray;
            textBox_zipcode.Text = "Please enter code";
            this.textBox_zipcode.Leave += new System.EventHandler(this.textBox_zipcode_Leave);
            this.textBox_zipcode.Enter += new System.EventHandler(this.textBox_zipcode_Enter);

            label_syntax.Visible = false;
            this.textBox_email.Click += new System.EventHandler(this.textBox_email_Click);

            this.pictureBox_close.MouseEnter += new System.EventHandler(this.pictureBox_close_MouseEnter);
            this.pictureBox_close.MouseLeave += new System.EventHandler(this.pictureBox_close_MouseLeave);
        }

        string randomCode;
        public static string to;

        // Nhận mã từ email
        private void button_getcode_Click(object sender, EventArgs e)
        {
            if(textBox_email.Text == "example(123)@gmail.com")
            {
                label_syntax.Text = "Empty email!!!";
                label_syntax.Visible = true;
                //return;
            }
            if (IsValidEmail(textBox_email.Text) == false)
            {
                label_syntax.Text = "Syntax Error";
                label_syntax.Visible = true;
                return;
            }
            else if(textBox_email.Text != "example(123)@gmail.com")
            {
                QuanLiNhaXeEntities test = new QuanLiNhaXeEntities();
                var q = test.NVs.Where(user => user.Email == textBox_email.Text).FirstOrDefault();


                if (q != null)
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();


                    MailMessage message = new MailMessage();
                    to = (textBox_email.Text).ToString();
                    from = "20110431@student.hcmute.edu.vn";
                    pass = "26112001";
                    messageBody = "Your reset code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Your code: ";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25); //SMTP là giao thức tiêu chuẩn để gửi email
                    smtp.EnableSsl = true;  //là 1 chứng chỉ bảo mật 
                                            //smtp.Port = 25; //cổng nhận gmail
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //thông qua mạng
                    smtp.Credentials = new NetworkCredential(from, pass); //hỗ trợ đăng nhập cho bạn
                    smtp.Send(message);
                    MessageBox.Show("Code send successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Email is not exit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        // Xác nhận mã
        private void button_verifycode_Click(object sender, EventArgs e)
        {
            if (textBox_zipcode.Text == "Please enter code")
            {
                MessageBox.Show("Please provide your zip code!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (randomCode == (textBox_zipcode.Text).ToString())
            {
                to = textBox_email.Text;
                FormResetPassword rp = new FormResetPassword();
                this.Visible = false; //ẩn thôi chứ khum tắt
                rp.ShowDialog(); //show chạy song song khác với showDialog dừng chạy form hiện tại rồi mở form mà mình muốn mở
                this.Visible = true; //mở lại
            }
            else
            {
                MessageBox.Show("Failed code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện hiển thị chữ trong textbox email
        private void textBox_email_Enter(object sender, EventArgs e)
        {
            if (textBox_email.Text == "example(123)@gmail.com")
            {
                textBox_email.Text = "";
                textBox_email.ForeColor = Color.Black;
            }
        }
        private void textBox_email_Leave(object sender, EventArgs e)
        {
            if (textBox_email.Text == "")
            {
                textBox_email.Text = "example(123)@gmail.com";
                textBox_email.ForeColor = Color.Gray;
            }
        }

        // Sự kiện hiển thị chữ trong textbox zipcode
        private void textBox_zipcode_Enter(object sender, EventArgs e)
        {
            if (textBox_zipcode.Text == "Please enter code")
            {
                textBox_zipcode.Text = "";
                textBox_zipcode.ForeColor = Color.Black;
            }
        }
        private void textBox_zipcode_Leave(object sender, EventArgs e)
        {
            if (textBox_zipcode.Text == "")
            {
                textBox_zipcode.Text = "Please enter code";
                textBox_zipcode.ForeColor = Color.Gray;
            }
        }

        // Sự kiện ẩn chữ trong text box email
        private void textBox_email_Click(object sender, EventArgs e)
        {
            label_syntax.Visible = false;

        }

        // Đóng form
        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Đổi màu picturebox_close
        private void pictureBox_close_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_close.BackColor = Color.White;
        }
        private void pictureBox_close_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_close.BackColor = Color.LightSteelBlue;
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
    }
}
