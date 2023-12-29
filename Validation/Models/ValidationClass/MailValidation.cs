using System.ComponentModel.DataAnnotations;

namespace Validation.Models.ValidationClass
{
    public class MailValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string kontroledilecekveri = string.Empty;
            if (value == null)
            {
                return false;
            }

            kontroledilecekveri = value.ToString();

            if (kontroledilecekveri.Where(x=>x == ' ').ToList().Count() > 0)
            {
                return false;
            }

            if (kontroledilecekveri.Split("@").Count() > 2)
            {
                return false;
            }

            if (kontroledilecekveri.EndsWith("@hotmail.com"))
            {
                return true;
            }

            return false;
        }
    }
}
