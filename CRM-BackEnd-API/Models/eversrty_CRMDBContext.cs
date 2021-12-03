using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRM_BackEnd_API.Models
{
    public partial class eversrty_CRMDBContext : DbContext
    {
        public eversrty_CRMDBContext()
        {
        }

        public eversrty_CRMDBContext(DbContextOptions<eversrty_CRMDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<JobInfo> JobInfo { get; set; }
        public virtual DbSet<Provence> Provence { get; set; }
        public virtual DbSet<Salary> Salary { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=50.116.114.76;user id=eversrty_root;database=eversrty_CRMDB;password=Welcome_2021", x => x.ServerVersion("5.6.41-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branches>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CityId)
                    .HasName("FKBranches235409");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FKBranches294029");

                entity.HasIndex(e => e.CountryId)
                    .HasName("FKBranches26713");

                entity.HasIndex(e => e.ProvenceId)
                    .HasName("FKBranches169022");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Address)
                    .HasColumnType("char(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchAddress)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchEmail)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchName)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CityId)
                    .HasColumnName("CityID")
                    .HasColumnType("int(50)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasColumnType("int(50)");

                entity.Property(e => e.CustomerSupport)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.GeoLocation)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LandLineNumber)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProvenceId)
                    .HasColumnName("ProvenceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.WhatsappNumber)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKBranches235409");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKBranches294029");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKBranches26713");

                entity.HasOne(d => d.Provence)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.ProvenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKBranches169022");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("FKCity890190");

                entity.HasIndex(e => e.ProvenceId)
                    .HasName("FKCity305544");

                entity.Property(e => e.CityId)
                    .HasColumnName("CityID")
                    .HasColumnType("int(50)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CityName)
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CityShortName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasColumnType("int(50)");

                entity.Property(e => e.ProvenceId)
                    .HasColumnName("ProvenceID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKCity890190");

                entity.HasOne(d => d.Provence)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.ProvenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKCity305544");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CompanyLogo)
                    .IsRequired()
                    .HasColumnType("char(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasColumnType("int(50)");

                entity.Property(e => e.CountryName)
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("FKDepartment610139");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FKDepartment850911");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.DepartmentName)
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EnteredBy)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EnteredOn).HasColumnType("timestamp");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKDepartment610139");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKDepartment850911");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("FKDesignatio647413");

                entity.Property(e => e.DesignationId)
                    .HasColumnName("DesignationID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.DesignationName)
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Designation)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKDesignatio647413");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("FKEmployee824599");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FKEmployee583827");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("char(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BankAccountTitle)
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BankName)
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Cnicnumber)
                    .HasColumnName("CNICNumber")
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EmployeeImage)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EmployeeNtn)
                    .HasColumnName("EmployeeNTN")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EnteredBy).HasColumnType("timestamp");

                entity.Property(e => e.EnteredOn).HasColumnType("timestamp");

                entity.Property(e => e.FirstName)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Gender)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.GuardianName)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.GuardianRelation)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.MobileNumber)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKEmployee824599");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKEmployee583827");
            });

            modelBuilder.Entity<JobInfo>(entity =>
            {
                entity.HasKey(e => e.JodInfoId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.BranchId)
                    .HasName("FKJobInfo130029");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FKJobInfo110743");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("FKJobInfo72102");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("FKJobInfo585590");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("FKJobInfo564595");

                entity.Property(e => e.JodInfoId)
                    .HasColumnName("JodInfoID")
                    .HasColumnType("int(50)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DesignationId)
                    .HasColumnName("DesignationID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.EnteredBy).HasColumnType("char(225)");

                entity.Property(e => e.EnteredOn).HasColumnType("timestamp");

                entity.Property(e => e.ExpiryDate).HasColumnType("timestamp");

                entity.Property(e => e.JobType)
                    .HasColumnName("jobType")
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("timestamp")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Salary).HasColumnType("int(100)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.JobInfo)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJobInfo130029");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.JobInfo)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJobInfo110743");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.JobInfo)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJobInfo72102");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.JobInfo)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJobInfo585590");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.JobInfo)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJobInfo564595");
            });

            modelBuilder.Entity<Provence>(entity =>
            {
                entity.Property(e => e.ProvenceId)
                    .HasColumnName("ProvenceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvenceName)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("FKSalary144152");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FKSalary586666");

                entity.Property(e => e.SalaryId)
                    .HasColumnName("SalaryID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Allowance).HasColumnType("int(100)");

                entity.Property(e => e.BasicSalary).HasColumnType("int(100)");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.GrossSalary).HasColumnType("int(100)");

                entity.Property(e => e.NetSalary).HasColumnType("int(100)");

                entity.Property(e => e.Tax).HasColumnType("int(100)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Salary)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKSalary144152");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Salary)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKSalary586666");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("FKUserRoles916409");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FKUserRoles814408");

                entity.Property(e => e.UserRolesId)
                    .HasColumnName("UserRolesID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.UserRole)
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKUserRoles916409");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKUserRoles814408");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.BranchId)
                    .HasName("FKUsers735641");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FKUsers505130");

                entity.HasIndex(e => e.UserRolesId)
                    .HasName("FKUsers757342");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Active)
                    .HasColumnType("char(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("int(100)");

                entity.Property(e => e.EnteredBy).HasColumnType("varchar(255)");

                entity.Property(e => e.EnteredOn).HasColumnType("timestamp");

                entity.Property(e => e.Password)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserRole)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserRolesId)
                    .HasColumnName("UserRolesID")
                    .HasColumnType("int(10)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKUsers735641");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKUsers505130");

                entity.HasOne(d => d.UserRoles)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKUsers757342");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
