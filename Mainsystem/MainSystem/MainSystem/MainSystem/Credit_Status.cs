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
    
    public partial class Credit_Status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Credit_Status()
        {
            this.Credit_Approval = new HashSet<Credit_Approval>();
        }
    
        public int Credit_Status_ID { get; set; }
        public string Credit_Status_Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credit_Approval> Credit_Approval { get; set; }
    }
}
