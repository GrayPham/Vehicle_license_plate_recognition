using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.BLL.ManagerDTO
{
    public class ManagerTacVuDAO: QuanLiNhaXe
    {
        public object GetAllRequest()
        {
            object request = db.NVs.Where(user => user.isManage == null && user.isStaff == null && user.isOfficeStaff == null).Select(s => new
            {
                Code = s.IdStaff,
                Name = s.HoVaTenNV,
                Email = s.Email,
                Image = s.ImagePath,
                AddDate = s.NgayAdd
            }).ToList() ;
            return request;
        }

        internal bool DeleteRequestStaff(int idStaff)
        {
            var staff = db.NVs.Where(user => user.IdStaff == idStaff).FirstOrDefault();
            db.NVs.Remove(staff);
            db.SaveChanges();   
            return true;
        }

        internal void UpdateTypeStaff(int idStaff, int typeStaff)
        {
            NV nv = db.NVs.Where(user => user.IdStaff ==idStaff).FirstOrDefault();
            if (typeStaff == 1)
            {
                nv.isStaff = true;
            }
            else if(typeStaff == 2)
            {
                nv.isOfficeStaff = true;    
            }
            else if(typeStaff == 3)
            {
                nv.isManage = true;
            }
            nv.LastUpdate = DateTime.Now;
            db.SaveChanges();
        }
    }
}
