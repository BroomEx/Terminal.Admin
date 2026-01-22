using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    [Index(nameof(FromDate), nameof(ToDate))]
    public class OperationPlanSlot: Entity
    {
        public OperationPlanSlot()
        {
            PowerUnitsActivity = new HashSet<OperationPlanSlotPowerUnitActivity>();
        }

        public OperationPlanSlot(AggregationBlock block, DateTime from, DateTime date, int slot)
        {

            AggregationBlockId = block.Id;
            Slot = slot;
            FromDate = from;
            ToDate = from.AddMinutes(15);
            Date = date.Date;
            PowerUnitsActivity = block.PowerUnits.Select(pu => new OperationPlanSlotPowerUnitActivity
            {
                PowerUnitId = pu.Id,
                IsActive = false
            }).ToList();

        }

        public int Slot { get; set; }
        public int AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }
        public DateTime Date { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public double Pdg { get; set; }
        public double Afrr_positive { get; set; }
        public double Afrr_negative { get; set; }
        public double Mfrr_12_positive { get; set; }
        public double Mfrr_12_positive_mb { get; set; }
        public double Mfrr_12_negative { get; set; }
        public double Mfrr_12_negative_mb { get; set; }
        public double Mfrr_5 { get; set; }
        public bool UseBaseline { get; set; }
        public ICollection<OperationPlanSlotPowerUnitActivity> PowerUnitsActivity { get; set; }
    }

    public record OperationPlanSlotPowerUnitActivity
    {
        public int PowerUnitId { get; set; }
        public bool IsActive { get; set; }
    }
}
