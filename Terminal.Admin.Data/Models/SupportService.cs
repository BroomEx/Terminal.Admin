using System.Collections.Generic;
using Terminal.Admin.Data.Models.Shared;
using Terminal.Admin.Data.Enums;

namespace Terminal.Admin.Data.Models
{
    public class SupportService: Entity
    {
        public SupportServiceType Service { get; set; }
        public string  ServiceName { get; set; }
        public ICollection<AggregationBlock> AggregationBlocks { get; set; }
    }
}
