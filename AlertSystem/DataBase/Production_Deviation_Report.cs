//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlertSystem.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Production_Deviation_Report
    {
        public int Id { get; set; }
        public int MID { get; set; }
        public int PID { get; set; }
        public string Deviation_ID { get; set; }
        public string Production_ID { get; set; }
        public string Job_No { get; set; }
        public string Part_Number { get; set; }
        public string PO_Forecast { get; set; }
        public Nullable<decimal> Qty_for_Deviation { get; set; }
        public string Description_of_Nonconformance { get; set; }
        public string Root_Cause { get; set; }
        public string Deviation_by { get; set; }
        public Nullable<System.DateTime> Deviation_Date { get; set; }
        public Nullable<decimal> Quntity { get; set; }
        public string Rev_No { get; set; }
        public string Op_No { get; set; }
        public string Status { get; set; }
        public string Approved_by { get; set; }
        public Nullable<System.DateTime> Approved_date { get; set; }
    }
}
