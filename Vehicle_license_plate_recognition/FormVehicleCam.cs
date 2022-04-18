using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add thư viện để kết nối với camera
using AForge.Video;
using AForge.Video.DirectShow;

namespace Vehicle_license_plate_recognition
{
    public partial class FormVehicleCam : Form
    {
        //tạo 2 biến xem hiện tại có bao nhiêu camera kết nối với máy tính của ta
        private FilterInfoCollection cam;
        //camera cụ thể ta chọn để chup
        private VideoCaptureDevice video;
        public FormVehicleCam()
        {
            InitializeComponent();

            cam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //đẩy camera đang kết nối với máy của chúng ta vào combobox cho ta chọn
            foreach (FilterInfo info in cam)
            {
                comboBox1.Items.Add(info.Name);
            }
            //mặc định là ta sẽ chọn camera đầu tiên trong combobox
            comboBox1.SelectedIndex = 0;
        }
        //phương thức kiểm tra cam đã mở chưa
        private void btn_cam_Click(object sender, EventArgs e)
        {
            //lấy camera tại vị trí combobox
            video = new VideoCaptureDevice(cam[comboBox1.SelectedIndex].MonikerString);
            //camera này phải tạo 1 cái frame khác để chụp ảnh
            video.NewFrame += Video_NewFrame;
            video.Start();
        }
        //chụp ảnh
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //ảnh thu được từ camera
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            //show ảnh lên
            pictureBox_camera.Image = image;
        }
        //phương thức tắt camera
        private void btn_offcam_Click(object sender, EventArgs e)
        {
            if (video != null && video.IsRunning)
            {
                video.Stop();
                pictureBox_camera.Image = null;
            }
            else
                MessageBox.Show("Please turn on camera!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //cam đang mở tắt nó đi tránh nó chạy ngầm 
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (video != null && video.IsRunning)
            {
                video.Stop();
            }
        }
        //địa chỉ lưu ảnh
        private void btn_cap_Click(object sender, EventArgs e)
        {
            if (video != null && video.IsRunning)
            {
                //chỗ lưu ảnh đã chụp
                video.Stop();
                saveFileDialog1.InitialDirectory = "C:\\Users\\admin\\OneDrive\\Hình ảnh\\Capture winform";
                saveFileDialog1.FileName = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_camera.Image.Save(saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Please turn on camera!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void FormVehicleCam_Load(object sender, EventArgs e)
        {
            //mở full màn hình
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //TopMost = true;
            if (pictureBox_camera.Image == null)
            {
                btn_Save.Enabled = false;
                btn_charge.Enabled = false;
                btn_contract.Enabled = false;
                btn_Check.Enabled = false;
            }

        }


        private void button_done_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {

        }

        private void btn_contract_Click(object sender, EventArgs e)
        {

        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
           
        }
    }
}
