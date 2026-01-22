using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    public class FinishedChange: Entity
    {
        public int? AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }
        public SupportService SupportService { get; set; }
        public double Value { get; set; }
    }
}
