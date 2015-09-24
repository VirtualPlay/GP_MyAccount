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
    
    public partial class Per_Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Per_Person()
        {
            this.Per_Address = new HashSet<Per_Address>();
            this.Per_Document = new HashSet<Per_Document>();
            this.Per_Telephone = new HashSet<Per_Telephone>();
            this.Sys_User2 = new HashSet<Sys_User>();
        }
    
        public int idPerson { get; set; }
        public string idPersonSource { get; set; }
        public string nmPerson { get; set; }
        public string nmNick { get; set; }
        public Nullable<System.DateTime> dtBirth { get; set; }
        public string tpGender { get; set; }
        public string dsEmail { get; set; }
        public string dsOccupation { get; set; }
        public string cdMaritalStatus { get; set; }
        public string flStatus { get; set; }
        public Nullable<int> idUserCreate { get; set; }
        public System.DateTime dtCreate { get; set; }
        public Nullable<int> idUserLastUpdate { get; set; }
        public System.DateTime dtLastUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Per_Address> Per_Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Per_Document> Per_Document { get; set; }
        public virtual Sys_User Sys_User { get; set; }
        public virtual Sys_User Sys_User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Per_Telephone> Per_Telephone { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_User> Sys_User2 { get; set; }
    }
}