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
    
    public partial class Schedule
    {
        public Schedule()
        {
            this.ScheduleEmploys = new HashSet<ScheduleEmploy>();
        }
    
        public int Id { get; set; }
        public Nullable<int> MaxEmployees { get; set; }
        public Nullable<int> NumberOfShift { get; set; }
        public Nullable<int> IdAssignment { get; set; }
        public Nullable<int> OneShiftTime { get; set; }
    
        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<ScheduleEmploy> ScheduleEmploys { get; set; }
    }
}
