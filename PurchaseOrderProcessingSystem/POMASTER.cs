//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PurchaseOrderProcessingSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class POMASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POMASTER()
        {
            this.PODETAIL = new HashSet<PODETAIL>();
        }
    
        public string PONO { get; set; }
        public Nullable<System.DateTime> PODATE { get; set; }
        public string SUPLNO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PODETAIL> PODETAIL { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
