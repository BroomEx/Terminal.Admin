using Microsoft.EntityFrameworkCore;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<PowerUnit> PowerUnits { get; set; }
        public virtual DbSet<AggregationBlock> AggregationBlocks { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<CertificationTest> CertificationTests { get; set; }
        public virtual DbSet<TelemetryLog> TelemetryLogs { get; set; }
        public virtual DbSet<PowerCalculation> PowerCalculations { get; set; }
        public virtual DbSet<FinishedChange> FinishedChanges { get; set; }
        public virtual DbSet<CepsRequiredPower> CepsRequiredPowers { get; set; }
        public virtual DbSet<AggregationBlockPowerState> AggregationBlockPowerStates { get; set; }
        public virtual DbSet<OfflineTelemetryReport> OfflineTelemetryReports { get; set; }
        public virtual DbSet<ReportFile> ReportFiles { get; set; }
        public virtual DbSet<ApplicationLog> ApplicationLogs { get; set; }
        public virtual DbSet<InstructionCall> InstructionCalls { get; set; }
        public virtual DbSet<BaselineValue> BaselineValues { get; set; }
        public virtual DbSet<BaselineCalculation> BaselineCalculations { get; set; }
        public virtual DbSet<OperationPlanSlot> OperationPlanSlots { get; set; }
        public virtual DbSet<SupportService> SupportService { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuiler)
        {
            modelBuiler.Entity<InstructionCall>().OwnsMany(
                InstructionCall => InstructionCall.ActivePowerUnits,
                ownedNavigationBuilder =>
                {
                    ownedNavigationBuilder.ToJson();
                });

            modelBuiler.Entity<InstructionCall>().OwnsMany(
                InstructionCall => InstructionCall.ActiveAns,
                ownedNavigationBuilder => {
                    ownedNavigationBuilder.ToJson();
                });

            modelBuiler.Entity<OperationPlanSlot>().OwnsMany(
                OperationPlanSlot => OperationPlanSlot.PowerUnitsActivity,
                ownedNavigationBuilder =>
                {
                    ownedNavigationBuilder.ToJson();
                });

            base.OnModelCreating(modelBuiler);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var auditedEntries = ChangeTracker
                .Entries()
                .Where(e => typeof(AuditedEntity).IsAssignableFrom(e.Entity.GetType()));

            foreach (var entityEntry in auditedEntries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    ((AuditedEntity)entityEntry.Entity).CreationTime = DateTime.UtcNow;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.LogTo(x =>
            //{
            //    Debug.WriteLine(x);
            //});

            base.OnConfiguring(optionsBuilder);
        }
    }
}
