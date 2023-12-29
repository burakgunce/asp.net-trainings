using System.ComponentModel.DataAnnotations;

namespace Validation.Models.ValidationClass
{
    public class IdentificationNumberValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int toplam = 0, cifttoplam = 0, tektoplam = 0;
            if (value == null)
            {
                return false;
            }

            string id = value.ToString();

            if (id.Length != 11 || id[0] == '0')
            {
                return false;
            }

            for (int i = 0; i < 9; i++)
            {
                toplam += int.Parse(id[i].ToString());
                if (i % 2 == 0)
                {
                    tektoplam += int.Parse(id[i].ToString());
                }
                else if (i % 2 != 0 && i <=7)
                {
                    cifttoplam += int.Parse(id[i].ToString());
                }
            }

            if ((7*tektoplam-cifttoplam) % 10 != int.Parse(id[9].ToString()))
            {
                return false;
            }

            if (toplam % 10 != int.Parse(id[10].ToString()))
            {
                return false;
            }

            return true;
        }
    }
}
