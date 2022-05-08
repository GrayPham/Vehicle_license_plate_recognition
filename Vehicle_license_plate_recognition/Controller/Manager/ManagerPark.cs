using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.BLL;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.Controller.Manager
{
    internal class ManagerPark
    {
        PlaceParkingDAO mParkDAO = new PlaceParkingDAO();

        internal void GeneratePark(string namePark, int maxMotor, int maxBicycle, int maxCar)
        {
            List<string> placeMotorLisr = new List<string>();
            List<string> placeCarLisr = new List<string>();
            List<string> placeBicycleLisr = new List<string>();
            for(int i = 0; i < maxMotor; i++)
            {
                string temp = namePark + "_T2_" + i;
                placeMotorLisr.Add(temp); 
            }
            for (int i = 0; i < maxBicycle; i++)
            {
                string temp = namePark + "_T1_" + i;
                placeBicycleLisr.Add(temp);
            }
            for (int i = 0; i < maxCar; i++)
            {
                string temp = namePark + "_T3_" + i;
                placeCarLisr.Add(temp); 
            }
            mParkDAO.GenerateParkDAO(namePark, maxMotor, maxBicycle, maxCar, placeMotorLisr, placeCarLisr, placeBicycleLisr);

        }

        internal void DeletePark(string idPark)
        {
            mParkDAO.DeletePark(idPark);
        }

        internal void OpenPark(string idPark)
        {
            mParkDAO.OpenParkDTO(idPark);
        }

        internal object getAllNotUsePark()
        {
            var allPark = mParkDAO.getAllNotUsePark();

            return allPark;
        }

        internal object getAllUsePark()
        {
            var allPark = mParkDAO.getAllUsePark();

            return allPark;
        }

        internal List<Capacity> getCapOfPark(string idPark)
        {
            return mParkDAO.getCapOfPark(idPark);
        }

        internal void ClosePark(string idPark)
        {
            mParkDAO.CloseParkDTO(idPark);
        }

        

        internal void UpdatePark(string oldNamePark,string namePark, int maxMotor, int maxBicycle, int maxCar)
        {
            List<string> placeMotorLisr = new List<string>();
            List<string> placeCarLisr = new List<string>();
            List<string> placeBicycleLisr = new List<string>();
            for (int i = 0; i < maxMotor; i++)
            {
                string temp = namePark + "_T2_" + i;
                placeMotorLisr.Add(temp);
            }
            for (int i = 0; i < maxBicycle; i++)
            {
                string temp = namePark + "_T1_" + i;
                placeBicycleLisr.Add(temp);
            }
            for (int i = 0; i < maxCar; i++)
            {
                string temp = namePark + "_T3_" + i;
                placeCarLisr.Add(temp);
            }
            mParkDAO.UpdateParkDAO(oldNamePark, namePark, maxMotor, maxBicycle, maxCar, placeMotorLisr, placeCarLisr, placeBicycleLisr);
        }
    }
}
