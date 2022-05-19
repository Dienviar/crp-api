using System.ComponentModel.DataAnnotations;
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

    }
}
