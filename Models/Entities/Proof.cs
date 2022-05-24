using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NodaTime;

namespace crp_api.Models.Entities
{
    public class Proof
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PROOF_ID { get; set; }

#nullable enable
        public string? NAME { get; set; }

        public string? URL { get; set; }

        public string? REMARKS { get; set; }

        public Instant? DATE_CREATED { get; set; }

        public Guid? CREATED_BY { get; set; }

        public Instant? DATE_UPDATED { get; set; }

        public Guid? UPDATED_BY { get; set; }
        public bool? IS_ACTIVE { get; set; }

        public Guid? REPORT_ID { get; set; }

        public Report? REPORT { get; set; }

    }
}