using Microsoft.EntityFrameworkCore;
using System;
using Terminal.Admin.Data.Models.Shared;
using Terminal.Admin.Data.Enums;

namespace Terminal.Admin.Data.Models
{
    [Index(nameof(TimeStamp))]
    [Index(nameof(MessageType))]
    [Index(nameof(TimeStamp), nameof(PowerUnitId))]
    [Index(nameof(TimeStamp), nameof(AggregationBlockId))]
    public class TelemetryLog: Entity
    {
        public CepsMessageType MessageType { get; set; }
        public string MessageTypeName { get; set; }

        public DateTime TimeStamp { get; set; }
        public double Value { get; set; }
        public int? AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }

        public int P104Address { get; set; }
        public int? PowerUnitId { get; set; }
        public virtual PowerUnit PowerUnit { get; set; }

    }
}
