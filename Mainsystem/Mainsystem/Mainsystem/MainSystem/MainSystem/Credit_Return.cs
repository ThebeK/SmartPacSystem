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
    
    public partial class Credit_Return
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Credit_Return()
        {
            this.Credit_Return_Line = new HashSet<Credit_Return_Line>();
        }
    
        public int Credit_Return_Id { get; set; }
        public Nullable<System.DateTime> Credit_Return_Date { get; set; }
        public string Returned_By { get; set; }
        public string Received_By { get; set; }
        public string CR_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credit_Return_Line> Credit_Return_Line { get; set; }
    }
}