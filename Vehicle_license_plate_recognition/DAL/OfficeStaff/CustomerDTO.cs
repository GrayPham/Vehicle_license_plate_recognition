using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.DAL.OfficeStaff
{
    public class CustomerDTO : QuanLiNhaXe
    {
        internal void AddCustomer(int idCus, int typeCus, string fname, DateTime birthdate, string email, string gender, string phone)
        {
            Customer customer = new Customer();
            customer.Id = idCus;
            customer.Phone = phone;
            customer.TypeID = typeCus;
            customer.FullName = fname;
            customer.BirthDate = birthdate;
            customer.Email = email;
            customer.Gender = gender;
            db.Customers.Add(customer);
            db.SaveChanges ();

        }
        
    }
}
