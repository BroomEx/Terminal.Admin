using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    [Index(nameof(TimeStamp))]

    public class InstructionCall: Entity
    {
        public InstructionCall()
        {
            ActivePowerUnits = new HashSet<ActivePowerUnit>();
            ActiveAns = new HashSet<ActiveAns>();
        }
        public int AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Pdg_trend { get; set; }
        public double mFRR_act { get; set; }
        public double mFRR5_act { get; set; }
        public double Psetp_del { get; set; }
        public double P_lowbnd { get; set; }
        public double P_uppbnd { get; set; }
        public double mFRR_DAP { get; set; }
        public double mFRR_DAM { get; set; }
        public double mFRR_SAP { get; set; }
        public double mFRR_SAM { get; set; }
        public double aFRR { get; set; }
        public double aFRR_act { get; set; }
        public bool FinalPowerChanged { get; set; }
        public ICollection<ActivePowerUnit> ActivePowerUnits { get; set; }
        public ICollection<ActiveAns> ActiveAns { get; set; }
    }

    public record ActiveAns(string Ans, int Slot);
    public record ActivePowerUnit(int PowerUnitId);
}
