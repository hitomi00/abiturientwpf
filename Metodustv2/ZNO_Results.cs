//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Metodustv2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZNO_Results
    {
        public int id { get; set; }
        public Nullable<int> applicant_id { get; set; }
        public Nullable<int> subject_id { get; set; }
        public Nullable<decimal> score { get; set; }
    
        public virtual Applicant Applicant { get; set; }
        public virtual Subject Subject { get; set; }
    }
}