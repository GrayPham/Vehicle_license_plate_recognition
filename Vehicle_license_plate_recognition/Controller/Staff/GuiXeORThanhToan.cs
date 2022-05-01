using System;
using System.Collections.Generic;
using System.Data;
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
        public bool PostSentCar()
        {
            return true;
        }
        public List<Parking> GetAllParkActive(int TypeVehicle)
        {
            List<Parking> getPark = nvbll.GetAllParkActive(TypeVehicle);
            return getPark;
        }

    }
}
