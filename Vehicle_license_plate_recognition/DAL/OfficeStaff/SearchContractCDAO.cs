using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.DAL.OfficeStaff
{
    internal class SearchContractCDAO : QuanLiNhaXe
    {
        internal object getAllContact()
        {
            var contact = db.Contracts.Select(u => new
            {
                ID = u.Id,
                NAME = u.NameContract,
                Staff = u.IdOfficeStaff,
                CUSTOMER = u.IdRenter,
                CONTENT = u.Information,
                PRICE = u.TotalValue,
                TYPE = u.TypeConTract,
                CREATIME = u.CreationTime,
                EXPIRYDATE = u.ExpiryDate,
            }).ToList();
            return contact; 
        }

        internal object getAllContactStill()
        {
            var contact = db.Contracts.Where(u => u.ExpiryDate.Value < DateTime.Now).Select(u => new
            {
                ID = u.Id,
                NAME = u.NameContract,
                CUSTOMER = u.IdRenter,
                IdOfficeStaff = u.IdOfficeStaff,
                CONTENT = u.Information,
                PRICE = u.TotalValue,
                TYPE = u.TypeConTract,
                CREATIME = u.CreationTime,
                EXPIRYDATE = u.ExpiryDate,
            }).ToList();
            return contact;
        }

        internal NV GetStaffByID(int idStaff)
        {

            NV staff = db.NVs.Where(u => u.IdStaff == idStaff).FirstOrDefault();
            return staff;
        }

        internal Customer GetCustomerByID(int idCustomer)
        {
            Customer cus = db.Customers.Where(u => u.Id == idCustomer).FirstOrDefault(); 
            return cus;
        }

        internal object getAllContactExpiryDate()
        {
            var contact = db.Contracts.Where(u => u.ExpiryDate.Value > DateTime.Now).Select(u => new
            {
                ID = u.Id,
                NAME = u.NameContract,
                CUSTOMER = u.IdRenter,
                IdOfficeStaff = u.IdOfficeStaff,
                CONTENT = u.Information,
                TYPE = u.TypeConTract,
                PRICE = u.TotalValue,
                CREATIME = u.CreationTime,
                EXPIRYDATE = u.ExpiryDate,
            }).ToList();
            return contact;
        }
    }
}
