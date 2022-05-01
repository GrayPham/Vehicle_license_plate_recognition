using System;
using System.Collections.Generic;
using System.Data;
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
        public List<NguoiGui> getAllLiPlate(string bienso)
        {
            List<NguoiGui> liPlates = (from LicensePlates in db.NguoiGuis where LicensePlates.LicensePlates == bienso select LicensePlates).ToList();
            return liPlates;
        }

        internal List<Parking> GetAllParkActive(int TypeVehicle)
        {
            List<Parking> parkActive = (from park in db.Parkings
                                        join capa in db.Capacities on park.Id equals capa.IdPark
                                        where capa.MaxCapacity > capa.CurrentCapacity
                                        && capa.IdVehicle == TypeVehicle
                                        select park).ToList<Parking>();
 
            return parkActive;
        }
    }
}
