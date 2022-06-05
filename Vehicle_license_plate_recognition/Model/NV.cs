//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vehicle_license_plate_recognition.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NV
    {
        public NV()
        {
            this.Contracts = new HashSet<Contract>();
            this.RequestingAbsences = new HashSet<RequestingAbsence>();
            this.ThanhToans = new HashSet<ThanhToan>();
        }
    
        public int IdStaff { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string HoVaTenNV { get; set; }
        public Nullable<System.DateTime> NgayAdd { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<bool> LayOff { get; set; }
        public Nullable<System.DateTime> LayOffDate { get; set; }
        public Nullable<int> Absences { get; set; }
        public Nullable<int> IdSchedule { get; set; }
        public Nullable<bool> isManage { get; set; }
        public Nullable<bool> isOfficeStaff { get; set; }
        public Nullable<bool> isStaff { get; set; }
        public string ImagePath { get; set; }
    
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ScheduleEmploy ScheduleEmploy { get; set; }
        public virtual ICollection<RequestingAbsence> RequestingAbsences { get; set; }
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
