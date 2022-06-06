using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.BLL
{
    internal class PlaceParkingDAO : QuanLiNhaXe
    {
        internal string GetPlaceVehicle(int typeVehicle, string idPark)
        {
            var place = db.PlaceParks.Where(p => p.IdPark == idPark && p.IdVehicleType == typeVehicle && p.Status == true).FirstOrDefault();
            place.Status = false;
            db.SaveChanges();
            return place != null ? place.Id : null;
        }

        
        // Cần chỉnh sửa lại
        internal void GenerateParkDAO(string namePark, int maxMotor, int maxBicycle, int maxCar, List<string> placeMotorLisr, List<string> placeCarLisr, List<string> placeBicycleLisr)
        {
            Parking parking = new Parking();
            parking.Name = namePark;
            parking.isDelete = false;
            db.Parkings.Add(parking);
            db.SaveChanges();
            // cap Car
            AddCapacity(3, maxCar, namePark);
            foreach (string item in placeCarLisr)
            {
                AddPlace(3, item, namePark);
            }

            // cap Moto
            AddCapacity(2, maxMotor, namePark);
            foreach (string item in placeMotorLisr)
            {
                AddPlace(2, item, namePark);
            }
            // cap Moto
            AddCapacity(1, maxBicycle, namePark);
            foreach (string item in placeBicycleLisr)
            {
                AddPlace(1, item, namePark);
            }
            
        }

        internal void DeletePark(string idPark)
        {
            var placeParkList = db.PlaceParks.Where(p => p.IdPark == idPark).ToList<PlacePark>();
            foreach (var place in placeParkList)
            {
                db.PlaceParks.Remove(place);
            }
            List<Capacity> listCap = db.Capacities.Where(cap => cap.IdPark == idPark)
                .ToList<Capacity>();
            foreach (var capacity in listCap)
            {
                db.Capacities.Remove(capacity);
            }
            var park = db.Parkings.Where(p => p.Name == idPark).FirstOrDefault();
            db.Parkings.Remove(park);
            db.SaveChanges();
        }

        internal void OpenParkDTO(string idPark)
        {
            var parkDTO = (from p in db.Parkings
                           where p.Name == idPark
                           select p).FirstOrDefault();
            parkDTO.isDelete = true;
            parkDTO.DeleteDate = null;
            db.SaveChanges();
        }





        // Ham tra ve ma tran 2 2 
        internal List<Capacity> getCapOfPark(string idPark)
        {
            List<Capacity> listCap = db.Capacities.Where(cap => cap.IdPark == idPark).OrderBy(cap => cap.IdVehicleType).ToList<Capacity>();
            return listCap;
        }

        internal void UpdateParkDAO(string oldNamePark, string namePark, int maxMotor, int maxBicycle, int maxCar, List<string> placeMotorLisr, List<string> placeCarLisr, List<string> placeBicycleLisr)
        {

            Parking parking = db.Parkings.Where(park => park.Name == oldNamePark).FirstOrDefault();
            
            parking.Name = namePark;
            
            var placeParkList = db.PlaceParks.Where(p => p.IdPark ==oldNamePark).ToList<PlacePark>();
            foreach (var place in placeParkList)
            {
                db.PlaceParks.Remove(place);
            }
            // cap Car
            UpdateCapacity(3, maxCar, oldNamePark, namePark);
            foreach (string item in placeCarLisr)
            {
                AddPlace(3, item, namePark);
            }

            // cap Moto
            UpdateCapacity(2, maxMotor, oldNamePark, namePark);
            foreach (string item in placeMotorLisr)
            {
                AddPlace(2, item, namePark);
            }
            // cap Moto
            UpdateCapacity(1, maxBicycle, oldNamePark, namePark);
            foreach (string item in placeBicycleLisr)
            {
                AddPlace(1, item, namePark);
            }
            db.SaveChanges();
        }



        private void UpdateCapacity(int type, int maxCar, string oldNamePark, string namePark)
        {
            Capacity capa = db.Capacities.Where(cap => cap.IdVehicleType == type && cap.IdPark == oldNamePark).FirstOrDefault();
            capa.IdPark = namePark;
            capa.MaxCapacity = maxCar;

        }

        internal object GetAllPark()
        {
            var park = (from place in db.Parkings
                                         
                                         select new
                                         {
                                             Name = place.Name,
                                         }).ToList();
            
            return park;
        }
       
        public void AddCapacity(int typeVehicle , int maxVehicle,string idPark)
        {

            Capacity capacity = new Capacity();
            
            capacity.IdVehicleType = typeVehicle;
            capacity.MaxCapacity = maxVehicle;
            capacity.CurrentCapacity = 0;
            capacity.IdPark = idPark;
            capacity.MinCapacity = 0;
            db.Capacities.Add(capacity);
            db.SaveChanges();
        }
        public void AddPlace(int typeVehicle, string idPlacePark, string idPark)
        {

            PlacePark placePark = new PlacePark();
            placePark.Id = idPlacePark;
            placePark.IdPark = idPark;
            placePark.IdVehicleType = typeVehicle;
            placePark.Status = true;
            db.PlaceParks.Add(placePark);
            db.SaveChanges();
        }



        internal object getAllUsePark()
        {
            var park = (from place in db.Parkings
                        where place.isDelete == false
                        select new
                        {
                            Name = place.Name,
                        }).ToList();

            return park;
        }
        internal object getAllNotUsePark()
        {
            var park = (from place in db.Parkings
                        where place.isDelete == true
                        select new
                        {
                            Name = place.Name,
                        }).ToList();

            return park;
        }

        internal void CloseParkDTO(string idPark)
        {
            var parkDTO = (from p in db.Parkings
                           where p.Name == idPark select p).FirstOrDefault();
            parkDTO.isDelete = true;
            parkDTO.DeleteDate = DateTime.Now;
            db.SaveChanges();
        }
    }
}
