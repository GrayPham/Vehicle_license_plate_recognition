using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.DAL.OfficeStaff;

namespace Vehicle_license_plate_recognition.Controller.OfficeStaff
{
    internal class OfficeMainFormBLL
    {
        OfficeMainFormDTO conDTO =new OfficeMainFormDTO();
        // Hiển thị thông tin khách hàng cùng hợp đồng
        internal object getAllContract()
        {
            var cus = conDTO.getAllContract();
            if (cus != null)
            {
                return cus;
            }
            return null;
        }
    }
}
