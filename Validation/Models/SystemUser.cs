using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Validation.Models.ValidationClass;

namespace Validation.Models
{
    //[MetadataType(typeof("valıdatoınların oldugu class ımsı"))]
    //bunu kullanırsan tum valıdatıonlar o sınıftakı kurallar olucak ve alttakı attrıbutelerı kaldırman gerek.
    public class SystemUser
    {
        [Required(ErrorMessage = "kullanıcı adı bos gecılemez")]
        [StringLength(10, ErrorMessage = "kullanıcı adı en az 3 en fazla 10 karakter olmalıdır", MinimumLength = 3)] //globalization , culture info
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "kımlık numarası bos olamaz")]
        [IdentificationNumberValidation(ErrorMessage ="gecersız kımlık numarası")]
        public string IdentificationNumber { get; set; }
        
        [Required(ErrorMessage = "puan bos olamaz")]
        [Range(0,100,ErrorMessage ="puan 0-100 arasında olmalıdır")]
        public int Score { get; set; }
        
        [Required(ErrorMessage ="maıl adresı bos olamaz")]
        [MailValidation(ErrorMessage = "e psota adresi @hotmail.com ile sonlanmalıdır ve bosluk ıcermemelıdır")]
        public string EmailAddress { get; set; }
        
        [Required(ErrorMessage ="sıfre bos olamaz")]
        [StringLength(20,ErrorMessage ="sıfre en az 8 en fazla 20 karakter olmalıdır",MinimumLength = 8)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage ="sıfre tekrarı bos olamaz")]
        [Compare("Password",ErrorMessage ="parola tekrarı parola ıle aynı olmalıdır")]
        public string PasswordConfirmation { get; set; }
    }
}
