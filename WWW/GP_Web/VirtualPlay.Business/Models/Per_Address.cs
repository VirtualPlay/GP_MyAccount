//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualPlay.Business.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Per_Address
    {
        public int idAddress { get; set; }
        public Nullable<int> idPerson { get; set; }
        public string tpStreet { get; set; }
        public string dsAddress { get; set; }
        public string nbAddress { get; set; }
        public string dsComplement { get; set; }
        public string nmDistrict { get; set; }
        public string dsCity { get; set; }
        public string cdState { get; set; }
        public string nbPostalCode { get; set; }
        public string cdCountry { get; set; }
        public string tpAddress { get; set; }
        public int idUserCreate { get; set; }
        public System.DateTime dtCreate { get; set; }
        public int idUserLastUpdate { get; set; }
        public System.DateTime dtLastUpdate { get; set; }
    
        public virtual Per_Person Per_Person { get; set; }
        public virtual Sys_User Sys_User { get; set; }
        public virtual Sys_User Sys_User1 { get; set; }
    }
}
