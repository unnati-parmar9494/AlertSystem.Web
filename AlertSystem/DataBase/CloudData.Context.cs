﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ITEIndiaEntities : DbContext
    {
        public ITEIndiaEntities()
            : base("name=ITEIndiaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Prodcution_Report_CNC> Prodcution_Report_CNC { get; set; }
        public virtual DbSet<Production_Deviation_Report> Production_Deviation_Report { get; set; }
        public virtual DbSet<Production_ECR_Data> Production_ECR_Data { get; set; }
        public virtual DbSet<Production_Final_Data> Production_Final_Data { get; set; }
        public virtual DbSet<Production_LogTable> Production_LogTable { get; set; }
        public virtual DbSet<Production_Planning> Production_Planning { get; set; }
        public virtual DbSet<Production_Planning_Comlexity_of_Part> Production_Planning_Comlexity_of_Part { get; set; }
        public virtual DbSet<Production_Planning_Priority> Production_Planning_Priority { get; set; }
        public virtual DbSet<Production_Planning_YearlyQty> Production_Planning_YearlyQty { get; set; }
        public virtual DbSet<Production_Production_dtls> Production_Production_dtls { get; set; }
        public virtual DbSet<Production_Qtydtls> Production_Qtydtls { get; set; }
        public virtual DbSet<Production_Report_Generator_Detail> Production_Report_Generator_Detail { get; set; }
        public virtual DbSet<Production_Setup_Dtls> Production_Setup_Dtls { get; set; }
        public virtual DbSet<Production_System_Name> Production_System_Name { get; set; }
        public virtual DbSet<Production_Tool_Details> Production_Tool_Details { get; set; }
        public virtual DbSet<Production_Unique_Op> Production_Unique_Op { get; set; }
        public virtual DbSet<Production_Utilization> Production_Utilization { get; set; }
        public virtual DbSet<USER_MST> USER_MST { get; set; }
        public virtual DbSet<FPA_VIEW> FPA_VIEW { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual ObjectResult<usp_GetPartSummary_Result> usp_GetPartSummary(string systemNum)
        {
            var systemNumParameter = systemNum != null ?
                new ObjectParameter("SystemNum", systemNum) :
                new ObjectParameter("SystemNum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetPartSummary_Result>("usp_GetPartSummary", systemNumParameter);
        }
    }
}
