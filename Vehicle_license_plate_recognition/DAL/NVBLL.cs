using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.BLL
{
    
    public class NVBLL: QuanLiNhaXe
    {
        
        

        public List<NguoiGui> getAllLiPlate(string bienso, DateTime time)
        {
            List<NguoiGui> liPlates = (from LicensePlates in db.NguoiGuis where LicensePlates.LicensePlates == bienso  && LicensePlates.ReturnTime == null select LicensePlates).ToList();
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
            nguoiGui.IdPark = idPark;
            nguoiGui.PlaceID = place;
            db.NguoiGuis.Add(nguoiGui);
            db.SaveChanges();


        }
        
        internal DateTime GetDeleveryTime(string licensePlate)
        {
            List<NguoiGui> first = db.NguoiGuis.Where(user => user.LicensePlates == licensePlate && user.ReturnTime== null).ToList<NguoiGui>();
            DateTime deleveryTime = (DateTime)first[0].DeliveryTime;
            return deleveryTime;
        }

        internal double GetPriceofVehicle(int typeVehicle)
        {
            var vehicle = db.TypeVehicles.Where(vehi => vehi.IdVehicle == typeVehicle).FirstOrDefault();
            return (double)vehicle.UnitPrice;
        }

        internal bool PostPayment(string idPayment, decimal price, int typeVehicle, int idStaff, DateTime chargeTime, string licenseplates)
        {
            try
            {

                ThanhToan tt = new ThanhToan();
                tt.IdPayment = idPayment;
                tt.Price = price;
                tt.IdTVehicle = typeVehicle;
                tt.IdStaff = idStaff;

                db.ThanhToans.Add(tt);





                db.SaveChanges();


                
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
            
        }
        // All Bill kể từ thời điêm thực hiện công việc / NGày làm việc etc...
        internal Object GetAllBillVehicle(DateTime timeWork)
        {

            var bill = (from tt in db.ThanhToans
                       join ng in db.NguoiGuis on tt.IdPayment equals ng.IdPayment
                       where (ng.ReturnTime > timeWork)
                       orderby ng.ReturnTime descending
                       select new
                       {
                           tt.IdStaff, ng.ReturnTime, tt.Price
                       }).ToList();


            

            return bill;
        }

        internal void PostReturnVel(string licenseplates )
        {
            

            var place = (from placeP in db.PlaceParks
                         join nguoiGui in db.NguoiGuis
                         on placeP.Id equals nguoiGui.PlaceID
                         where nguoiGui.LicensePlates == licenseplates && nguoiGui.ReturnTime == null
                         select placeP).First();
            place.Status = true;



            db.SaveChanges();
        }

        internal void returnTime(string licenseplates, DateTime chargeTime , string idPayment)
        {
            var ngGui = db.NguoiGuis.Where(x => x.LicensePlates == licenseplates && x.ReturnTime == null).FirstOrDefault();
            db.Entry(ngGui).State = EntityState.Modified;
            ngGui.ReturnTime = chargeTime;
            ngGui.IdPayment  = idPayment;
            
            db.SaveChanges();
            
           





        }
    }
}
