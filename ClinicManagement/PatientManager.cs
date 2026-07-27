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
            var validate = ValidatePatient(patient);
            if (!validate.Success)
                return validate;

            if (Patients == null)
                Patients = new List<Patient>();

            int c = Patients.Count;
            int id;
            if (Patients.Count > 0)
                id = Patients[c - 1].Id;
            else
                id = 0;

            id++;
            patient.Id = id;

            Patients.Add(patient);
            return Result.Ok();
        }

        //اضافه کردن و اعتبار ستجی به یه روش دیگه
        //public Result UpdatePatient(Patient patient)
        //{
        //    var validate = patient.Validate();
        //    if (!validate.Success)
        //        return validate;
        //    if (Patients == null)
        //        Patients = new List<Patient>();
        //  //  string error = ValidatePatient(patient);
        //   // if (error != null)
        //        return Result.Failed("خطایی رخ داد");
        //   // Patients.Add(patient);
        //    //return null;
        //}

        public Result DeletePatient(Patient patient)
        {
            //TODO: Implement later
            return Result.Ok();
        }
        internal static int GenerateNewId()
        {
            if (_patients.Count == 0)
                return 1;
            if (Patients == null || !Patients.Contains(patient))
                return Result.Failed("بیمار مورد نظر یافت نشد.");

            Patients.Remove(patient);
            return Result.Ok();
        }

        public List<Patient> SearchPatient(string searchText)
        {
            if (Patients == null)
                return new List<Patient>();

            return Patients
                .Where(p =>
                    p.FirstName.Contains(searchText) ||
                    p.LastName.Contains(searchText) ||
                    p.NationalCode.Contains(searchText) ||
                    p.MobileNumber.Contains(searchText))
                .ToList();
        }

        private Result ValidatePatient(Patient patient)
        {
            if (patient == null)
                return Result.Failed("اطلاعات بیمار نامعتبر است.");

            if (string.IsNullOrWhiteSpace(patient.FirstName) ||
                string.IsNullOrWhiteSpace(patient.LastName) ||
                string.IsNullOrWhiteSpace(patient.NationalCode) ||
                string.IsNullOrWhiteSpace(patient.MobileNumber))
            {
                return Result.Failed("وارد کردن تمامی اطلاعات الزامی است.");
            }

            if (patient.NationalCode.Length != 10 ||
                !patient.NationalCode.All(char.IsDigit))
            {
                return Result.Failed("کد ملی باید دقیقاً 10 رقم باشد.");
            }

            if (!patient.MobileNumber.StartsWith("09") ||
                patient.MobileNumber.Length != 11 ||
                !patient.MobileNumber.All(char.IsDigit))
            {
                return Result.Failed("شماره موبایل معتبر نیست.");
            }

            var patients = GetPatients();
            if (patients != null &&
                patients.Any(p => p.NationalCode == patient.NationalCode))
            {
                return Result.Failed("این کد ملی قبلاً ثبت شده است.");
            }

            return Result.Ok();
        
           // return null;
            //int c = Patients.Count;
            //int id;
            //if (Patients.Count > 0)
            //    id = Patients[c - 1].Id;
            //else
            //    id = 0;

            //id++;

            //patient.Id = id;

             }
            return _patients[_patients.Count - 1].Id + 1;
        }

    }
