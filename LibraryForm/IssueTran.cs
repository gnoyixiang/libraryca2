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
    
    public partial class IssueTran
    {
        public short TransactionID { get; set; }
        public string MemberID { get; set; }
        public Nullable<short> BookID { get; set; }
        public Nullable<System.DateTime> DateIssue { get; set; }
        public Nullable<System.DateTime> DateDue { get; set; }
        public Nullable<System.DateTime> DateActualReturn { get; set; }
        public string BorrowStatus { get; set; }
        public string Remarks { get; set; }
    }
}
