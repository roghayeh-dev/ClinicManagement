using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement
{
    internal class PatientManager
    {
        private static List<Patient> _patients = new List<Patient>();

        public List<Patient> GetPatients()
        {
            return new List<Patient>(_patients);
        }

        public Result AddPatient(Patient patient)
        {
            if (patient == null)
                return Result.Failed("اطلاعات بیمار نامعتبر است.");

            var validate = patient.Validate();

            if (!validate.Success)
            {
                return Result.Failed(validate.Message);
            }

            _patients.Add(patient);

            return Result.Ok();
        }

        public Result UpdatePatient(Patient patient)
        {
            // TODO: Implement later
            return Result.Ok();
        }

        public Result DeletePatient(Patient patient)
        {
            if (patient == null || !_patients.Contains(patient))
                return Result.Failed("بیمار مورد نظر یافت نشد.");

            _patients.Remove(patient);

            return Result.Ok();
        }

        public List<Patient> SearchPatient(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return new List<Patient>(_patients);

            return _patients
                .Where(p =>
                    p.FirstName.Contains(searchText) ||
                    p.LastName.Contains(searchText) ||
                    p.NationalCode.Contains(searchText) ||
                    p.MobileNumber.Contains(searchText))
                .ToList();
        }

        internal static int GenerateNewId()
        {
            if (_patients.Count == 0)
                return 1;

            return _patients[_patients.Count - 1].Id + 1;
        }
    }
}