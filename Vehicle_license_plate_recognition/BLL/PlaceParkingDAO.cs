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
    }
}
