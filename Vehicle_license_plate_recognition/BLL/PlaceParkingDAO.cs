using System;
using System.Collections.Generic;
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

        internal void returePlaceVehicle(string licenseplates)
        {
            PlacePark place = (from placeP in db.PlaceParks
                               join nguoiGui in db.NguoiGuis
                               on placeP.Id equals nguoiGui.PlaceID
                               where nguoiGui.LicensePlates == licenseplates
                               select placeP).FirstOrDefault();
            place.Status = true;
            
            db.SaveChanges();
        }

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
    }
}
