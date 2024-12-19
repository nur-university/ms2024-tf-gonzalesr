using PatientManagement.Domain.Abstractions;
using PatientManagement.Domain.Patients.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Domain.Patients
{
    public class Patient:AggregateRoot
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Gender { get; private set; }
        public EmailValue Email { get; private set; }
        public List<Phone> Phones { get; private set; } = new();

        public Patient(Guid id, string name, DateTime birthDate, string gender, EmailValue email): base(id)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            BirthDate = birthDate;
            Gender = gender ?? throw new ArgumentNullException(nameof(gender));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }
    }
}
