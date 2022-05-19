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
        public Guid? CREATED_BY { get; set;}
        public LocalDate? DATE_CREATED {get; set;}
        public Guid? UPDATED_BY { get; set;}
        public LocalDate? DATE_UPDATED {get; set;}


    }
}
