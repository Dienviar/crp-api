using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace crp_api.Models.Entities
{
    public class User
    {

        [Key]
        public Guid USER_ID { get; set; }
        public string? FNAME { get; set; }
        public string? LNAME { get; set; }
        public string? EMAIL { get; set; }

        public virtual ICollection<Report>? REPORTS { get; set; }

        public Guid? ROLE_ID { get; set; }

        public crp_apiRole? ROLE { get; set; }
        public Guid? CREATED_BY { get; set; }
        public Instant? DATE_CREATED { get; set; }
        public Guid? UPDATED_BY { get; set; }
        public Instant? DATE_UPDATED { get; set; }
        public bool? IS_ACTIVE { get; set; }


    }
}
