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
using Vehicle_license_plate_recognition.Controller.Staff;

namespace Vehicle_license_plate_recognition
{
    
    public partial class FormVehicleCam : Form
    {
        //tạo 2 biến xem hiện tại có bao nhiêu camera kết nối với máy tính của ta
        private FilterInfoCollection cam;
        //camera cụ thể ta chọn để chup
        private VideoCaptureDevice video;
        GuiXeORThanhToan nv = new GuiXeORThanhToan();
        DateTime timeWork;
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
            {
                MessageBox.Show("Camera hien tai khong bat!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            btn_parking.Enabled = false;
            btn_charge.Enabled = false;
            btn_Check.Enabled = false;



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
                
                if (pictureBox_camera.Image != null)
                {
                    pictureBox_recognize.Image = pictureBox_camera.Image;
                }
                video.Start();
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
            timeWork =DateTime.Now;
            timerSysterm.Start();
            if (pictureBox_camera.Image == null)
            {
                btn_parking.Enabled = false;
                btn_charge.Enabled = false;
                btn_Check.Enabled = true;
            }


            fillCombo();
            fillDVGThanhToan();
            //comboBox_Park.SelectedValue = "Id";
        }
        public void fillCombo(int index = 0)
        {
            int TypeVehicle =loaixe();
            comboBox_Park.DisplayMember = "Name";
            comboBox_Park.ValueMember = "Name";
            comboBox_Park.DataSource = nv.GetAllParkActive(TypeVehicle);

            comboBox1.SelectedIndex = index;
        }
        public int loaixe()
        {
            int loaixe;
            if (radioButton_car.Checked)
            {
                loaixe = 3;
            }
            else if (radioButton_motorbike.Checked)
            {
                loaixe = 2;
            }
            else
            {
                loaixe = 1;
            }
            return loaixe; 
        }
        private void button_done_Click(object sender, EventArgs e)
        {
            timerSysterm.Stop();
            if (video != null && video.IsRunning)
            {
                video.Stop();
                pictureBox_camera.Image = null;
            }
            this.Close();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            lbLoaiHinh.Text = "";
            // Goi len server va tra ve ket qua
            String server_ip = "192.168.1.3";
            String server_path = "http://" + server_ip + ":8000/detect2line";
            int IdStaff = Convert.ToInt32( txtIdStaff.Text);
            int TypeVehicle = loaixe();
            try
            {
                //Convert image to B64
                String B64 = ConvertImageToBase64String(pictureBox_recognize.Image);
                String retStr = sendPOST(server_path, B64);
                richTextBox_licenseplates.Text = retStr;


                //TEst
                //String retStr = richTextBox_licenseplates.Text;
                if (retStr.Count() <15)
                {
                    if (retStr != "" )
                    {
                        if (nv.isParked(retStr) == true)
                        {

                            btn_parking.Enabled = false;
                            DateTime ReturnTime = dateTimePickerSystem.Value;
                            double Price = nv.CalculateParking(richTextBox_licenseplates.Text, TypeVehicle, IdStaff, ReturnTime);
                            lbLoaiHinh.Text = "Tinh Tien Xe: " + retStr;
                            txtPrice.Text = Price.ToString();
                            btn_charge.Enabled = true;

                        }
                        
                        else
                        {
                            lbLoaiHinh.Text = "Gui Xe Bien So: " + retStr;
                            btn_charge.Enabled = false;
                            btn_parking.Enabled = true;
                        }
                    }
                    else if(TypeVehicle == 1)
                    {
                        // Hoàn thiện
                        lbLoaiHinh.Text = "Nhan dien khuon mat";
                    }
                    else
                        lbLoaiHinh.Text = "No license plate";
                }
                else
                {
                    lbLoaiHinh.Text = "Anh Khong nhan dien duoc";
                }    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }

        }



        private void btn_charge_Click(object sender, EventArgs e)
        {
            DateTime ChargeTime = DateTime.Now;
            int TypeVehicle = loaixe();
            int IdStaff = Convert.ToInt32( txtIdStaff.Text);
            string licenseplates= richTextBox_licenseplates.Text;
            decimal price =Convert.ToDecimal( txtPrice.Text) ;
            
            if(nv.PostThanhToan(TypeVehicle, price,IdStaff, ChargeTime, licenseplates) == true)
            {
                txtPrice.Text = "";
                fillDVGThanhToan();
            }
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
        // Thiếu cung cấp chỗ đỗ xe cho xe
        private void btn_parking_Click(object sender, EventArgs e)
        {

            int TypeVehicle = loaixe();
            DateTime DeliveryTime = dateTimePickerSystem.Value;
            string LicensePlates = richTextBox_licenseplates.Text;
            Image image = pictureBox_recognize.Image;
            string IdPark = comboBox_Park.SelectedValue.ToString();
            string place = nv.PostSentCar(DeliveryTime, LicensePlates, IdPark, TypeVehicle, image);
            if (place != null)
            {
                richTextBox_licenseplates.Text = "";
                pictureBox_recognize.Image = null;
                txtPlacePark.Text = place;
            }
            else
            {
                MessageBox.Show("Error Post Car");
            }

            
            

        }

        private void radioButton_motorbike_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_motorbike.Checked)
            {
                fillCombo();
                richTextBox_licenseplates.Enabled = true;
            }
        }

        private void radioButton_bicycle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bicycle.Checked)
            {
                fillCombo();
                richTextBox_licenseplates.Enabled = false;
            }
        }

        private void radioButton_car_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_car.Checked)
            {
                fillCombo();
                richTextBox_licenseplates.Enabled = true;
            }
        }

        private void timerSysterm_Tick(object sender, EventArgs e)
        {
            dateTimePickerSystem.Value = DateTime.Now;
        }
        // All Bill kể từ thời điêm thực hiện công việc / NGày làm việc etc...
        private void fillDVGThanhToan()
        {
            DGVThanhToan.DataSource = nv.GetAllBillVehicle(timeWork);
        }
    }
}
