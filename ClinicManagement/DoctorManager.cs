using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement
{
    internal class DoctorManager
    {
        private static List<Doctor> _doctors = new List<Doctor>();

        public List<Doctor> GetDoctors()
        {
            return _doctors;
        }

        public void AddDoctor(Doctor doctor)
        {
            _doctors.Add(doctor);
        }

        public void EditDoctor(Doctor doctor, Doctor newDoctor)
        {
            for (int i = 0; i < _doctors.Count; i++)
            {
                if (_doctors[i].NezamPezeshki == doctor.NezamPezeshki)
                {
                    _doctors[i] = newDoctor;
                    break;
                }
            }
        }

        public void RemoveDoctor(string nezamPezeshki)
        {
            foreach (Doctor item in _doctors)
            {
                if (item.NezamPezeshki == nezamPezeshki)
                {
                    _doctors.Remove(item);
                    break;
                }
            }
        }

        public void RemoveDoctor(int id)
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
                errors.Add("کد نظام پزشکی باید ۳ رقم باشد");

            return errors.ToArray();
        }

        internal static int GenerateNewId()
        {
            if (_doctors.Count == 0)
                return 1;

            return _doctors[_doctors.Count - 1].Id + 1;
        }
    }
}