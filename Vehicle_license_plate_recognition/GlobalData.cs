using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_license_plate_recognition
{
    public class GlobalData
    {
        public static int idStaff { get; private set; } = 322;
        public static int typeStaff { get; private set; } 
        public static string NameUser { get;  set; }
        public static string ImagePath { get; private set; }
        public static void setImagePath (string imagePath)
        {
            ImagePath = imagePath;
        }
        public static void SetTypeStaff(int TypeStaff)
        {
            typeStaff = TypeStaff;
        }
        public static void SetIDStaff(int IdStaff)
        {
            idStaff = IdStaff;
        }
    }
}
