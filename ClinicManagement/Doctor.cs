namespace ClinicManagement
{
    public class Doctor : Person
    {
        private Doctor(string firstName, string lastName)
            : base(firstName, lastName)
        {
            Id = DoctorManager.GenerateNewId();
        }
        public Doctor(string medicalCouncilNumber, string firstName, string lastName)
            : this(firstName, lastName)
        {
            medicalCouncilNumber = medicalCouncilNumber;
        }
        public string medicalCouncilNumber { get; set; }
        public string[] Specialties { get; set; }

        public string FullSpecialties
        {
            get
            {
                return string.Join(", ", Specialties);
            }
        }

        public override Result Validate()
        {
            var validate = base.Validate();
            if (!validate.Success)
            {
                return validate;
            }

            if (string.IsNullOrEmpty(medicalCouncilNumber) || medicalCouncilNumber.Length < 3)
            {
                return Result.Failed("نظام پزشکی نامعتبر");
            }

            if ((Specialties?.Length ?? 0) == 0)
            {
                return Result.Failed("تخصص پزشک وارد نشده");
            }

            return Result.Ok();
        }
    }
}
