//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocumentPosition
    {
        public int ID_Position { get; set; }
        public Nullable<int> ID_Document { get; set; }
        public string Name { get; set; }
        public double Gross { get; set; }
        public double Net { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
    
        public virtual Document Document { get; set; }
    }
}