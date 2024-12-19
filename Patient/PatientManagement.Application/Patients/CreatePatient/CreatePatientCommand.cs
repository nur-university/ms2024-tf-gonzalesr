using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientManagement.Domain.Patients;

namespace PatientManagement.Application.Patients.CreatePatient
{
    public record CreatePatientCommand(Guid Id, string name, DateTime birthDate, string gender, EmailValue email, List<Phone> phones) : IRequest<Guid>;
}
