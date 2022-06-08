using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.DAL.OfficeStaff;

namespace Vehicle_license_plate_recognition.Controller.OfficeStaff
{
    internal class turnover
    {
        TurnoverDAL turnoverDAL = new TurnoverDAL();
        internal object GetRevenuByYear()
        {
            var tunover = turnoverDAL.GetAllRevenByYear();
            return tunover;
        }

        internal object GetRevenuByMouth()
        {
            var tunover = turnoverDAL.GetAllRevenByMouth();
            return tunover;
        }

       
    }
}
