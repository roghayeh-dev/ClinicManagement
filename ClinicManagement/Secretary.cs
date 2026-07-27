using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    public class Secretary : Person
    {
        public Secretary(string FirstName,string lastName)
        :base(FirstName,lastName)
        { }

        public string PersonnelCode {  get; set; }
        public string Shift {  get; set; }

        public override Result Validate()
        {
            var validate = base.Validate();

            if (!validate.Success)
            {
                return validate;
            }

            if (string.IsNullOrEmpty(PersonnelCode) || PersonnelCode.Length < 4)
            {
                return Result.Failed("کد پرسنلی نامعتبر است.");
            }

            return Result.Ok();
        }
    }
}
