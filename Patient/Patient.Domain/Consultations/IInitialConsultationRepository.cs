using PatientManagement.Domain.Abstractions;
using PatientMangement.Domain.Consultations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Domain.Consultations
{
    public interface IInitialConsultationRepository: IRepository<InitialConsultation>
    {
        Task<IEnumerable<InitialConsultation>> GetByPatientIdAsync(Guid patientId);
        Task<IEnumerable<InitialConsultation>> GetByDateAsync(DateTime date);
    }
}
