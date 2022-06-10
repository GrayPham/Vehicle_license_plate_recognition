using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.DAL.OfficeStaff
{
    internal class OfficeMainFormDTO: QuanLiNhaXe
    {
        internal object getAllContract()
        {
            var q = from e in db.Contracts
                    join d in db.Customers on e.IdRenter equals d.Id
                    where e.isDelete == null
                    select new
                    {
                        Fullname = d.FullName,
                        Customer = d.Id,
                        ID = e.Id,
                        Type = e.TypeConTract,
                        Name = e.NameContract,
                        Content = e.Information,
                        OfficeStaff = e.IdOfficeStaff,
                        Creation = e.CreationTime,
                        Expiry = e.ExpiryDate,
                        Value = e.TotalValue,

                    };
            return q.ToList();
        }
    }
}
