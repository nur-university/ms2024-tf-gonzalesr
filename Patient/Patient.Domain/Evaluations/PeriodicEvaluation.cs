using PatientManagement.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Domain.Evaluations
{
    public class PeriodicEvaluation : AggregateRoot
    {
        public Guid PatientId { get; private set; }
        public DateTime Date { get; private set; }
        public string EvaluationNotes { get; private set; }
        public HealthMetrics Metrics { get; private set; }

        public PeriodicEvaluation(Guid id, Guid patientId, DateTime date, string evaluationNotes, HealthMetrics metrics) : base(id)
        {
            PatientId = patientId;
            Date = date;
            EvaluationNotes = evaluationNotes ?? throw new ArgumentNullException(nameof(evaluationNotes));
            Metrics = metrics ?? throw new ArgumentNullException(nameof(metrics));
        }
        public void UpdateEvaluationNotes(string evaluationNotes)
        {
            if (string.IsNullOrWhiteSpace(evaluationNotes))
                throw new ArgumentException("Las notas de la evaluación no pueden estar vacías.", nameof(evaluationNotes));

            EvaluationNotes = evaluationNotes;
        }
        public void UpdateMetrics(HealthMetrics metrics)
        {
            Metrics = metrics ?? throw new ArgumentNullException(nameof(metrics));
        }
    }
}
