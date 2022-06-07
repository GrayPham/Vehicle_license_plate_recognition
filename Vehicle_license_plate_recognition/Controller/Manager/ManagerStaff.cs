using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.DAL.ManagerDTO;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.Controller.Manager
{
    internal class ManagerStaff
    {
        ManagerStaffDTO mStaffDTO = new ManagerStaffDTO();

        //Kiem tra su ton tai cua ma NV
        internal bool checkIDStaff(int idStaff)
        {
            var staffList = mStaffDTO.checkIDStaff(idStaff);
            if(staffList != null)
            {
                return false;
            }
            return true;
        }

        internal bool checkEmail( string email, int idStaff = 0)
        {
            List<NV> staffList = mStaffDTO.checkEmail(email, idStaff);
            if (staffList.Count != 0)
            {
                return false;
            }
            return true;
        }

        internal bool checkAccount(string acc, int idStaff =0)
        {
            List<NV> staffList = mStaffDTO.checkAccount(acc, idStaff);
            if (staffList.Count !=0)
            {
                return false;
            }
            return true;
        }

        internal object getAllStaff()
        {
            var stafflistt = mStaffDTO.getAllStaff();
            return stafflistt;
        }

        internal bool AddStaff(int idStaff, string account, string pass, string fname, string email, string phone, DateTime adddate, int type, MemoryStream pic)
        {
            if (mStaffDTO.AddStaff(idStaff,account, pass, fname, email,phone, adddate, type))
            {
                string workingDirectory = Environment.CurrentDirectory;
                string Dir = Directory.GetParent(workingDirectory).Parent.FullName;

                Bitmap imageB = new Bitmap(pic);
                string path;
                if (type == 1)
                {
                    path = Dir + "\\Image\\KhuonMat\\NhanVien\\NomalStaff\\" + idStaff;
                }
                else if (type == 2)
                {
                    path = Dir + "\\Image\\KhuonMat\\NhanVien\\OfficeStaff\\" + idStaff;
                }
                else {
                    path = Dir + "\\Image\\KhuonMat\\NhanVien\\Manager\\" + idStaff;
                }
                
                imageB.Save(path + ("." + ImageFormat.Png.ToString()));
                return true;
            }
            else
            {
                return false;
            }

            
        }

        internal bool UpdateStaff(int idStaff, string account, string pass, string fname, string email, string phone, DateTime adddate, int type, MemoryStream pic)
        {
            if (mStaffDTO.UpdateStaff(idStaff, account, pass, fname, email, phone, adddate, type))
            {
                string workingDirectory = Environment.CurrentDirectory;
                string Dir = Directory.GetParent(workingDirectory).Parent.FullName;

                Bitmap imageB = new Bitmap(pic);
                string path;

                //Kiem tra truong hop duoc thang chuc duong dan Image thay doi
                if (type == 1)
                {
                    path = Dir + "\\Image\\KhuonMat\\NhanVien\\NomalStaff\\" + idStaff;
                }
                else if (type == 2)
                {
                    path = Dir + "\\Image\\KhuonMat\\NhanVien\\OfficeStaff\\" + idStaff;
                }
                else
                {
                    path = Dir + "\\Image\\KhuonMat\\NhanVien\\Manager\\" + idStaff;
                }

                imageB.Save(path + ("." + ImageFormat.Png.ToString()));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
