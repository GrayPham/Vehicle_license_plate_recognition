using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//hỗ trợ gửi mail
using System.Net;
using System.Net.Mail;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
            textBox_email.ForeColor = Color.LightGray;
            textBox_email.Text = "example@gmail.com";
            this.textBox_email.Leave += new System.EventHandler(this.textBox_email_Leave);
            this.textBox_email.Enter += new System.EventHandler(this.textBox_email_Enter);

            textBox_zipcode.ForeColor = Color.LightGray;
            textBox_zipcode.Text = "Please enter code";
            this.textBox_zipcode.Leave += new System.EventHandler(this.textBox_zipcode_Leave);
            this.textBox_zipcode.Enter += new System.EventHandler(this.textBox_zipcode_Enter);
        }

        string randomCode;
        public static string to;
        private void button_getcode_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLiNhaXeEntities test = new QuanLiNhaXeEntities();
                var q = test.NVs.Where(user => user.Email == textBox_email.Text).FirstOrDefault();

                if (!(textBox_email.Text).EndsWith("@gmail.com"))
                {

                     MessageBox.Show("Syntax error", "Syntax", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return; 
                }
                if(!(textBox_email.Text).Equals(q))
                {
                    MessageBox.Show("Email is not exit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    

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
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_verifycode_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Wrong Code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_email_Enter(object sender, EventArgs e)
        {
            if (textBox_email.Text == "example@gmail.com")
            {
                textBox_email.Text = "";
                textBox_email.ForeColor = Color.Black;
            }
        }

        private void textBox_email_Leave(object sender, EventArgs e)
        {
            if (textBox_email.Text == "")
            {
                textBox_email.Text = "example@gmail.com";
                textBox_email.ForeColor = Color.Gray;
            }
        }

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
    }
}
