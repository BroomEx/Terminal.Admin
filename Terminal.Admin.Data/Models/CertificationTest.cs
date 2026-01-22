using System;
using Terminal.Admin.Data.Enums;
using Terminal.Admin.Data.Models.Shared;


namespace Terminal.Admin.Data.Models
{
    public class CertificationTest: Entity
    {
        public int AggregationBlockId { get; set; }
        public AggregationBlock AggregationBlock { get; set; }
        public int SupportServiceId { get; set; }
        public SupportService SupportService { get; set; }
        public CertificationtestStatus Status { get; set; }
        public DateTime? CertificationStart { get; set; }
        public DateTime? CertificationEnd { get; set; }
        public int? ReportFileId { get; set; }
        public virtual ReportFile ReportFile { get; set; }
        public double Pdg { get; set; }    
        public double ActivationPower { get; set; }
        public double Trend { get; set; }
    }
}
