using System;
using System.Collections.Generic;
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
            tacvu.UpdateTypeStaff(idStaff, typeStaff);
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
