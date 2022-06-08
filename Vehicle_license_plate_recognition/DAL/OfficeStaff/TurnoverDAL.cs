using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;

namespace Vehicle_license_plate_recognition.DAL.OfficeStaff
{
    internal class TurnoverDAL: QuanLiNhaXe
    {
        internal object GetAllRevenByYear()
        {
            var revenYear = db.Contracts.GroupBy(l =>l.CreationTime.Value.Year).Select(s => new
            {
                YEAR = s.Key,
                Price = s.Sum(w => w.TotalValue)

            }).ToList();

            return revenYear;
        }

        internal object GetAllRevenByMouth()
        {
            DateTime dateTimeNow = DateTime.Now;

            var revenMonth = db.Contracts.Where(u => u.CreationTime.Value.Year == dateTimeNow.Year).GroupBy(l => l.CreationTime.Value.Month).Select(s => new
            {
                MONTH = s.Key,
                Price = s.Sum(w => w.TotalValue)

            }).ToList();

            return revenMonth;
        }

        
    }
}
