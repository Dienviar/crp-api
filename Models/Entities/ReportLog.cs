using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace crp_api.Models.Entities
{
    public class ReportLog
    {
        [Key]
        public Guid REPORTLOG_ID { get; set; }
        public string? NAME { get; set; }
        public string? DESCRIPTION { get; set; }

        public Guid? REPORT_ID { get; set; }
        public Report? REPORT { get; set; }
        // public Guid? CREATED_BY { get; set;}
        // public LocalDate? DATE_CREATED {get; set;}
        // public Guid? UPDATED_BY { get; set;}
        // public LocalDate? DATE_UPDATED {get; set;}
    }
}
