using PatientManagement.Domain.Abstractions;
using PatientManagement.Domain.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMangement.Domain.Consultations
{
    public class InitialConsultation: AggregateRoot
    {
        public Guid PatientId { get; private set; }
        public DateTime Date { get; private set; }
        public string Reason { get; private set; }
        public string Observations { get; private set; }

        public InitialConsultation(Guid id, Guid patientId, DateTime date, string reason, string observations): base(id)
        {
            PatientId = patientId;
            Date = date;
            Reason = reason ?? throw new ArgumentNullException(nameof(reason));
            Observations = observations ?? throw new ArgumentNullException(nameof(observations));
        }

        // Método para actualizar las observaciones
        public void UpdateObservations(string observations)
        {
            if (string.IsNullOrWhiteSpace(observations))
                throw new ArgumentException("Las observaciones no pueden estar vacías.", nameof(observations));

            Observations = observations;
        }
    }
}
