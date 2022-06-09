using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.DAL.ManagerDTO
{
    internal class AssignmentDTO:QuanLiNhaXe
    {
        internal int countStaff()
        {
            int  count = db.NVs.Where(u => u.LayOff ==false && u.isStaff == true).Count();
            return count;
        }

        internal object GetAllNomalStaff()
        {
            var user = db.NVs.Where(u => u.LayOff == false && u.isStaff == true).ToList();
            return user;
        }

        internal List<NV> GetNomalStaff()
        {
            List<NV> user = db.NVs.Where(u => u.LayOff == false && u.isStaff == true).ToList<NV>();
            return user;
        }
    }
}
