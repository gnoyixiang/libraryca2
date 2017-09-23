//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.IssueTrans = new HashSet<IssueTran>();
        }
    
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string MemberCategory { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<decimal> AmountSpent { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string OldPostalCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string ContactTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Extension { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Notes { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueTran> IssueTrans { get; set; }
    }
}
