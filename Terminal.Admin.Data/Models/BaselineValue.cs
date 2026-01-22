using Microsoft.EntityFrameworkCore;
using System;
using Terminal.Admin.Data.Enums;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    [Index(nameof(TimeStamp))]
    public class BaselineValue: Entity
    {
        public BaselineType Type { get; set; }
        public double Value { get; set; }
        public DateTime TimeStamp { get; set; }
        public int? AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }
    }
}
