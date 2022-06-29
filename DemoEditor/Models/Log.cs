using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEditor.Models
{
    public class Log
    {
        public string Title { get; set; }
        public string QrCode { get; set; }
        public DateTime LogInfoDate { get; set; }
      
        public DateTime FormatDateForGp
        {
            get
            {
                return new DateTime(LogInfoDate.Year, LogInfoDate.Month,01);
            }
        }

        public String ShowDate
        {
            get
            {
                return LogInfoDate.ToString("dd MMM yyyy");
            }
        }
        public string Amount { get; set; }

        public int Number { get; set; }
    }
}
