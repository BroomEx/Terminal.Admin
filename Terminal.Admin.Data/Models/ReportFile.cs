using System;
using Terminal.Admin.Data.Enums;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{

    public class ReportFile: AuditedEntity
    {
        private const string ReportPath = "{0}_{1}_{2:yyyyMMddHHmm}_{3:yyyyMMddHHmm}.{4}";
        private const string RealFilePath = "{0}/{1}_{2:yyyyMMddHHmm}_{3:yyyyMMddHHmm}-{4}.{5}";

        public string FileName { get
            {
                return string.Format(ReportPath, Enum.GetName(ReportType), AbId, FromTime, ToTime, Suffix);
            }
        }

        public string FilePath
        {
            get
            {
                return string.Format(RealFilePath, Folder, AbId, FromTime, ToTime, GuidStr, Suffix);
            }
        }

        public string GuidStr { get; set; }
        public string MimeType { get; set; }
        public int AbId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public FileTaskState Status { get; set; }
        public DateTime Finished { get; set; }
        public ReportType ReportType { get; set; }
        public string Folder { get; set; }
        public string Suffix { get; set; }
        public string Note { get; set; }

        public ReportFile() {
            GuidStr = Guid.NewGuid().ToString();
        }
    }
}
