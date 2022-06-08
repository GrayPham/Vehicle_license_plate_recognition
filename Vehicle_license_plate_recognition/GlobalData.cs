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
        
        public static string NameUser { get;  set; }


        public static void SetIDStaff(int IdStaff)
        {
            idStaff = IdStaff;
        }
    }
}
