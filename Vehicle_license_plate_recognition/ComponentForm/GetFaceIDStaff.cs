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

namespace Vehicle_license_plate_recognition.ComponentForm
{
    public partial class GetFaceIDStaff : Form
    {
        public GetFaceIDStaff()
        {
            InitializeComponent();
        }
        Setting setting = new Setting();
        private void btnStaff_Click(object sender, EventArgs e)
        {
            String server_ip = "192.168.1.166";
            string idstring = lbIDStaff.Text;
            string server_path = "http://" + server_ip + ":8000/captureImageNV?idstring=" + idstring;
            String retStrGet = setting.Get(server_path);

            lbInfor.Text = retStrGet;
            this.Close();
        }
    }
}
