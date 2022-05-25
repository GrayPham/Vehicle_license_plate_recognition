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
        // Thêm khách hàng
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

        // Chỉnh sửa thông tin khách hàng
        internal void UpdateCustomer( int idCus, int typeCus, string fname, DateTime birthdate, string email, string gender, string phone)
        {
            var update = db.Customers.Where(user => user.Id == idCus).FirstOrDefault();

                update.TypeID = typeCus;
                update.FullName = fname;
                update.Phone = phone;
                update.BirthDate = birthdate;
                update.Gender = gender;
                update.Email = email;
                db.SaveChanges();
         
        }
        // Danh sách tất cả các khách hàng có trong database 
        internal object getAllCustomer()
        {
            var combo = db.Customers.Select(u => new
            {
                Id = u.Id, Type = u.TypeID, Name = u.FullName, Phone = u.Phone, BirthDate = u.BirthDate, Email = u.Email,
            }).ToList();
            return combo;

        }
        // Hiển thị khách theo mã id
        internal Customer diplayCustomer(int id)
        {
            Customer cus = db.Customers.Where(u => u.Id == id).First();
            return cus;
        }

        //Xóa khách hàng theo mã id
        internal void DeleteCus(int id)
        {
            
            var remove = db.Customers.Where(u => u.Id == id).First();
            remove.TypeID = null;
            remove.FullName = null;
            remove.Phone = null;
            remove.BirthDate = null;
            remove.Gender = null;
            remove.Email = null;
            db.SaveChanges();
        }
    }
}
