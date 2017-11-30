using Microsoft.EntityFrameworkCore;

namespace okc_quality_reporting.Models
{
    public class okc_quality_reportingContext : DbContext
    {
        public okc_quality_reportingContext (DbContextOptions<okc_quality_reportingContext> options)
            : base(options)
        {            
        }

        public DbSet<okc_quality_reporting.Models.ReportData> ReportData { get; set; }
    }
}