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
    
    public partial class ThanhToan
    {
        public string IdPayment { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> IdTVehicle { get; set; }
        public Nullable<int> IdStaff { get; set; }
        public string LicensePlates { get; set; }
        public Nullable<System.DateTime> ChargeTime { get; set; }
    
        public virtual NguoiGui NguoiGui { get; set; }
        public virtual NV NV { get; set; }
        public virtual TypeVehicle TypeVehicle { get; set; }
    }
}
