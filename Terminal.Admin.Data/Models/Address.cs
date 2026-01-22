
using Terminal.Admin.Data.Enums;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    public class Address : Entity
    {
        public int P104Address { get; set; }
        public DeviceType DeviceType { get; set; }
        public CepsMessageType MessageType { get; set; }
        public AddressValueType AddressValueType { get; set; }
        public MessageDirection Direction { get; set; }
        public int Multiplicator { get; set; }
        public int Decimals { get; set; }
        public bool IsActive { get; set; }
        public int? AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }
        public int? PowerUnitId { get; set; }
        public virtual PowerUnit PowerUnit { get; set; }
        public bool SendAlways { get; set; }
    }
}
