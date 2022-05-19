using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace crp_api.Models.Entities
{
    public class ReportStatus
    {
        [Key]
        public Guid REPORTSTATUS_ID { get; set; }
        public string? NAME { get; set; }

        public virtual ICollection<Report>? REPORTS { get; set; }

        // public Guid? CREATED_BY { get; set;}
        // public LocalDate? DATE_CREATED {get; set;}
        // public Guid? UPDATED_BY { get; set;}
        // public LocalDate? DATE_UPDATED {get; set;}

    }
}
