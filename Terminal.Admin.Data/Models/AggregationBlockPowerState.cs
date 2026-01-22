using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    [Index(nameof(TimeStamp))]

    public class AggregationBlockPowerState: Entity
    {
        public int? AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }
        public DateTime TimeStamp { get; set; }
        public double RealPower { get; set; }
        public double PdgTrend { get; set; }
        public double PVS { get; set; }
        public virtual ICollection<PowerCalculation> Calculations { get; set; }
        public int? BaselineCalculationId { get; set; }
        public virtual BaselineCalculation BaselineCalculation { get; set; }
    }
}
