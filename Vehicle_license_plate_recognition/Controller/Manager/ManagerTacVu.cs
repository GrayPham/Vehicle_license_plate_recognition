using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.BLL.ManagerDTO;

namespace Vehicle_license_plate_recognition.Controller.Manager
{
    
    internal class ManagerTacVu
    {
        ManagerTacVuDAO tacvu = new ManagerTacVuDAO();
        internal object GetAllRequestDecen()
        {
            object request = tacvu.GetAllRequest();
            return request;
        }

        internal void UpdateTypeStaff(int idStaff, int typeStaff)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string Dir = Directory.GetParent(workingDirectory).Parent.FullName;
            tacvu.UpdateTypeStaff(idStaff, typeStaff);
            Image pic = Image.FromFile(workingDirectory + Dir + "\\Image\\KhuonMat\\NhanVien\\Temp\\" + idStaff);
            Bitmap imageB = new Bitmap(pic);
            deleteImage(idStaff, typeStaff, Dir);
            
            string path;

            //Kiem tra truong hop duoc thang chuc duong dan Image thay doi
            if (typeStaff == 1)
            {
                path = Dir + "\\Image\\KhuonMat\\NhanVien\\NomalStaff\\" + idStaff;
            }
            else if (typeStaff == 2)
            {
                path = Dir + "\\Image\\KhuonMat\\NhanVien\\OfficeStaff\\" + idStaff;
            }
            else
            {
                path = Dir + "\\Image\\KhuonMat\\NhanVien\\Manager\\" + idStaff;
            }

            imageB.Save(path + ("." + ImageFormat.Png.ToString()));

        }
        private void deleteImage(int typeStaff, int nameFile, string Dir)
        {
            string path = Dir + "\\Image\\KhuonMat\\NhanVien\\Temp\\" + nameFile + ".Png";
            
            File.Delete(path);
        }
        internal bool DeleteStaff(int idStaff)
        {
            
            if(tacvu.DeleteRequestStaff(idStaff) == true)
            {
                return true;
            }
            return false;
        }
    }
}
