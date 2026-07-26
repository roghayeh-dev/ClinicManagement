using System;
using System.Collections.Generic;

namespace ClinicManagement
{
    internal class DoctorManager
    {
        private static List<Doctor> Doctors;

        public List<Doctor> GetDoctors()
        {
            return Doctors;
        }

        public void AddDoctor(Doctor Doctor)
        {
            if (Doctors == null)
                Doctors = new List<Doctor>();

            Doctors.Add(Doctor);
        }

        public void EditDoctor(Doctor doctor, Doctor newDoctor)
            var validate = ValidateDoctor(doctor);
            if (!validate.Success)
                return validate;

            if (doctors == null)
                doctors = new List<Doctor>();

            doctors.Add(doctor);
            return Result.Ok();
        }
            for (int i = 0; i < Doctors.Count; i++)
            {
                if (Doctors[i].MedicalCouncilNumber == doctor.MedicalCouncilNumber)
                {
                    Doctors[i] = newDoctor;
                    break;
                }
            }
        }
        }
        public Result DeleteDoctor(string medicalCouncilNumber)
        {
            if (string.IsNullOrWhiteSpace(medicalCouncilNumber))
                return Result.Failed("شماره نظام پزشکی نمی‌تواند خالی باشد.");

            if (doctors == null)
                doctors = new List<Doctor>();

            Doctor doctor = doctors.FirstOrDefault(d => d.MedicalCouncilNumber == medicalCouncilNumber);

            if (doctor == null)
                return Result.Failed("پزشکی با این شماره نظام پزشکی یافت نشد.");

            doctors.Remove(doctor);
            return Result.Ok();
        public void RemoveDoctorByMedicalCouncilNumber(string medicalCouncilNumber)
        {
            foreach (Doctor item in Doctors)
                if (item.MedicalCouncilNumber == medicalCouncilNumber)
                {
                    Doctors.Remove(item);
                    break;
                }
            return Result.Ok();
        }

        public string[] Validation(
            string firstName,
            string lastName,
            string medicalCouncilNumber
            )
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(firstName))
                errors.Add("نام اجباری است");

            if (string.IsNullOrWhiteSpace(lastName))
                errors.Add("نام خانوادگی اجباری است");
        internal static int GenerateNewId()
        {
            if (doctors == null || doctors.Count == 0)
                return 1;
            if (string.IsNullOrWhiteSpace(medicalCouncilNumber))
                errors.Add("کد نظام پزشکی اجباری است");
            else if (medicalCouncilNumber.Length < 3)
                errors.Add("کد نظام پزشکی باید ۳ رقم باشد");
                return 1;
            return doctors[doctors.Count - 1].Id + 1;
            return errors.ToArray();
            return _doctors[_doctors.Count - 1].Id + 1;
        }
    }
}