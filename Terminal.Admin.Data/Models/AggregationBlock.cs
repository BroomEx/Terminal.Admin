using System;
using System.Collections.Generic;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    public class AggregationBlock : Entity
    {
        public AggregationBlock()
        {
            PowerUnits = new HashSet<PowerUnit>();
            SupportServices = new HashSet<SupportService>();
            BaselineValues = new HashSet<BaselineValue>();
        }

        public string ControlSystemId { get; set; }
        public int CepsId { get; set; }
        public string Cepsname { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TimeZoneId { get; set; }
        public bool IsActive { get; set; }
        public double PowerDivider { get; set; }
        public string ProviderEAN { get; set; }
        public bool BaselineSupport { get; set; }
        public bool ExternalOperationPlanSource { get; set; }
        public string InsCallUrl { get; set; }
        public virtual ICollection<PowerUnit> PowerUnits { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<SupportService> SupportServices { get; set; }
        public ICollection<CertificationTest> CertificationsTests { get; set;}
        public ICollection<TelemetryLog> Telemetry { get; set; }
        public ICollection<PowerCalculation> Calculations { get; set; }
        public ICollection<FinishedChange> FinishedChanges { get; set; }
        public ICollection<CepsRequiredPower> RequiredPowers { get; set; }
        public ICollection<BaselineValue> BaselineValues { get; set; }
        public ICollection<AggregationBlockPowerState> AggregationBlockPowerStates { get; set; }
        public ICollection<OfflineTelemetryReport> OfflineTelemetryReports { get; set; }


        public bool CepsDisconnected { get; set; }

        public DateTime LocalTime
        {
            get
            {
                return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(TimeZoneId));
            }
        }
}
}
