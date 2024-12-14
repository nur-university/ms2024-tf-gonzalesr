using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Domain.Evaluations
{
    public class HealthMetrics
    {
        public float Weight { get; private set; }
        public float Height { get; private set; }
        public string BloodPressure { get; private set; }
        public int HeartRate { get; private set; }

        public HealthMetrics(float weight, float height, string bloodPressure, int heartRate)
        {
            if (weight <= 0)
                throw new ArgumentException("El peso debe ser mayor a cero.", nameof(weight));

            if (height <= 0)
                throw new ArgumentException("La altura debe ser mayor a cero.", nameof(height));

            if (string.IsNullOrWhiteSpace(bloodPressure))
                throw new ArgumentException("La presión arterial no puede estar vacía.", nameof(bloodPressure));

            if (heartRate <= 0)
                throw new ArgumentException("La frecuencia cardíaca debe ser mayor a cero.", nameof(heartRate));

            Weight = weight;
            Height = height;
            BloodPressure = bloodPressure;
            HeartRate = heartRate;
        }

        public float CalculateBMI()
        {
            return Weight / (Height * Height);
        }
        public override string ToString()
        {
            return $"Peso: {Weight} kg, Altura: {Height} m, Presión Arterial: {BloodPressure}, Frecuencia Cardíaca: {HeartRate} bpm";
        }

    }
}
