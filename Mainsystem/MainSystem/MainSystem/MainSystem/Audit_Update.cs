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
    
    public partial class Audit_Update
    {
        public int Audit_Update_Id { get; set; }
        public Nullable<int> PK_Row_Effected { get; set; }
        public string Field_Effected { get; set; }
        public string Before_Value { get; set; }
        public string After_Value { get; set; }
        public Nullable<int> Audit_Log_Id { get; set; }
    
        public virtual Audit_Log Audit_Log { get; set; }
    }
}
