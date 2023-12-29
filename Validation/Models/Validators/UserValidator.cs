using FluentValidation;

namespace Validation.Models.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(a => a.FirstName).NotEmpty().WithMessage("isim boş gecılemez").MinimumLength(2).WithMessage("ısım en az 2 karakter olmalı");

        }
    }
}
