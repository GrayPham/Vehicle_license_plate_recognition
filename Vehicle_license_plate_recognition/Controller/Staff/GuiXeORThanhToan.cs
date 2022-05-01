using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.BLL;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.Controller.Staff
{
    
    public class GuiXeORThanhToan
    {
        NVBLL nvbll = new NVBLL();
        private int xedap = 1;
        private int xemay = 2;
        private int xeOto = 3;
        public bool isParked(string bienso)
        {
            List<NguoiGui> sentCar = nvbll.getAllLiPlate(bienso);
            if(sentCar.Count > 0)
            {
                return true;
            }
            return false;
        }

        public List<Parking> GetAllParkActive(int TypeVehicle)
        {
            List<Parking> getPark = nvbll.GetAllParkActive(TypeVehicle);
            return getPark;
        }

        public bool PostSentCar(DateTime deliveryTime, string licensePlates,string IdPark, int typeVehicle, Image image)
        {
            //string Dir = System.IO.Directory.GetCurrentDirectory();
            // Get current working directory (..\bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            string Dir = Directory.GetParent(workingDirectory).Parent.FullName;
            
            if (typeVehicle == 3)
            {
                string filename = licensePlates;
                Bitmap imageB = new Bitmap(image);
                string path = Dir + "\\Image\\BienDai\\" + filename;
                imageB.Save(path +("." + ImageFormat.Png.ToString()));
                nvbll.PostSentCar(deliveryTime, licensePlates, IdPark, typeVehicle, path);
            }
            
            return true;
        }
    }
}
