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
    
    public partial class Customer
    {
        public Customer()
        {
            this.Contracts = new HashSet<Contract>();
        }
    
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
