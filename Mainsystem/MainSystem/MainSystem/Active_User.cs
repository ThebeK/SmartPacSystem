//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Active_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Active_User()
        {
            this.Audit_Log = new HashSet<Audit_Log>();
        }
    
        public int Active_User_Id { get; set; }
        public string Username { get; set; }
        public string pass { get; set; }
        public Nullable<int> Access { get; set; }
        public Nullable<int> Employee_Id { get; set; }
    
        public virtual Access_Level Access_Level { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Audit_Log> Audit_Log { get; set; }
    }
}
