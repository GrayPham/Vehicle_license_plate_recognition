using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.BLL
{
    
    public class NVBLL: QuanLiNhaXe
    {
        
        public void AddGuiXe(NguoiGui nguoiGui)
        {
            db.NguoiGuis.Add(nguoiGui);
            db.SaveChanges();
            
        }
    }
}
