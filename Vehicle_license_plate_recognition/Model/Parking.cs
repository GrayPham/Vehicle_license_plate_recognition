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
    
    public partial class Parking
    {
        public Parking()
        {
            this.Capacities = new HashSet<Capacity>();
            this.NguoiGuis = new HashSet<NguoiGui>();
            this.PlaceParks = new HashSet<PlacePark>();
        }
    
        public string Name { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
    
        public virtual ICollection<Capacity> Capacities { get; set; }
        public virtual ICollection<NguoiGui> NguoiGuis { get; set; }
        public virtual ICollection<PlacePark> PlaceParks { get; set; }
    }
}
