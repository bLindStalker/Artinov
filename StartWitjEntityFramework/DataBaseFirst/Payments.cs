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
    
    public partial class Payments
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public double Summ { get; set; }
        public int Order_Id { get; set; }
    }
}
