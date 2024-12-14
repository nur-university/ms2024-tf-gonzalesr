﻿using PatientManagement.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Domain.Patients
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Task UpdateAsync(EmailValue email);
        Task DeleteAsync(Guid id);
    }
}