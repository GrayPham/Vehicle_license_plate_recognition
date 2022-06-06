using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.BLL;

namespace Vehicle_license_plate_recognition.Controller.Staff
{
    public class ParkDistribution
    {
        PlaceParkingDAO pParkDAO = new PlaceParkingDAO();
        public string distributionVehicle(int typeVehicle,string IdPark)
        {
            string idPlacePark = pParkDAO.GetPlaceVehicle(typeVehicle,IdPark);
            return idPlacePark;
        }

        
    }
}
