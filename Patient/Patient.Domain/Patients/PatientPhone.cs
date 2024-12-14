using PatientManagement.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Domain.Patients
{
    public class PatientPhone : Entity
    {
        public Guid PatientId { get; private set; }
        public string Number { get; private set; }
        public PatientPhone(Guid patientId, string number) : base(Guid.NewGuid())
        {
            PatientId = patientId;
            Number = number;
        }

        //Need for EF Core
        private PatientPhone() { }
    }
}
