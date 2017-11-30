using System;
using System.ComponentModel.DataAnnotations;

namespace okc_quality_reporting.Models
{
    public class ReportData
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public DateTime MonthDate { get; set; }
        public decimal CogsPercent { get; set; }
        public decimal Target { get; set; }
    }
}