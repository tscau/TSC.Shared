using System;

namespace TSC.Shared
{
    public class CommonMessageFormat
    {

        public CommonMessageFormat()
        {
            ScheduleID = Guid.NewGuid();
            JSScheduleId = Guid.NewGuid();
            BatchId = 0;
            JobPath = string.Empty;
            TemplateId = string.Empty;
            StatusToProcess = 0;
            IsConsolidationJob = false;
            Flags = new Flags();
        }

        public Guid ScheduleID { get; set; }
        public Guid JSScheduleId { get; set; }
        public long BatchId { get; set; }
        public string JobPath { get; set; }
        public string TemplateId { get; set; }
        public int StatusToProcess { get; set; }
        public bool IsConsolidationJob { get; set; }

        public Flags Flags { get; set; }
    }
}
