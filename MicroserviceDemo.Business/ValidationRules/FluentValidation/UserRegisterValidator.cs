using FluentValidation;
using MicroserviceDemo.Business.Constants;
using MicroserviceDemo.Entities.Dtos;

namespace MicroserviceDemo.Business.ValidationRules.FluentValidation
{
    public class UserRegisterValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage(Messages.FirstNameIsNotEmpty);
            RuleFor(x => x.LastName).NotEmpty().WithMessage(Messages.LastNameIsNotEmpty);
            RuleFor(x => x.Email).NotEmpty().WithMessage(Messages.EmailIsNotEmpty);
            RuleFor(x => x.Password).NotEmpty().WithMessage(Messages.PasswordIsNotEmpty);
            RuleFor(x => x.RePassword).NotEmpty().WithMessage(Messages.RePasswordIsNotEmpty);
            RuleFor(x => x.RePassword).Equal(x => x.Password).WithMessage(Messages.PasswordAndRePasswordDoNotMatch);
        }
    }
}
