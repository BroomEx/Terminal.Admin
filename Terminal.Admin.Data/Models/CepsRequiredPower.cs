using Microsoft.EntityFrameworkCore;
using System;
using Terminal.Admin.Data.Models.Shared;
using System.Linq;
using System.Collections.Generic;
using Terminal.Admin.Data.Enums;

namespace Terminal.Admin.Data.Models
{
    [Index(nameof(TimeStamp))]
    public class CepsRequiredPower: Entity
    {
        public CepsRequiredPower()
        {
            Calculations = new HashSet<PowerCalculation>();
        }
        public int AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }
        public SupportServiceType ServiceType { get; set; }
        public double Power { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime? LastDirectionChange { get; set; }
        public ICollection<PowerCalculation> Calculations { get; set; }
    }
}
