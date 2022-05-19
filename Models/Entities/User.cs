using System.ComponentModel.DataAnnotations;
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
        


    }
}
