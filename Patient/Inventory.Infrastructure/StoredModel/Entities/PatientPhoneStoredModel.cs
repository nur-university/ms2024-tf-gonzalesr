using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Infrastructure.StoredModel.Entities
{
    [Table("patientPhone")]
    internal class PatientPhoneStoredModel
    {
        [Key]
        [Column("patiendPhoneId")]
        public Guid Id { get; set; }

        [Required]
        [Column("patientId")]
        public Guid PatiendId { get; set; }
        public PatientStoredModel Patient { get; set; }

        [Required]
        [Column("number")]
        public string Number { get; set; }
    }
}
