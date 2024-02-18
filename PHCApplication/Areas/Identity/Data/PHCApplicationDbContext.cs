using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Areas.Identity.Data;
using PHCApplication.Models;

namespace PHCApplication.Data
{

      public class PHCApplicationDbContext : IdentityDbContext<ApplicationUser>
      {
        public PHCApplicationDbContext()
        {
        }

        public PHCApplicationDbContext(DbContextOptions<PHCApplicationDbContext> options)
            : base(options)
           {
           }

        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<PrenatalCarePlan> PrenatalCarePlans { get; set; }
        public DbSet<PrenatalPatientReg> PrenatalPatients { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Walk_in> walk_In { get; set; }
        
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Collection> Collection { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Diagnose> Diagnose { get; set; }
        public DbSet<Discharge> Discharge { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<PHCApplication.Models.Patientss>? Patientss { get; set; }
        public DbSet<MedicalRecord> MedicalRecord { get; set; }
        public DbSet<MedicalTest> MedicalTest { get; set; }
        public DbSet<Medication> Medication { get; set; }
        //public DbSet<Patient> Patient { get; set; }
        public DbSet<Pharmacist> Pharmacist { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<Referral> Referral { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Reminder> Reminder { get; set; }
        public DbSet<BookingApproval> BookingApproval { get; set; }

        public DbSet<Details> Detail { get; set; }
        public DbSet<ChatFeedback> ChatFeedback { get; set; }

        public DbSet<OrderVacc> OrderVacc { get; set; }
        public DbSet<PrenatalAppointment> PrenatalApp { get; set; }
        public DbSet<PHCApplication.Models.CollectionChronic>? CollectionChronic { get; set; }
        public DbSet<PHCApplication.Models.CounsellingPrescroption>? CounsellingPrescroption { get; set; }
        public DbSet<PHCApplication.Models.Examination>? Examination { get; set; }
        public DbSet<PHCApplication.Models.MedicalHistory>? MedicalHistory { get; set; }
        public DbSet<PHCApplication.Models.ReferralsCounselling>? ReferralsCounselling { get; set; }
        public DbSet<PHCApplication.Models.MedicalProcedureFile>? MedicalProcedureFile { get; set; }




        public DbSet<Appoint> Appoints { get; set; }
        public DbSet<RatingReview> Ratings { get; set; }
        public DbSet<ReportEvent> Events { get; set; }
        public DbSet<VaccineAvail> AvailVacc { get; set; }
        public DbSet<GenCert> GenCert { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");
            builder.Entity<IdentityUser>(entity => { entity.ToTable(name: "User"); });
            builder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Role"); });
            builder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRoles"); });
            builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
            builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
            builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });
            builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
        }



    }
}
