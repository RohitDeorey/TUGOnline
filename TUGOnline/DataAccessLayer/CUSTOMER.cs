//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.CUSTOMER_ADDRESS = new HashSet<CUSTOMER_ADDRESS>();
            this.ORDER_MASTER = new HashSet<ORDER_MASTER>();
        }
    
        public string CUST_ID { get; set; }
        public string PASSWORD { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string EMAIL_ID { get; set; }
        public string MOBILE_NUMBER { get; set; }
        public string CITY { get; set; }
        public string GENDER { get; set; }
        public bool ISACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER_ADDRESS> CUSTOMER_ADDRESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_MASTER> ORDER_MASTER { get; set; }
    }
}