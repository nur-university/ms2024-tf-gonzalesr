using PatientManagement.Domain.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatientManagement.Domain.Patients
{
    public class Phone : AggregateRoot
    {
        public string Number { get; private set; }
        public Phone(Guid id, string number) : base(id)
        {
            Number = number;
        }
        public Phone(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("El número de teléfono no puede estar vacío.", nameof(number));

            Number = number;
        }
        //Need for EF Core
        private Phone() { }

    }
}
