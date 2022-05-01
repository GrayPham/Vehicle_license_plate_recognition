using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add thư viện để kết nối với camera
using AForge.Video;
using AForge.Video.DirectShow;
using Vehicle_license_plate_recognition.Controller;

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

                btn_parking.Enabled = true;
                btn_charge.Enabled = true;
                btn_Check.Enabled = true;
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

                btn_parking.Enabled = false;
                btn_charge.Enabled = false;
                btn_Check.Enabled = false;

             FormStaff a = new FormStaff();
             this.Visible = false;
             a.ShowDialog();
            this.Visible = true;
            
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
                btn_parking.Enabled = false;
                btn_charge.Enabled = false;
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
            
            // Goi len server va tra ve ket qua
            String server_ip = "192.168.1.21";
            String server_path = "http://" + server_ip + ":8000/detect";
            try
            {
                // Convert image to B64
                String B64 = ConvertImageToBase64String(pictureBox_recognize.Image);
                String retStr = sendPOST(server_path, B64);
                richTextBox_licenseplates.Text = retStr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
            

            
        }

        private void btn_contract_Click(object sender, EventArgs e)
        {

        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
           
        }
        public string sendGet(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        // Ham chuyen Image thanh Base 64
        public static string ConvertImageToBase64String(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        // Ham convert B64 de gui len server
        private String EscapeData(String B64)
        {
            int B64_length = B64.Length;
            if (B64_length <= 32000)
            {
                return Uri.EscapeDataString(B64);
            }


            int idx = 0;
            StringBuilder builder = new StringBuilder();
            String substr = B64.Substring(idx, 32000);
            while (idx < B64_length)
            {
                builder.Append(Uri.EscapeDataString(substr));
                idx += 32000;

                if (idx < B64_length)
                {

                    substr = B64.Substring(idx, Math.Min(32000, B64_length - idx));
                }

            }
            return builder.ToString();

        }
        // Ham goi HTTP POST len server de detect
        private String sendPOST(String url, String B64)
        {
            try
            {

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 5000;
                var postData = "image=" + EscapeData(B64);

                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;
            }
            catch (Exception ex)
            {
                return "Exception" + ex.ToString();
            }
        }
    }
}
