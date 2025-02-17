﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeWee.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DeWee_DBEntities : DbContext
    {
        public DeWee_DBEntities()
            : base("name=DeWee_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<mst_Block> mst_Block { get; set; }
        public virtual DbSet<mst_BusinessInvestment> mst_BusinessInvestment { get; set; }
        public virtual DbSet<mst_BusinessOwned> mst_BusinessOwned { get; set; }
        public virtual DbSet<mst_BusinessType> mst_BusinessType { get; set; }
        public virtual DbSet<mst_Caste> mst_Caste { get; set; }
        public virtual DbSet<mst_CLF> mst_CLF { get; set; }
        public virtual DbSet<mst_District> mst_District { get; set; }
        public virtual DbSet<mst_ElectricityConsumption> mst_ElectricityConsumption { get; set; }
        public virtual DbSet<mst_ElectricityUsed> mst_ElectricityUsed { get; set; }
        public virtual DbSet<mst_GP> mst_GP { get; set; }
        public virtual DbSet<mst_MachineryPower> mst_MachineryPower { get; set; }
        public virtual DbSet<mst_MoneySavedSE> mst_MoneySavedSE { get; set; }
        public virtual DbSet<mst_Month> mst_Month { get; set; }
        public virtual DbSet<mst_MonthlyExpenseEB> mst_MonthlyExpenseEB { get; set; }
        public virtual DbSet<mst_PowerConnection> mst_PowerConnection { get; set; }
        public virtual DbSet<mst_Solarkilowatt> mst_Solarkilowatt { get; set; }
        public virtual DbSet<mst_SourceEnergy> mst_SourceEnergy { get; set; }
        public virtual DbSet<mst_State> mst_State { get; set; }
        public virtual DbSet<mst_Subisdy> mst_Subisdy { get; set; }
        public virtual DbSet<mst_TypeYesNo> mst_TypeYesNo { get; set; }
        public virtual DbSet<mst_Village> mst_Village { get; set; }
        public virtual DbSet<mst_VO> mst_VO { get; set; }
        public virtual DbSet<mst_Year> mst_Year { get; set; }
        public virtual DbSet<mst_BusinessInstallation> mst_BusinessInstallation { get; set; }
        public virtual DbSet<mst_Educational_Qualification> mst_Educational_Qualification { get; set; }
        public virtual DbSet<mst_Enterprise> mst_Enterprise { get; set; }
        public virtual DbSet<mst_Enterprise_Established> mst_Enterprise_Established { get; set; }
        public virtual DbSet<mst_EnterpriseMachine> mst_EnterpriseMachine { get; set; }
        public virtual DbSet<mst_LoanDescribeSource> mst_LoanDescribeSource { get; set; }
        public virtual DbSet<mst_MachineSource> mst_MachineSource { get; set; }
        public virtual DbSet<mst_NatureSpace> mst_NatureSpace { get; set; }
        public virtual DbSet<mst_SolarInstallation> mst_SolarInstallation { get; set; }
        public virtual DbSet<mst_SpaceAvailable> mst_SpaceAvailable { get; set; }
        public virtual DbSet<tbl_IndtSolarization> tbl_IndtSolarization { get; set; }
        public virtual DbSet<mst_Relative> mst_Relative { get; set; }
        public virtual DbSet<tbl_Beneficiary> tbl_Beneficiary { get; set; }
    }
}
