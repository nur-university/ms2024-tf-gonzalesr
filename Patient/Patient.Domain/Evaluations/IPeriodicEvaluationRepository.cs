using PatientManagement.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Domain.Evaluations
{
    public interface IPeriodicEvaluationRepository : IRepository<PeriodicEvaluation>
    {
        Task<IEnumerable<PeriodicEvaluation>> GetByPatientIdAsync(Guid patientId);
        Task<IEnumerable<PeriodicEvaluation>> GetByDateAsync(DateTime date);

    }
}
