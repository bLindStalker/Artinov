//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounts
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public bool IsActiveStatus { get; set; }
        public string Comment { get; set; }
        public Nullable<int> User_Id { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
