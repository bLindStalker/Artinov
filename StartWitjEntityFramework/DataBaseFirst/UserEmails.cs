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
    
    public partial class UserEmails
    {
        public int Id { get; set; }
        public string EmailName { get; set; }
        public string Comment { get; set; }
        public int TypeConnect_Id { get; set; }
        public int User_Id { get; set; }
    
        public virtual TypeConnects TypeConnects { get; set; }
    }
}
