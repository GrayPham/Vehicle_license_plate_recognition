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
    
    public partial class TypeofOperation
    {
        public TypeofOperation()
        {
            this.Operations = new HashSet<Operation>();
        }
    
        public int ProcessID { get; set; }
        public string ProcessName { get; set; }
    
        public virtual ICollection<Operation> Operations { get; set; }
    }
}