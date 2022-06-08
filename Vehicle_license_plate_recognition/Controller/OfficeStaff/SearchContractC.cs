using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.DAL.OfficeStaff;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.Controller.OfficeStaff
{
    internal class SearchContractC
    {
        SearchContractCDAO contractCDAO = new SearchContractCDAO();
        internal object getAllContact(int type = 0)
        {
            if (type == 0)
            {
                var contact = contractCDAO.getAllContact();
                return contact;
            }
            else if(type == 1)
            {
                var contact = contractCDAO.getAllContactStill();
                return contact;
            }
            else
            {
                var contact = contractCDAO.getAllContactExpiryDate();
                return contact;
            }


        }

        internal Customer GetCustomerByID(int idCustomer)
        {
            Customer customer = contractCDAO.GetCustomerByID(idCustomer);
            return customer;
        }

        internal NV GetStaffByID(string idStaff)
        {
            int staffId = Convert.ToInt32(idStaff);
            NV staff = contractCDAO.GetStaffByID(staffId);
            return staff;
        }
    }
}
