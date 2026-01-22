using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Terminal.Admin.Data.Models.Shared;
using Terminal.Admin.Data.Enums;

namespace Terminal.Admin.Data.Models
{
    [Index(nameof(TimeStamp))]
    public class PowerCalculation: Entity
    {
        public int AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }

        public SupportServiceType ServiceType { get; set; }
        public DateTime TimeStamp { get; set; }
        public double TrendedPower { get; set; }
        public double UpperLimit { get; set; }
        public double LowerLimit { get; set; }
        public double AllowedDeviation { get; set; }
        public double ReportedPower { get; set; }
        public double OfferedPowerMax { get; set; }
        public double OfferedPowerMin { get; set; }
        public int? CepsRequiredPowerId { get; set; }
        public virtual CepsRequiredPower CepsRequiredPower { get; set; }
        public virtual ICollection<AggregationBlockPowerState> AggregationBlockPowerStates { get; set; }
    }
}
