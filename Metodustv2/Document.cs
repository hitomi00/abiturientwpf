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
    
    public partial class Document
    {
        public int id { get; set; }
        public Nullable<int> applicant_id { get; set; }
        public string type { get; set; }
        public string series { get; set; }
        public string number { get; set; }
        public Nullable<System.DateTime> date_of_issue { get; set; }
        public string issuing_authority { get; set; }
    
        public virtual Applicant Applicant { get; set; }
    }
}
