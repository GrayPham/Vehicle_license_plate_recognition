﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_license_plate_recognition.Model;
namespace Vehicle_license_plate_recognition.DAL.OfficeStaff
{
    internal class ContractDTO: QuanLiNhaXe
    {
        internal static void AddContract(int id, string name, string content, int staff, int idrenter, DateTime create, DateTime expiry, int type, decimal total)
        {
            Contract contract = new Contract();
            contract.Id = id;
            contract.NameContract = name;
            contract.Information = content;
            contract.IdOfficeStaff = staff;
            contract.IdRenter = idrenter;
            contract.CreationTime = create;
            contract.ExpiryDate = expiry;
            contract.TypeConTract = type;
            contract.TotalValue = total;
            db.Contracts.Add(contract);
            db.SaveChanges();

        }
        // Hiển thị khách theo mã id
        internal object getAllContract()
        {
            var combo = db.Contracts.Select(u => new
            {
                Id = u.Id,
                Name = u.NameContract,
                Content = u.Information,
                IdOfficeStaff = u.IdOfficeStaff,
                IdRender = u.IdRenter,
                Type = u.TypeConTract,
                CreationDate = u.CreationTime,
                ExpiryDate = u.ExpiryDate,
                TotalValue = u.TotalValue,

            }).ToList();
            return combo;
        }

        // Kiểm tra id Customer đã tồn tại chưa
        internal object checkID(int idren)
        {
            var test = db.Customers.Where(u => u.TypeID == idren).Select(u => new
            {
                Id = u.Id,
            }).ToList();
            return test;
        }
    }
}