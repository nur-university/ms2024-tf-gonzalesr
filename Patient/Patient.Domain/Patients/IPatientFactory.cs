﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Domain.Patients
{
    public interface IPatientFactory
    {
        Patient Create(Guid id, string name, DateTime birthDate, string gender, EmailValue email, List<Phone> phones);
    }
}
