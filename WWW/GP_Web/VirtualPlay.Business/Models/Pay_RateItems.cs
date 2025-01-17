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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Pay_RateItems
    {
        public int idRate { get; set; }
        public int idRateItem { get; set; }
        public string nmRateItem { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public string value { get; set; }

        [Range(1, 31)]
        public int nbDays { get; set; }

        public string flStatus { get; set; }
        public int idUserCreate { get; set; }
        public Nullable<int> idUserLastUpdate { get; set; }
        public System.DateTime dtCreate { get; set; }
        public Nullable<System.DateTime> dtLastUpdate { get; set; }
    
        public virtual Pay_Rate Pay_Rate { get; set; }
        public virtual Sys_User Sys_User { get; set; }
        public virtual Sys_User Sys_User1 { get; set; }
    }
}
