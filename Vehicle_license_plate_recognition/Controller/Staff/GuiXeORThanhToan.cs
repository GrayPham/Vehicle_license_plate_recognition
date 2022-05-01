﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        public List<Parking> GetAllParkActive(int TypeVehicle)
        {
            List<Parking> getPark = nvbll.GetAllParkActive(TypeVehicle);
            return getPark;
        }

        public bool PostSentCar(DateTime deliveryTime, string licensePlates,string IdPark, int typeVehicle, Image image)
        {
            //string Dir = System.IO.Directory.GetCurrentDirectory();
            // Get current working directory (..\bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            string Dir = Directory.GetParent(workingDirectory).Parent.FullName;
            
            if (typeVehicle == 3)
            {
                string filename = licensePlates;
                Bitmap imageB = new Bitmap(image);
                string path = Dir + "\\Image\\BienDai\\" + filename;
                imageB.Save(path +("." + ImageFormat.Png.ToString()));
                nvbll.PostSentCar(deliveryTime, licensePlates, IdPark, typeVehicle, path);
            }
            
            return true;
        }

        internal double CalculateParking(string LicensePlate, int typeVehicle, int idStaff, DateTime returnTime)
        {
            double price = nvbll.GetPriceofVehicle(typeVehicle);
            DateTime DeliveryTime = nvbll.GetDeleveryTime(LicensePlate);
            double priceAVehicle = PriceAVehicle(DeliveryTime, returnTime, price);
            return priceAVehicle;
        }
        private double PriceAVehicle(DateTime DeliveryTime, DateTime ReturnTime, double UnitPrice)
        {
            double price = 0;
            double ADayPrice= 8 *UnitPrice;
            double AWeekPrice = 3 * ADayPrice;
            double AMouthPrice = 2 * AWeekPrice;

            int NumDayOfMouth = 30;
            int NumDayOfWeek = 7;
            //int NumHoursOfDay = 24;
            if (ReturnTime >= DeliveryTime)
            {
                DateTime TimeTemp = ReturnTime;
                ReturnTime = DeliveryTime;
                DeliveryTime = TimeTemp;
            }
            TimeSpan interval = ReturnTime.Subtract(DeliveryTime);
            int NumDate = interval.Days;
            int NumHoure = interval.Hours;
            if (NumDate >= NumDayOfMouth)
            {
                int NumOfMouth = Convert.ToInt32(NumDate / NumDayOfMouth);
                price = price + NumOfMouth * AMouthPrice;
                NumDate = NumDate - NumOfMouth* NumDayOfMouth;
            }
            if(NumDate >= NumDayOfWeek)
            {
                int NumOfWeek = Convert.ToInt32(NumDate / NumDayOfWeek);
                int NumDayLeft = NumDate - NumOfWeek * NumDayOfWeek;
                price = price + NumOfWeek * AWeekPrice +NumDayLeft* ADayPrice;

            }
            
            if(NumHoure >= 1)
            {
                price = price+ NumHoure * UnitPrice;
            }
            else
            {
                price = price+ UnitPrice;
            }
            
            return price;

        }
    }
}
