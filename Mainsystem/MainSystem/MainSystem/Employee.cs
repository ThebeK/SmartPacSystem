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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Active_User = new HashSet<Active_User>();
            this.Dispatches = new HashSet<Dispatch>();
            this.Employee_Logsheet = new HashSet<Employee_Logsheet>();
        }
    
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Surname { get; set; }
        public Nullable<decimal> Employee_Id_Number { get; set; }
        public string Employee_Cellphone_Number { get; set; }
        public string Employee_Email_Address { get; set; }
        public Nullable<decimal> Employee_Account_Number { get; set; }
        public string Employee_Address { get; set; }
        public string Employee_Tax_Number { get; set; }
        public Nullable<int> Employee_Type_ID { get; set; }
        public Nullable<int> Title_Id { get; set; }
        public byte[] Employee_Image { get; set; }
        public string EMP_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Active_User> Active_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dispatch> Dispatches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Logsheet> Employee_Logsheet { get; set; }
        public virtual Employee_Type Employee_Type { get; set; }
        public virtual Title Title { get; set; }
    }
}
