using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace crp_api.Models.Entities
{
    public class ReportType
    {
        [Key]
        public Guid REPORTTYPE_ID { get; set; }
        public string? NAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public virtual ICollection<Report>? REPORTS { get; set; }
        public Guid? CREATED_BY { get; set; }
        public Instant? DATE_CREATED { get; set; }
        public Guid? UPDATED_BY { get; set; }
        public Instant? DATE_UPDATED { get; set; }
        public bool? IS_ACTIVE { get; set; }
    }
}
