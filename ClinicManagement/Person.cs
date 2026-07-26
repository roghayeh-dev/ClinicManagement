namespace ClinicManagement
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public virtual Result Validate()
        {
            if (string.IsNullOrEmpty(FirstName) || FirstName.Length < 2)
            {
                return Result.Failed("نام را وارد کن");
            }
            if (string.IsNullOrEmpty(LastName) || LastName.Length < 2)
            {
                return Result.Failed("نام خانوادگی را وارد کن");
            }

            return Result.Ok();
        }
    }
}
