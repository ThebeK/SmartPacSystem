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
    
    public partial class Client_Purchase_Order_Line
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client_Purchase_Order_Line()
        {
            this.Credit_Return_Line = new HashSet<Credit_Return_Line>();
        }
    
        public int Client_Purchase_Order_Line_ID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Client_Purchase_Id { get; set; }
        public Nullable<int> Product_ID { get; set; }
    
        public virtual Client_Purchase_Order Client_Purchase_Order { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credit_Return_Line> Credit_Return_Line { get; set; }
    }
}
