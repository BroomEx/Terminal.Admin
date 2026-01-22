using System.Collections.Generic;
using Terminal.Admin.Data.Enums;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    public class PowerUnit : Entity
    {
        public PowerUnit()
        {
            AggregationBlocks = new HashSet<AggregationBlock>();
        }

        public string ControlSystemId  { get; set; }
        public int CepsId { get; set; }
        public string PowerUnitCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Power { get; set; }
        public bool FcrProvisioning { get; set; }
        public DeviceCategory DeviceCategory { get; set; }
        public ICollection<AggregationBlock> AggregationBlocks { get; set; }
        public ICollection<TelemetryLog> Telemetry { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
