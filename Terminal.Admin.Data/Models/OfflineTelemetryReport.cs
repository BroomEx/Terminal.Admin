using Newtonsoft.Json;
using System;
using Terminal.Admin.Data.Models.Shared;
using Terminal.Admin.Data.Enums;

namespace Terminal.Admin.Data.Models
{
    public class OfflineTelemetryReport: Entity
    {
        public int? AggregationBlockId { get; set; }
        public virtual AggregationBlock AggregationBlock { get; set; }
        public DateTime? ArchiveCreated { get; set; }
        public DateTime? ArchiveUploaded { get; set; }
        public DateTime? ArchiveConfirmedTime { get; set; }
        public int ArchiveUploadAttempts { get; set; }
        public DateTime? CompositionCreated { get; set; }
        public DateTime? CompositionUploaded { get; set; }
        public DateTime? CompositionConfirmedTime { get; set; }
        public int CompositionUploadAttempts { get; set; }
        public string ArchiveRequestId { get; set; }
        public string CompositionRequestId { get; set; }
        public OfflineTelemetryStatus Status { get; set; }
        public int Position { get; set; }
        public string Error { get; set; }
        public ReportFile ArchiveFile { get; set; }
        public ReportFile AbCompositionFile { get; set; }
        public string CepsUrl { get; set; }
        public DateTime TimeStamp { get; set; }

        public OfflineTelemetryReport()
        {
            TimeStamp = DateTime.UtcNow;
        }
        public DateTime? ArchiveCreatedTimeLocal
        {
            get
            {
                if (ArchiveCreated is null)
                {
                    return null;
                }

                return TimeZoneInfo.ConvertTimeFromUtc(ArchiveCreated ?? default(DateTime), TimeZoneInfo.FindSystemTimeZoneById(AggregationBlock.TimeZoneId));
            }
        }

        public DateTime? ArchiveUploadedTimeLocal
        {
            get
            {
                if (ArchiveUploaded is null)
                {
                    return null;
                }

                return TimeZoneInfo.ConvertTimeFromUtc(ArchiveUploaded ?? default(DateTime), TimeZoneInfo.FindSystemTimeZoneById(AggregationBlock.TimeZoneId));
            }
        }

        public DateTime? ArchiveConfirmedTimeLocal
        {
            get
            {
                if (ArchiveConfirmedTime is null)
                {
                    return null;
                }

                return TimeZoneInfo.ConvertTimeFromUtc(ArchiveConfirmedTime ?? default(DateTime), TimeZoneInfo.FindSystemTimeZoneById(AggregationBlock.TimeZoneId));
            }
        }

        public DateTime? CompositionCreatedTimeLocal
        {
            get
            {
                if (CompositionCreated is null)
                {
                    return null;
                }

                return TimeZoneInfo.ConvertTimeFromUtc(CompositionCreated ?? default(DateTime), TimeZoneInfo.FindSystemTimeZoneById(AggregationBlock.TimeZoneId));
            }
        }

        public DateTime? CompositionUploadedTimeLocal
        {
            get
            {
                if (CompositionUploaded is null)
                {
                    return null;
                }

                return TimeZoneInfo.ConvertTimeFromUtc(CompositionUploaded ?? default(DateTime), TimeZoneInfo.FindSystemTimeZoneById(AggregationBlock.TimeZoneId));
            }
        }

        public DateTime? CompositionConfirmedTimeLocal
        {
            get
            {
                if (CompositionConfirmedTime is null)
                {
                    return null;
                }

                return TimeZoneInfo.ConvertTimeFromUtc(CompositionConfirmedTime ?? default(DateTime), TimeZoneInfo.FindSystemTimeZoneById(AggregationBlock.TimeZoneId));
            }
        }
    }
}
