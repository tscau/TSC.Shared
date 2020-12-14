using System;
using System.Collections.Generic;
using System.Text;

namespace TSC.Shared
{
    public class Flags
    {
        public Flags()
        {
            AllowDataRetrieve = true;
            AllowDataUpdate = true;
            AllowSendEmail = true;
            AllowSendOther = true;
            AllowSendPaper = true;
            AllowSendSMS = true;
            AllowPdfConsolidation = true;
            AllowPSCOnsolidation = true;
        }
        public bool? AllowDataRetrieve { get; set; }
        public bool? AllowDataUpdate { get; set; }
        public bool? AllowSendEmail { get; set; }
        public bool? AllowSendSMS { get; set; }
        public bool? AllowSendPaper { get; set; }
        public bool? AllowSendOther { get; set; }
        public bool? AllowPSCOnsolidation { get; set; }
        public bool? AllowPdfConsolidation { get; set; }
    }
}
