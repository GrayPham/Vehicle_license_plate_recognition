using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;
namespace Vehicle_license_plate_recognition.DAL.ManagerDTO
{
    internal class ManagerStaffDTO : QuanLiNhaXe
    {
        internal object checkIDStaff(int idStaff)
        {
            List<NV> user = db.NVs.Where(u => u.IdStaff == idStaff).ToList();
            return user;
        }

        internal List<NV> checkEmail(string email, int idStaff)
        {
            List<NV> user = db.NVs.Where(u => u.Email == email && u.IdStaff != idStaff).ToList();
            return user;
        }

        internal List<NV> checkAccount(string acc, int idStaff)
        {
            List<NV> user = db.NVs.Where(u => u.Account == acc && u.IdStaff != idStaff).ToList();
            return user;
        }

        internal bool AddStaff(int idStaff, string account, string pass, string fname, string email, string phone, DateTime adddate, int type)
        {
            try
            {
                NV user = new NV();
                user.IdStaff = idStaff;
                user.Account = account;
                user.Password = pass;
                user.Email = email;
                user.Phone = phone;
                user.HoVaTenNV = fname;
                user.LastUpdate = adddate;
                user.NgayAdd = adddate;
                user.Absences = 0;
                user.ImagePath = idStaff.ToString();

                //LayOFF để kiểm tra xem nhân viên đó đã tạo cơ chế FaceID chưa
                //user.LayOff = false;
                if (type == 3)
                {
                    user.isManage = true;
                    user.isOfficeStaff = false;
                    user.isStaff = false;
                }
                else if (type == 2)
                {
                    user.isOfficeStaff = true;
                    user.isManage = false;
                    user.isStaff = false;
                }
                else
                {
                    user.isStaff = true;
                    user.isManage = false;
                    user.isOfficeStaff = false;

                }
                db.NVs.Add(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        internal void ActiveStaff(string idStaff)
        {
            int StaffId = Convert.ToInt32(idStaff);
            var staff = db.NVs.Where(u => u.IdStaff == StaffId).FirstOrDefault();
            if (staff != null)
            {
                staff.LayOff = false;
            }
        }

        internal bool DeleteStaffDTO(int idStaff)
        {
            try
            {
                NV user = db.NVs.Find(idStaff);
                if (user == null) return false;
                else
                {
                    // Cải tiến chỉ được xóa nhân viên sau 1 năm nghỉ việc

                    db.NVs.Remove(user);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false ;
            }
        }

        internal object GetAllOfficeStaffFire()
        {
            DateTime dt = DateTime.Now;
            var list = db.NVs.Where(u => u.isOfficeStaff == true && u.LayOff == true ).Select(u => new
            {
                ID = u.IdStaff,
                Name = u.HoVaTenNV,
                Account = u.Account,
                Password = u.Password,
                Phone = u.Phone,
                Email = u.Email,
                Absences = u.Absences,
                Position = u.isManage == true ? "Manager" : u.isStaff == true ? "Staff" : "OfficeStaff",
                Picture = u.ImagePath
            }).ToList();

            return list;
        }

        internal object GetAllNomalStaffFire()
        {
            var list = db.NVs.Where(u => u.isStaff == true && u.LayOff == true).Select(u => new {
                ID = u.IdStaff,
                Name = u.HoVaTenNV,
                Account = u.Account,
                Password = u.Password,
                Phone = u.Phone,
                Email = u.Email,
                Absences = u.Absences,
                Position = u.isManage == true ? "Manager" : u.isStaff == true ? "Staff" : "OfficeStaff",
                Picture = u.ImagePath
            }).ToList();

            return list;
        }

        internal object GetAllManagerFire()
        {
            var list = db.NVs.Where(u => u.isManage == true && u.LayOff == true).Select(u => new {
                ID = u.IdStaff,
                Name = u.HoVaTenNV,
                Account = u.Account,
                Password = u.Password,
                Phone = u.Phone,
                Email = u.Email,
                Absences = u.Absences,
                Position = u.isManage == true ? "Manager" : u.isStaff == true ? "Staff" : "OfficeStaff",
                Picture = u.ImagePath
            }).ToList();

            return list;
        }

        internal bool FireStaff(int idStaff)
        {
            try
            {
                NV user = db.NVs.Where(x => x.IdStaff == idStaff).FirstOrDefault();
                if (user != null)
                {
                    user.LayOff = true;
                    user.LayOffDate = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal object GetAllNomalStaff()
        {
            var list = db.NVs.Where(u => u.isStaff == true && u.LayOff == false).Select(u => new {
                ID = u.IdStaff,
                Name = u.HoVaTenNV,
                Account = u.Account,
                Password = u.Password,
                Phone = u.Phone,
                Email = u.Email,
                Absences = u.Absences,
                Position = u.isManage == true ? "Manager" : u.isStaff == true ? "Staff" : "OfficeStaff",
                Picture = u.ImagePath
            }).ToList();

            return list;
        }

        internal object GetAllOfficeStaff()
        {
            var list = db.NVs.Where(u => u.isOfficeStaff == true && u.LayOff == false).Select(u => new {
                ID = u.IdStaff,
                Name = u.HoVaTenNV,
                Account = u.Account,
                Password = u.Password,
                Phone = u.Phone,
                Email = u.Email,
                Absences = u.Absences,
                Position = u.isManage == true ? "Manager" : u.isStaff == true ? "Staff" : "OfficeStaff",
                Picture = u.ImagePath
            }).ToList();

            return list;
        }

        internal object GetAllManager()
        {
            var list = db.NVs.Where(u => u.isManage == true && u.LayOff == false).Select(u => new {
                ID = u.IdStaff,
                Name = u.HoVaTenNV,
                Account = u.Account,
                Password = u.Password,
                Phone = u.Phone,
                Email = u.Email,
                Absences = u.Absences,
                Position = u.isManage == true ? "Manager" : u.isStaff == true ? "Staff" : "OfficeStaff",
                Picture = u.ImagePath
            }).ToList();

            return list;
        }

        internal object getAllStaff()
        {
            var list = db.NVs.Where(u => u.LayOff == false).Select(u => new {
                ID = u.IdStaff,
                Name = u.HoVaTenNV,
                Account = u.Account,
                Password = u.Password,
                Phone = u.Phone,
                Email = u.Email,
                Position = u.isManage == true ? "Manager": u.isStaff == true? "Staff": "OfficeStaff" ,
                Picture = u.ImagePath
            }).ToList();
            return list;
        }

        internal bool UpdateStaff(int idStaff, string account, string pass, string fname, string email, string phone, DateTime adddate, int type)
        {
            try
            {
                NV nvUpdate = db.NVs.Where(u => u.IdStaff == idStaff).FirstOrDefault();


                nvUpdate.Account = account;
                nvUpdate.Password = pass;
                nvUpdate.Email = email;
                nvUpdate.Phone = phone;
                nvUpdate.HoVaTenNV = fname;
                nvUpdate.LastUpdate = adddate;
                

                //LayOFF để kiểm tra xem nhân viên đó đã tạo cơ chế FaceID chưa
                //user.LayOff = false;
                if (type == 3)
                {
                    nvUpdate.isManage = true;
                    nvUpdate.isOfficeStaff = false;
                    nvUpdate.isStaff = false;
                }
                else if (type == 2)
                {
                    nvUpdate.isOfficeStaff = true;
                    nvUpdate.isManage = false;
                    nvUpdate.isStaff = false;
                }
                else
                {
                    nvUpdate.isStaff = true;
                    nvUpdate.isManage = false;
                    nvUpdate.isOfficeStaff = false;

                }

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
