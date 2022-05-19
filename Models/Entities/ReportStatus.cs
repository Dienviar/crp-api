using System.ComponentModel.DataAnnotations;
namespace crp_api.Models.Entities
{
    public class ReportStatus
    {
        [Key]
        public Guid REPORTSTATUS_ID { get; set; }
        public string? NAME { get; set; }

        public virtual ICollection<Report>? REPORTS { get; set; }

    }
}
