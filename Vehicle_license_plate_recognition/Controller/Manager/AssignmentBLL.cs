using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.DAL.ManagerDTO;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.Controller.Manager
{
    internal class AssignmentBLL
    {
        AssignmentDTO ass = new AssignmentDTO();
        internal int CountNomalStaff()
        {
            int count = ass.countStaff();
            return count;

        }

        internal object GetAllNomalStaff()
        {
            var user = ass.GetAllNomalStaff();
            return user;    
        }

        internal object findAssig(string number, int maxCus)
        {
            int num = Convert.ToInt32(number);
            List<NV> listNV = ass.GetNomalStaff();
            DateTime dt = DateTime.Now;
            
            int[,] mang = new int[3, 3];
            int vitri = 0;
            for(int i = 0; i < maxCus; i++)
            {
                mang[0, 0] = listNV[1].IdStaff;
                mang[1, 1] = listNV[1].IdStaff;
                mang[2, 2] = listNV[1].IdStaff;
                if (i + 1 > listNV.Count - 1)
                {
                    mang[0, 1] = listNV[i - listNV.Count + 1].IdStaff;
                    mang[1, 2] = listNV[i - listNV.Count + 1].IdStaff;
                    mang[2, 0] = listNV[i - listNV.Count + 1].IdStaff;
                }
                else
                {
                    mang[0, 1] = listNV[i + 1].IdStaff;
                    mang[1, 2] = listNV[i + 1].IdStaff;
                    mang[2, 0] = listNV[i + 1].IdStaff;
                }
                if (i + 2 > listNV.Count - 1)
                {
                    mang[0, 2] = listNV[i - listNV.Count + 2].IdStaff;
                    mang[1, 0] = listNV[i - listNV.Count + 2].IdStaff;
                    mang[2, 1] = listNV[i - listNV.Count + 2].IdStaff;
                }
                else
                {
                    mang[0, 2] = listNV[i + 2].IdStaff;
                    mang[1, 0] = listNV[i + 2].IdStaff;
                    mang[2, 1] = listNV[i + 2].IdStaff;
                }

                
            }
            

            // num < numMax

            //for(int i =0; i < num; i++)
            //{
            //    mang[0, 0] = listNV[1].IdStaff;
            //    mang[1, 1] = listNV[1].IdStaff;
            //    mang[2, 2] = listNV[1].IdStaff;
            //    if (i + 1 > listNV.Count - 1)
            //    {
            //        mang[0, 1] = listNV[i - listNV.Count +1].IdStaff;
            //        mang[1, 2] = listNV[i - listNV.Count + 1].IdStaff;
            //        mang[2, 0] = listNV[i - listNV.Count + 1].IdStaff;
            //    }
            //    else
            //    {
            //        mang[0, 1] = listNV[i+1].IdStaff;
            //        mang[1, 2] = listNV[i+1].IdStaff;
            //        mang[2, 0] = listNV[i+1].IdStaff;
            //    }
            //    if (i + 2 > listNV.Count - 1)
            //    {
            //        mang[0, 2] = listNV[i - listNV.Count +2].IdStaff;
            //        mang[1, 0] = listNV[i - listNV.Count + 2].IdStaff;
            //        mang[2, 1] = listNV[i - listNV.Count + 2].IdStaff;
            //    }
            //    else
            //    {
            //        mang[0, 2] = listNV[i + 2].IdStaff;
            //        mang[1, 0] = listNV[i + 2].IdStaff;
            //        mang[2, 1] = listNV[i + 2].IdStaff;
            //    }
            //}

            return mang;
            
        }
        private int bcnn(int so1, int so2)
        {
            int i,  j, hcf = 1, bscnn;
            j = (so1 < so2) ? so1 : so2;
            for (i = 1; i <= j; i++)
            {
                if (so1 % i == 0 && so2 % i == 0)
                {
                    hcf = i;
                }
            }
            /* chung ta biet rang: tich cua uoc so chung lon nhat va boi 
            so chung nho nhat thi bang tich cua hai so.*/
            return bscnn = (so1 * so2) / hcf;

        }
    }
}
