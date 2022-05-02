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
                                        join capa in db.Capacities on park.Name equals capa.IdPark
                                        where capa.MaxCapacity > capa.CurrentCapacity
                                        && capa.IdVehicleType == TypeVehicle
                                        && park.isDelete ==false
                                        select park).ToList<Parking>();
 
            return parkActive;
        }

        public void PostSentCar(DateTime deliveryTime, string licensePlates, string idPark, int typeVehicle, string path, string place)
        {
            NguoiGui nguoiGui = new NguoiGui();
            nguoiGui.IdVehicleType = typeVehicle;
            nguoiGui.DeliveryTime = deliveryTime;
            nguoiGui.LicensePlates = licensePlates;
            nguoiGui.ImagePath = path;
            nguoiGui.IdPlacePark = idPark;
            nguoiGui.PlaceID = place;
            db.NguoiGuis.Add(nguoiGui);
            db.SaveChanges();


        }
        public void PostReturnVehicle(string licensePlates, DateTime returnTime)
        {
            NguoiGui user = db.NguoiGuis.Where(x => x.LicensePlates == licensePlates).FirstOrDefault();
            user.ReturnTime = returnTime;
            db.SaveChanges();
        }
        internal DateTime GetDeleveryTime(string licensePlate)
        {
            List<NguoiGui> first = db.NguoiGuis.Where(user => user.LicensePlates == licensePlate).ToList<NguoiGui>();
            DateTime deleveryTime = (DateTime)first[0].DeliveryTime;
            return deleveryTime;
        }

        internal double GetPriceofVehicle(int typeVehicle)
        {
            var vehicle = db.TypeVehicles.Where(vehi => vehi.IdVehicle == typeVehicle).FirstOrDefault();
            return (double)vehicle.UnitPrice;
        }

        internal void PostPayment(string idPayment, decimal price, int typeVehicle, int idStaff, DateTime chargeTime, string licenseplates)
        {
            ThanhToan tt = new ThanhToan();
            tt.IdPayment = idPayment;
            tt.Price = price;
            tt.IdTVehicle = typeVehicle;
            tt.IdStaff = idStaff;
            tt.ChargeTime = chargeTime;
            tt.LicensePlates = licenseplates;
            db.ThanhToans.Add(tt);
            db.SaveChanges();
        }
    }
}
