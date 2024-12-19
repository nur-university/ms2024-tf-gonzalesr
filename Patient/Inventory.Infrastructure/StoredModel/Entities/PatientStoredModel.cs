using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientManagement.Domain.Patients;

namespace PatientManagement.Infrastructure.StoredModel.Entities
{
    [Table("patient")]
    internal class PatientStoredModel
    {
        [Key]
        [Column("patientId")]
        public Guid Id { get; set; }

        [Column("name")]
        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [Column("birthDate")]
        [Required]
        public DateTime BirthDate { get; set; }

        [Column("gender")]
        [Required]
        public string Gender { get; set; }

        [Column("email")]
        [Required]
        public string Email { get; set; }

        public List<PatientPhone> Phone { get; set; }
    }
}
