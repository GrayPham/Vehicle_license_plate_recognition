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
    
    public partial class Assignment
    {
        public Assignment()
        {
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int Id { get; set; }
        public Nullable<System.TimeSpan> TimeShift { get; set; }
    
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}