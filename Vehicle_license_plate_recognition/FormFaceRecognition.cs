using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.Controller;
using Vehicle_license_plate_recognition.Controller.Manager;

namespace Vehicle_license_plate_recognition
{
    public partial class FormFaceRecognition : Form
    {
        Setting setting = new Setting();
        public FormFaceRecognition()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            FormFaceRecognition a = new FormFaceRecognition();
            this.Visible = false;
            a.ShowDialog();
            this.Visible = true;
        }

        private void button_attendance_Click(object sender, EventArgs e)
        {
            String server_path;
            // Goi len server va tra ve ket qua
            String server_ip = "192.168.1.166";

            server_path = "http://" + server_ip + ":8000/recognitionNV";
            try
            {
                //Convert image to B64
                String B64 = setting.ConvertImageToBase64String(pictureBox_recognize.Image);
                String retStr = setting.sendPOST(server_path, B64);
                richTextBox_licenseplates.Text = retStr;

                //Diem Danh 


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                
        }

        private void pictureBox_camera_Click(object sender, EventArgs e)
        {

        }
        ManagerStaff manager = new ManagerStaff();
        private void btnConfim_Click(object sender, EventArgs e)
        {
            if(richTextBox_licenseplates.Text!= "" && richTextBox_licenseplates.Text != "")
            {
                int id =Convert.ToInt32( richTextBox_licenseplates.Text);
                if (manager.checkIDStaff(id))
                {
                    //Kiem tra ngày tháng điểm danh
                    MessageBox.Show("Successful attendance");
                }
            }
        }
    }
}
