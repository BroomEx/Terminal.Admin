using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    public class BaselineCalculation: Entity
    {
        /// <summary>
        /// P_BL_SKUT
        /// </summary>
        public double RealResidualPower { get; set; }
        /// <summary>
        /// BL_PLIMP
        /// </summary>
        public double UpperLimit { get; set; }
        /// <summary>
        /// BL_PLIMM
        /// </summary>
        public double LowerLimit { get; set; }
        /// <summary>
        /// Used Baseline prediction P_BLT
        /// </summary>
        public double BaselineValue { get; set; }

        public int? BaselineId { get; set; }
        public virtual BaselineValue Baseline { get; set; }
    }
}
