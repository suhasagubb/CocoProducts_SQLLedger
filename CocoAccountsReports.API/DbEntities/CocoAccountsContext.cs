using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CocoAccountsReports.API.DbEntities
{
    public partial class CocoAccountsContext : DbContext
    {
        public CocoAccountsContext()
        {
        }

        public CocoAccountsContext(DbContextOptions<CocoAccountsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccTrans> AccTrans { get; set; }
        public virtual DbSet<Acsrole> Acsrole { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Ap> Ap { get; set; }
        public virtual DbSet<Ar> Ar { get; set; }
        public virtual DbSet<Archive> Archive { get; set; }
        public virtual DbSet<Archivedata> Archivedata { get; set; }
        public virtual DbSet<Assembly> Assembly { get; set; }
        public virtual DbSet<Audittrail> Audittrail { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Br> Br { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Chart> Chart { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Curr> Curr { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Customertax> Customertax { get; set; }
        public virtual DbSet<Deduct> Deduct { get; set; }
        public virtual DbSet<Deduction> Deduction { get; set; }
        public virtual DbSet<Deductionrate> Deductionrate { get; set; }
        public virtual DbSet<Defaults> Defaults { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DptTrans> DptTrans { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Employeededuction> Employeededuction { get; set; }
        public virtual DbSet<Employeewage> Employeewage { get; set; }
        public virtual DbSet<Exchangerate> Exchangerate { get; set; }
        public virtual DbSet<Gifi> Gifi { get; set; }
        public virtual DbSet<Gl> Gl { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Jcitems> Jcitems { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Makemodel> Makemodel { get; set; }
        public virtual DbSet<Mimetype> Mimetype { get; set; }
        public virtual DbSet<Oe> Oe { get; set; }
        public virtual DbSet<Orderitems> Orderitems { get; set; }
        public virtual DbSet<Parts> Parts { get; set; }
        public virtual DbSet<Partscustomer> Partscustomer { get; set; }
        public virtual DbSet<Partsgroup> Partsgroup { get; set; }
        public virtual DbSet<Partstax> Partstax { get; set; }
        public virtual DbSet<Partsvendor> Partsvendor { get; set; }
        public virtual DbSet<PayTrans> PayTrans { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Paymentmethod> Paymentmethod { get; set; }
        public virtual DbSet<Payrate> Payrate { get; set; }
        public virtual DbSet<Pricegroup> Pricegroup { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Recent> Recent { get; set; }
        public virtual DbSet<Recentdescr> Recentdescr { get; set; }
        public virtual DbSet<Recurring> Recurring { get; set; }
        public virtual DbSet<Recurringemail> Recurringemail { get; set; }
        public virtual DbSet<Recurringprint> Recurringprint { get; set; }
        public virtual DbSet<Reference> Reference { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Reportvars> Reportvars { get; set; }
        public virtual DbSet<Semaphore> Semaphore { get; set; }
        public virtual DbSet<Shipto> Shipto { get; set; }
        public virtual DbSet<Sic> Sic { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<Translation> Translation { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<Vendortax> Vendortax { get; set; }
        public virtual DbSet<Vr> Vr { get; set; }
        public virtual DbSet<Wage> Wage { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Yearend> Yearend { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=cocoaccounts;Username=postgres;Password=Gottilla@1204");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccTrans>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc_trans");

                entity.HasIndex(e => e.ChartId)
                    .HasName("acc_trans_chart_id_key");

                entity.HasIndex(e => e.TransId)
                    .HasName("acc_trans_trans_id_key");

                entity.HasIndex(e => e.Transdate)
                    .HasName("acc_trans_transdate_key");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ChartId).HasColumnName("chart_id");

                entity.Property(e => e.Cleared)
                    .HasColumnName("cleared")
                    .HasColumnType("date");

                entity.Property(e => e.FxTransaction)
                    .HasColumnName("fx_transaction")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Memo).HasColumnName("memo");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.VrId).HasColumnName("vr_id");
            });

            modelBuilder.Entity<Acsrole>(entity =>
            {
                entity.ToTable("acsrole");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Acs).HasColumnName("acs");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Rn).HasColumnName("rn");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('addressid'::regclass)");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(32);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(32);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(32);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(32);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(32);

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Ap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ap");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("ap_employee_id_key");

                entity.HasIndex(e => e.Id)
                    .HasName("ap_id_key");

                entity.HasIndex(e => e.Invnumber)
                    .HasName("ap_invnumber_key");

                entity.HasIndex(e => e.Ordnumber)
                    .HasName("ap_ordnumber_key");

                entity.HasIndex(e => e.Quonumber)
                    .HasName("ap_quonumber_key");

                entity.HasIndex(e => e.Transdate)
                    .HasName("ap_transdate_key");

                entity.HasIndex(e => e.VendorId)
                    .HasName("ap_vendor_id_key");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.Cashdiscount).HasColumnName("cashdiscount");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Datepaid)
                    .HasColumnName("datepaid")
                    .HasColumnType("date");

                entity.Property(e => e.Dcn).HasColumnName("dcn");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("department_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discountterms).HasColumnName("discountterms");

                entity.Property(e => e.Duedate)
                    .HasColumnName("duedate")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Intnotes).HasColumnName("intnotes");

                entity.Property(e => e.Invnumber).HasColumnName("invnumber");

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Netamount).HasColumnName("netamount");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Onhold)
                    .HasColumnName("onhold")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Ordnumber).HasColumnName("ordnumber");

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.PaymentmethodId).HasColumnName("paymentmethod_id");

                entity.Property(e => e.Ponumber).HasColumnName("ponumber");

                entity.Property(e => e.Quonumber).HasColumnName("quonumber");

                entity.Property(e => e.Shippingpoint).HasColumnName("shippingpoint");

                entity.Property(e => e.Shipvia).HasColumnName("shipvia");

                entity.Property(e => e.Taxincluded)
                    .HasColumnName("taxincluded")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Terms)
                    .HasColumnName("terms")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Till)
                    .HasColumnName("till")
                    .HasMaxLength(20);

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e.Waybill).HasColumnName("waybill");
            });

            modelBuilder.Entity<Ar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ar");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("ar_customer_id_key");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("ar_employee_id_key");

                entity.HasIndex(e => e.Id)
                    .HasName("ar_id_key");

                entity.HasIndex(e => e.Invnumber)
                    .HasName("ar_invnumber_key");

                entity.HasIndex(e => e.Ordnumber)
                    .HasName("ar_ordnumber_key");

                entity.HasIndex(e => e.Quonumber)
                    .HasName("ar_quonumber_key");

                entity.HasIndex(e => e.Transdate)
                    .HasName("ar_transdate_key");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.Cashdiscount).HasColumnName("cashdiscount");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Datepaid)
                    .HasColumnName("datepaid")
                    .HasColumnType("date");

                entity.Property(e => e.Dcn).HasColumnName("dcn");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("department_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discountterms).HasColumnName("discountterms");

                entity.Property(e => e.Duedate)
                    .HasColumnName("duedate")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Intnotes).HasColumnName("intnotes");

                entity.Property(e => e.Invnumber).HasColumnName("invnumber");

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Netamount).HasColumnName("netamount");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Onhold)
                    .HasColumnName("onhold")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Ordnumber).HasColumnName("ordnumber");

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.PaymentmethodId).HasColumnName("paymentmethod_id");

                entity.Property(e => e.Ponumber).HasColumnName("ponumber");

                entity.Property(e => e.Quonumber).HasColumnName("quonumber");

                entity.Property(e => e.Shippingpoint).HasColumnName("shippingpoint");

                entity.Property(e => e.Shipvia).HasColumnName("shipvia");

                entity.Property(e => e.Taxincluded).HasColumnName("taxincluded");

                entity.Property(e => e.Terms)
                    .HasColumnName("terms")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Till)
                    .HasColumnName("till")
                    .HasMaxLength(20);

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e.Waybill).HasColumnName("waybill");
            });

            modelBuilder.Entity<Archive>(entity =>
            {
                entity.ToTable("archive");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('archiveid'::regclass)");

                entity.Property(e => e.Filename).HasColumnName("filename");
            });

            modelBuilder.Entity<Archivedata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("archivedata");

                entity.Property(e => e.ArchiveId).HasColumnName("archive_id");

                entity.Property(e => e.Bt).HasColumnName("bt");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.HasOne(d => d.Archive)
                    .WithMany()
                    .HasForeignKey(d => d.ArchiveId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("archivedata_archive_id_fkey");
            });

            modelBuilder.Entity<Assembly>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("assembly");

                entity.HasIndex(e => e.Id)
                    .HasName("assembly_id_key");

                entity.Property(e => e.Adj).HasColumnName("adj");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Bom).HasColumnName("bom");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('assemblyid'::regclass)");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<Audittrail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("audittrail");

                entity.HasIndex(e => e.TransId)
                    .HasName("audittrail_trans_id_key");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Formname).HasColumnName("formname");

                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.Property(e => e.Tablename).HasColumnName("tablename");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bank");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasDefaultValueSql("nextval('addressid'::regclass)");

                entity.Property(e => e.Bic)
                    .HasColumnName("bic")
                    .HasMaxLength(11);

                entity.Property(e => e.Clearingnumber).HasColumnName("clearingnumber");

                entity.Property(e => e.Dcn).HasColumnName("dcn");

                entity.Property(e => e.Iban)
                    .HasColumnName("iban")
                    .HasMaxLength(34);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Membernumber).HasColumnName("membernumber");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64);

                entity.Property(e => e.Qriban)
                    .HasColumnName("qriban")
                    .HasMaxLength(34);

                entity.Property(e => e.Rvc).HasColumnName("rvc");
            });

            modelBuilder.Entity<Br>(entity =>
            {
                entity.ToTable("br");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Apprdate)
                    .HasColumnName("apprdate")
                    .HasColumnType("date");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Batchnumber).HasColumnName("batchnumber");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Managerid).HasColumnName("managerid");

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("business");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Rn).HasColumnName("rn");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cargo");

                entity.HasIndex(e => new { e.Id, e.TransId })
                    .HasName("cargo_id_key");

                entity.Property(e => e.Grossweight).HasColumnName("grossweight");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Netweight).HasColumnName("netweight");

                entity.Property(e => e.Package).HasColumnName("package");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<Chart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("chart");

                entity.HasIndex(e => e.Accno)
                    .HasName("chart_accno_key")
                    .IsUnique();

                entity.HasIndex(e => e.Category)
                    .HasName("chart_category_key");

                entity.HasIndex(e => e.GifiAccno)
                    .HasName("chart_gifi_accno_key");

                entity.HasIndex(e => e.Id)
                    .HasName("chart_id_key");

                entity.HasIndex(e => e.Link)
                    .HasName("chart_link_key");

                entity.Property(e => e.Accno)
                    .IsRequired()
                    .HasColumnName("accno");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Charttype)
                    .HasColumnName("charttype")
                    .HasDefaultValueSql("'A'::bpchar");

                entity.Property(e => e.Closed)
                    .HasColumnName("closed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Contra)
                    .HasColumnName("contra")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GifiAccno).HasColumnName("gifi_accno");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Link).HasColumnName("link");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('contactid'::regclass)");

                entity.Property(e => e.Contacttitle)
                    .HasColumnName("contacttitle")
                    .HasMaxLength(32);

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(32);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'M'::bpchar");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(32);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20);

                entity.Property(e => e.Occupation)
                    .HasColumnName("occupation")
                    .HasMaxLength(32);

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasMaxLength(32);

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Typeofcontact)
                    .HasColumnName("typeofcontact")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Curr>(entity =>
            {
                entity.HasKey(e => e.Curr1)
                    .HasName("curr_pkey");

                entity.ToTable("curr");

                entity.Property(e => e.Curr1)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Prec).HasColumnName("prec");

                entity.Property(e => e.Rn).HasColumnName("rn");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.HasIndex(e => e.Customernumber)
                    .HasName("customer_customernumber_key");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.ArapAccnoId).HasColumnName("arap_accno_id");

                entity.Property(e => e.Bcc).HasColumnName("bcc");

                entity.Property(e => e.BusinessId).HasColumnName("business_id");

                entity.Property(e => e.Cashdiscount).HasColumnName("cashdiscount");

                entity.Property(e => e.Cc).HasColumnName("cc");

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(64);

                entity.Property(e => e.Creditlimit)
                    .HasColumnName("creditlimit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Customernumber)
                    .HasColumnName("customernumber")
                    .HasMaxLength(32);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.DiscountAccnoId).HasColumnName("discount_accno_id");

                entity.Property(e => e.Discountterms).HasColumnName("discountterms");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64);

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PaymentAccnoId).HasColumnName("payment_accno_id");

                entity.Property(e => e.PaymentmethodId).HasColumnName("paymentmethod_id");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepaymentAccnoId).HasColumnName("prepayment_accno_id");

                entity.Property(e => e.PricegroupId).HasColumnName("pricegroup_id");

                entity.Property(e => e.Remittancevoucher).HasColumnName("remittancevoucher");

                entity.Property(e => e.SicCode)
                    .HasColumnName("sic_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Taxincluded)
                    .HasColumnName("taxincluded")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Taxnumber)
                    .HasColumnName("taxnumber")
                    .HasMaxLength(32);

                entity.Property(e => e.Terms)
                    .HasColumnName("terms")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Threshold).HasColumnName("threshold");
            });

            modelBuilder.Entity<Customertax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customertax");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_customer_id_key");

                entity.Property(e => e.ChartId).HasColumnName("chart_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            });

            modelBuilder.Entity<Deduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deduct");

                entity.Property(e => e.DeductionId).HasColumnName("deduction_id");

                entity.Property(e => e.Percent).HasColumnName("percent");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Withholding).HasColumnName("withholding");
            });

            modelBuilder.Entity<Deduction>(entity =>
            {
                entity.ToTable("deduction");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Agedob).HasColumnName("agedob");

                entity.Property(e => e.Basedon).HasColumnName("basedon");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmployeeAccnoId).HasColumnName("employee_accno_id");

                entity.Property(e => e.Employeepays).HasColumnName("employeepays");

                entity.Property(e => e.EmployerAccnoId).HasColumnName("employer_accno_id");

                entity.Property(e => e.Employerpays).HasColumnName("employerpays");

                entity.Property(e => e.Fromage).HasColumnName("fromage");

                entity.Property(e => e.Toage).HasColumnName("toage");
            });

            modelBuilder.Entity<Deductionrate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deductionrate");

                entity.Property(e => e.Above).HasColumnName("above");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Below).HasColumnName("below");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Defaults>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("defaults");

                entity.Property(e => e.Fldname).HasColumnName("fldname");

                entity.Property(e => e.Fldvalue).HasColumnName("fldvalue");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("department");

                entity.HasIndex(e => e.Id)
                    .HasName("department_id_key");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasDefaultValueSql("'P'::bpchar");
            });

            modelBuilder.Entity<DptTrans>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dpt_trans");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.HasIndex(e => e.Login)
                    .HasName("employee_login_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Acs).HasColumnName("acs");

                entity.Property(e => e.AcsroleId).HasColumnName("acsrole_id");

                entity.Property(e => e.Apid).HasColumnName("apid");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Employeenumber)
                    .HasColumnName("employeenumber")
                    .HasMaxLength(32);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Homemobile)
                    .HasColumnName("homemobile")
                    .HasMaxLength(20);

                entity.Property(e => e.Homephone)
                    .HasColumnName("homephone")
                    .HasMaxLength(20);

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64);

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Paymentid).HasColumnName("paymentid");

                entity.Property(e => e.PaymentmethodId).HasColumnName("paymentmethod_id");

                entity.Property(e => e.Payperiod).HasColumnName("payperiod");

                entity.Property(e => e.Sales)
                    .HasColumnName("sales")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Ssn)
                    .HasColumnName("ssn")
                    .HasMaxLength(20);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Workfax)
                    .HasColumnName("workfax")
                    .HasMaxLength(20);

                entity.Property(e => e.Workmobile)
                    .HasColumnName("workmobile")
                    .HasMaxLength(20);

                entity.Property(e => e.Workphone)
                    .HasColumnName("workphone")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Employeededuction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employeededuction");

                entity.Property(e => e.DeductionId).HasColumnName("deduction_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Exempt).HasColumnName("exempt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Maximum).HasColumnName("maximum");
            });

            modelBuilder.Entity<Employeewage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employeewage");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.WageId).HasColumnName("wage_id");
            });

            modelBuilder.Entity<Exchangerate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exchangerate");

                entity.HasIndex(e => new { e.Curr, e.Transdate })
                    .HasName("exchangerate_ct_key");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Exchangerate1).HasColumnName("exchangerate");

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Gifi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gifi");

                entity.HasIndex(e => e.Accno)
                    .HasName("gifi_accno_key")
                    .IsUnique();

                entity.Property(e => e.Accno).HasColumnName("accno");

                entity.Property(e => e.Description).HasColumnName("description");
            });

            modelBuilder.Entity<Gl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gl");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("gl_employee_id_key");

                entity.HasIndex(e => e.Id)
                    .HasName("gl_id_key");

                entity.HasIndex(e => e.Reference)
                    .HasName("gl_reference_key");

                entity.HasIndex(e => e.Transdate)
                    .HasName("gl_transdate_key");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("department_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inventory");

                entity.HasIndex(e => e.PartsId)
                    .HasName("inventory_parts_id_key");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('inventoryid'::regclass)");

                entity.Property(e => e.OrderitemsId).HasColumnName("orderitems_id");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Shippingdate)
                    .HasColumnName("shippingdate")
                    .HasColumnType("date");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.HasIndex(e => e.TransId)
                    .HasName("invoice_trans_id_key");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('invoiceid'::regclass)");

                entity.Property(e => e.Allocated).HasColumnName("allocated");

                entity.Property(e => e.Assemblyitem)
                    .HasColumnName("assemblyitem")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Deliverydate)
                    .HasColumnName("deliverydate")
                    .HasColumnType("date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Fxsellprice).HasColumnName("fxsellprice");

                entity.Property(e => e.Itemnotes).HasColumnName("itemnotes");

                entity.Property(e => e.Kititem)
                    .HasColumnName("kititem")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Lineitemdetail).HasColumnName("lineitemdetail");

                entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.Ponumber).HasColumnName("ponumber");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sellprice).HasColumnName("sellprice");

                entity.Property(e => e.Serialnumber).HasColumnName("serialnumber");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(5);

                entity.Property(e => e.Vendor).HasColumnName("vendor");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");
            });

            modelBuilder.Entity<Jcitems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jcitems");

                entity.HasIndex(e => e.Id)
                    .HasName("jcitems_id_key");

                entity.Property(e => e.Allocated).HasColumnName("allocated");

                entity.Property(e => e.Checkedin)
                    .HasColumnName("checkedin")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Checkedout)
                    .HasColumnName("checkedout")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Fxsellprice).HasColumnName("fxsellprice");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('jcitemsid'::regclass)");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sellprice).HasColumnName("sellprice");

                entity.Property(e => e.Serialnumber).HasColumnName("serialnumber");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("language");

                entity.HasIndex(e => e.Code)
                    .HasName("language_code_key")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(6);

                entity.Property(e => e.Description).HasColumnName("description");
            });

            modelBuilder.Entity<Makemodel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("makemodel");

                entity.HasIndex(e => e.PartsId)
                    .HasName("makemodel_parts_id_key");

                entity.Property(e => e.Make).HasColumnName("make");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");
            });

            modelBuilder.Entity<Mimetype>(entity =>
            {
                entity.HasKey(e => e.Extension)
                    .HasName("mimetype_pkey");

                entity.ToTable("mimetype");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(32);

                entity.Property(e => e.Contenttype)
                    .HasColumnName("contenttype")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Oe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("oe");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("oe_employee_id_key");

                entity.HasIndex(e => e.Id)
                    .HasName("oe_id_key");

                entity.HasIndex(e => e.Ordnumber)
                    .HasName("oe_ordnumber_key");

                entity.HasIndex(e => e.Transdate)
                    .HasName("oe_transdate_key");

                entity.Property(e => e.AaId).HasColumnName("aa_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Backorder)
                    .HasColumnName("backorder")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Closed)
                    .HasColumnName("closed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("department_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Intnotes).HasColumnName("intnotes");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Netamount).HasColumnName("netamount");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Ordnumber).HasColumnName("ordnumber");

                entity.Property(e => e.Ponumber).HasColumnName("ponumber");

                entity.Property(e => e.Quonumber).HasColumnName("quonumber");

                entity.Property(e => e.Quotation)
                    .HasColumnName("quotation")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Reqdate)
                    .HasColumnName("reqdate")
                    .HasColumnType("date");

                entity.Property(e => e.Shippingpoint).HasColumnName("shippingpoint");

                entity.Property(e => e.Shipvia).HasColumnName("shipvia");

                entity.Property(e => e.Taxincluded).HasColumnName("taxincluded");

                entity.Property(e => e.Terms)
                    .HasColumnName("terms")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e.Waybill).HasColumnName("waybill");
            });

            modelBuilder.Entity<Orderitems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orderitems");

                entity.HasIndex(e => e.TransId)
                    .HasName("orderitems_trans_id_key");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('orderitemsid'::regclass)");

                entity.Property(e => e.Itemnotes).HasColumnName("itemnotes");

                entity.Property(e => e.Lineitemdetail).HasColumnName("lineitemdetail");

                entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.Ponumber).HasColumnName("ponumber");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Reqdate)
                    .HasColumnName("reqdate")
                    .HasColumnType("date");

                entity.Property(e => e.Sellprice).HasColumnName("sellprice");

                entity.Property(e => e.Serialnumber).HasColumnName("serialnumber");

                entity.Property(e => e.Ship).HasColumnName("ship");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(5);

                entity.Property(e => e.Vendor).HasColumnName("vendor");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");
            });

            modelBuilder.Entity<Parts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("parts");

                entity.HasIndex(e => e.Id)
                    .HasName("parts_id_key");

                entity.Property(e => e.Alternate)
                    .HasColumnName("alternate")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Assembly)
                    .HasColumnName("assembly")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Avgcost).HasColumnName("avgcost");

                entity.Property(e => e.Barcode).HasColumnName("barcode");

                entity.Property(e => e.Bin).HasColumnName("bin");

                entity.Property(e => e.Bom)
                    .HasColumnName("bom")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Checkinventory)
                    .HasColumnName("checkinventory")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Countryorigin).HasColumnName("countryorigin");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Drawing).HasColumnName("drawing");

                entity.Property(e => e.ExpenseAccnoId).HasColumnName("expense_accno_id");

                entity.Property(e => e.Expires)
                    .HasColumnName("expires")
                    .HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.IncomeAccnoId).HasColumnName("income_accno_id");

                entity.Property(e => e.InventoryAccnoId).HasColumnName("inventory_accno_id");

                entity.Property(e => e.Lastcost).HasColumnName("lastcost");

                entity.Property(e => e.Listprice).HasColumnName("listprice");

                entity.Property(e => e.Lot).HasColumnName("lot");

                entity.Property(e => e.Makemodel)
                    .HasColumnName("makemodel")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Microfiche).HasColumnName("microfiche");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Obsolete)
                    .HasColumnName("obsolete")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Onhand)
                    .HasColumnName("onhand")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Partnumber).HasColumnName("partnumber");

                entity.Property(e => e.PartsgroupId).HasColumnName("partsgroup_id");

                entity.Property(e => e.Priceupdate)
                    .HasColumnName("priceupdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Rop).HasColumnName("rop");

                entity.Property(e => e.Sellprice).HasColumnName("sellprice");

                entity.Property(e => e.TariffHscode).HasColumnName("tariff_hscode");

                entity.Property(e => e.Toolnumber).HasColumnName("toolnumber");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(5);

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<Partscustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("partscustomer");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("partscustomer_customer_id_key");

                entity.HasIndex(e => e.PartsId)
                    .HasName("partscustomer_parts_id_key");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.Pricebreak).HasColumnName("pricebreak");

                entity.Property(e => e.PricegroupId).HasColumnName("pricegroup_id");

                entity.Property(e => e.Sellprice).HasColumnName("sellprice");

                entity.Property(e => e.Validfrom)
                    .HasColumnName("validfrom")
                    .HasColumnType("date");

                entity.Property(e => e.Validto)
                    .HasColumnName("validto")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Partsgroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("partsgroup");

                entity.HasIndex(e => e.Id)
                    .HasName("partsgroup_id_key");

                entity.HasIndex(e => e.Partsgroup1)
                    .HasName("partsgroup_key")
                    .IsUnique();

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Partsgroup1).HasColumnName("partsgroup");

                entity.Property(e => e.Pos)
                    .HasColumnName("pos")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Partstax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("partstax");

                entity.HasIndex(e => e.PartsId)
                    .HasName("partstax_parts_id_key");

                entity.Property(e => e.ChartId).HasColumnName("chart_id");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");
            });

            modelBuilder.Entity<Partsvendor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("partsvendor");

                entity.HasIndex(e => e.PartsId)
                    .HasName("partsvendor_parts_id_key");

                entity.HasIndex(e => e.VendorId)
                    .HasName("partsvendor_vendor_id_key");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Lastcost).HasColumnName("lastcost");

                entity.Property(e => e.Leadtime).HasColumnName("leadtime");

                entity.Property(e => e.Partnumber).HasColumnName("partnumber");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");
            });

            modelBuilder.Entity<PayTrans>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pay_trans");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Glid).HasColumnName("glid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payment");

                entity.Property(e => e.Exchangerate)
                    .HasColumnName("exchangerate")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PaymentmethodId).HasColumnName("paymentmethod_id");

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Paymentmethod>(entity =>
            {
                entity.ToTable("paymentmethod");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.Roundchange).HasColumnName("roundchange");
            });

            modelBuilder.Entity<Payrate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payrate");

                entity.Property(e => e.Above).HasColumnName("above");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Pricegroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pricegroup");

                entity.HasIndex(e => e.Id)
                    .HasName("pricegroup_id_key");

                entity.HasIndex(e => e.Pricegroup1)
                    .HasName("pricegroup_pricegroup_key");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Pricegroup1).HasColumnName("pricegroup");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("project");

                entity.HasIndex(e => e.Id)
                    .HasName("project_id_key");

                entity.HasIndex(e => e.Projectnumber)
                    .HasName("projectnumber_key")
                    .IsUnique();

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.Production)
                    .HasColumnName("production")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Projectnumber).HasColumnName("projectnumber");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Recent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recent");

                entity.HasIndex(e => e.Code)
                    .HasName("recent_code_key");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("recent_employee_id_key");

                entity.HasIndex(e => e.Id)
                    .HasName("recent_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.ObjectId)
                    .HasName("recent_object_id_key");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('recentid'::regclass)");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");
            });

            modelBuilder.Entity<Recentdescr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recentdescr");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("recentdescr_object_id_key")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasDefaultValueSql("''::text");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnName("number")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");
            });

            modelBuilder.Entity<Recurring>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recurring");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Howmany).HasColumnName("howmany");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nextdate)
                    .HasColumnName("nextdate")
                    .HasColumnType("date");

                entity.Property(e => e.Payment)
                    .HasColumnName("payment")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.Property(e => e.Repeat).HasColumnName("repeat");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Recurringemail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recurringemail");

                entity.Property(e => e.Format).HasColumnName("format");

                entity.Property(e => e.Formname).HasColumnName("formname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message).HasColumnName("message");
            });

            modelBuilder.Entity<Recurringprint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recurringprint");

                entity.Property(e => e.Format).HasColumnName("format");

                entity.Property(e => e.Formname).HasColumnName("formname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Printer).HasColumnName("printer");
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.ToTable("reference");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('referenceid'::regclass)");

                entity.Property(e => e.ArchiveId).HasColumnName("archive_id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Folder).HasColumnName("folder");

                entity.Property(e => e.Formname).HasColumnName("formname");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("report");

                entity.Property(e => e.Reportid)
                    .HasColumnName("reportid")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Reportcode).HasColumnName("reportcode");

                entity.Property(e => e.Reportdescription).HasColumnName("reportdescription");
            });

            modelBuilder.Entity<Reportvars>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reportvars");

                entity.Property(e => e.Reportid).HasColumnName("reportid");

                entity.Property(e => e.Reportvalue).HasColumnName("reportvalue");

                entity.Property(e => e.Reportvariable).HasColumnName("reportvariable");
            });

            modelBuilder.Entity<Semaphore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("semaphore");

                entity.Property(e => e.Expires)
                    .HasColumnName("expires")
                    .HasMaxLength(12);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Module).HasColumnName("module");
            });

            modelBuilder.Entity<Shipto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("shipto");

                entity.HasIndex(e => e.TransId)
                    .HasName("shipto_trans_id_key");

                entity.Property(e => e.Shiptoaddress1)
                    .HasColumnName("shiptoaddress1")
                    .HasMaxLength(32);

                entity.Property(e => e.Shiptoaddress2)
                    .HasColumnName("shiptoaddress2")
                    .HasMaxLength(32);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(32);

                entity.Property(e => e.Shiptocontact)
                    .HasColumnName("shiptocontact")
                    .HasMaxLength(64);

                entity.Property(e => e.Shiptocountry)
                    .HasColumnName("shiptocountry")
                    .HasMaxLength(32);

                entity.Property(e => e.Shiptoemail).HasColumnName("shiptoemail");

                entity.Property(e => e.Shiptofax)
                    .HasColumnName("shiptofax")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(64);

                entity.Property(e => e.Shiptophone)
                    .HasColumnName("shiptophone")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptorecurring)
                    .HasColumnName("shiptorecurring")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Shiptostate)
                    .HasColumnName("shiptostate")
                    .HasMaxLength(32);

                entity.Property(e => e.Shiptozipcode)
                    .HasColumnName("shiptozipcode")
                    .HasMaxLength(10);

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Sic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sic");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(6);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Sictype).HasColumnName("sictype");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("status");

                entity.HasIndex(e => e.TransId)
                    .HasName("status_trans_id_key");

                entity.Property(e => e.Emailed)
                    .HasColumnName("emailed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Formname).HasColumnName("formname");

                entity.Property(e => e.Printed)
                    .HasColumnName("printed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Spoolfile).HasColumnName("spoolfile");

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tax");

                entity.Property(e => e.ChartId).HasColumnName("chart_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Taxnumber).HasColumnName("taxnumber");

                entity.Property(e => e.Validto)
                    .HasColumnName("validto")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Translation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("translation");

                entity.HasIndex(e => e.TransId)
                    .HasName("translation_trans_id_key");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(6);

                entity.Property(e => e.TransId).HasColumnName("trans_id");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("vendor");

                entity.HasIndex(e => e.Vendornumber)
                    .HasName("vendor_vendornumber_key");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.ArapAccnoId).HasColumnName("arap_accno_id");

                entity.Property(e => e.Bcc).HasColumnName("bcc");

                entity.Property(e => e.BusinessId).HasColumnName("business_id");

                entity.Property(e => e.Cashdiscount).HasColumnName("cashdiscount");

                entity.Property(e => e.Cc).HasColumnName("cc");

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(64);

                entity.Property(e => e.Creditlimit)
                    .HasColumnName("creditlimit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.DiscountAccnoId).HasColumnName("discount_accno_id");

                entity.Property(e => e.Discountterms).HasColumnName("discountterms");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.GifiAccno)
                    .HasColumnName("gifi_accno")
                    .HasMaxLength(30);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64);

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PaymentAccnoId).HasColumnName("payment_accno_id");

                entity.Property(e => e.PaymentmethodId).HasColumnName("paymentmethod_id");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepaymentAccnoId).HasColumnName("prepayment_accno_id");

                entity.Property(e => e.PricegroupId).HasColumnName("pricegroup_id");

                entity.Property(e => e.Remittancevoucher).HasColumnName("remittancevoucher");

                entity.Property(e => e.SicCode)
                    .HasColumnName("sic_code")
                    .HasMaxLength(6);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Taxincluded)
                    .HasColumnName("taxincluded")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Taxnumber)
                    .HasColumnName("taxnumber")
                    .HasMaxLength(32);

                entity.Property(e => e.Terms)
                    .HasColumnName("terms")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Threshold).HasColumnName("threshold");

                entity.Property(e => e.Vendornumber)
                    .HasColumnName("vendornumber")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Vendortax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vendortax");

                entity.HasIndex(e => e.VendorId)
                    .HasName("vendortax_vendor_id_key");

                entity.Property(e => e.ChartId).HasColumnName("chart_id");

                entity.Property(e => e.VendorId).HasColumnName("vendor_id");
            });

            modelBuilder.Entity<Vr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vr");

                entity.Property(e => e.BrId).HasColumnName("br_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Vouchernumber).HasColumnName("vouchernumber");

                entity.HasOne(d => d.Br)
                    .WithMany()
                    .HasForeignKey(d => d.BrId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("vr_br_id_fkey");
            });

            modelBuilder.Entity<Wage>(entity =>
            {
                entity.ToTable("wage");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ChartId).HasColumnName("chart_id");

                entity.Property(e => e.Defer).HasColumnName("defer");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Exempt)
                    .HasColumnName("exempt")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("warehouse");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('id'::regclass)");

                entity.Property(e => e.Rn).HasColumnName("rn");
            });

            modelBuilder.Entity<Yearend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("yearend");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date");
            });

            modelBuilder.HasSequence("addressid");

            modelBuilder.HasSequence("archiveid");

            modelBuilder.HasSequence("assemblyid");

            modelBuilder.HasSequence("contactid");

            modelBuilder.HasSequence("id");

            modelBuilder.HasSequence("inventoryid");

            modelBuilder.HasSequence("invoiceid");

            modelBuilder.HasSequence("jcitemsid");

            modelBuilder.HasSequence("orderitemsid");

            modelBuilder.HasSequence("recentid");

            modelBuilder.HasSequence("referenceid");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
