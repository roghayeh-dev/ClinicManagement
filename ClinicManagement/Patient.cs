namespace ClinicManagement
{
    public sealed class Patient : Person
    {
        public Patient(string firstName, string lastName)
            : base(firstName, lastName)
        {
            Id = PatientManager.GenerateNewId();
        }


        private string nationalCode;

        public string NationalCode
        {
            get { return nationalCode; }
            set { nationalCode = value; }
        }

        public string MobileNumber { get; set; }

        public override Result Validate()
        {
            var validate = base.Validate();
            if (!validate.Success)
            {
                return validate;
            }

            if (!NationalCode.IsNationalCode())
            {
                return Result.Failed("کدملی نامعتبر");
            }

            if (string.IsNullOrEmpty(MobileNumber) || MobileNumber.Length != 11)
            {
                return Result.Failed("شماره موبایل نامعتبر");
            }

            return Result.Ok();
        }
    }
}
