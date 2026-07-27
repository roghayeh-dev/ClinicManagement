using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement
{
    internal class DoctorManager
    {
        private static List<Doctor> _doctors = new List<Doctor>();

        public List<Doctor> GetDoctors()
        {
            return new List<Doctor>(_doctors);
        }

        public Result AddDoctor(Doctor doctor)
        {
            var validate = ValidateDoctor(doctor);
            if (!validate.Success)
                return validate;

            _doctors.Add(doctor);
            return Result.Ok();
        }

        public Result EditDoctor(Doctor doctor, Doctor newDoctor)
        {
            var validate = ValidateDoctor(newDoctor);
            if (!validate.Success)
                return validate;

            for (int i = 0; i < _doctors.Count; i++)
            {
                if (_doctors[i].medicalCouncilNumber == doctor.medicalCouncilNumber)
                {
                    _doctors[i] = newDoctor;
                    return Result.Ok();
                }
            }

            return Result.Failed("پزشک مورد نظر یافت نشد.");
        }

        public Result DeleteDoctor(string medicalCouncilNumber)
        {
            if (string.IsNullOrWhiteSpace(medicalCouncilNumber))
                return Result.Failed("شماره نظام پزشکی نمی‌تواند خالی باشد.");

            Doctor doctor = _doctors.FirstOrDefault(d => d.medicalCouncilNumber == medicalCouncilNumber);

            if (doctor == null)
                return Result.Failed("پزشکی با این شماره نظام پزشکی یافت نشد.");

            _doctors.Remove(doctor);
            return Result.Ok();
        }

        public void RemoveDoctorByMedicalCouncilNumber(int id)
        {
            foreach (Doctor item in _doctors)
            {
                if (item.Id == id)
                {
                    _doctors.Remove(item);
                    break;
                }
            }
        }

        public string[] Validation(
            string firstName,
            string lastName,
            string medicalCouncilNumber)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(firstName))
                errors.Add("نام اجباری است");

            if (string.IsNullOrWhiteSpace(lastName))
                errors.Add("نام خانوادگی اجباری است");

            if (string.IsNullOrWhiteSpace(medicalCouncilNumber))
                errors.Add("کد نظام پزشکی اجباری است");
            else if (medicalCouncilNumber.Length < 3)
                errors.Add("کد نظام پزشکی باید حداقل ۳ کاراکتر باشد");

            return errors.ToArray();
        }

        private Result ValidateDoctor(Doctor doctor)
        {
            if (doctor == null)
                return Result.Failed("اطلاعات پزشک نامعتبر است.");

            return doctor.Validate();
        }

        internal static int GenerateNewId()
        {
            if (_doctors.Count == 0)
                return 1;

            return _doctors[_doctors.Count - 1].Id + 1;
        }
    }
}