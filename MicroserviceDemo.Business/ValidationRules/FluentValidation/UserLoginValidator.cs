using FluentValidation;
using MicroserviceDemo.Business.Constants;
using MicroserviceDemo.Entities.Dtos;

namespace MicroserviceDemo.Business.ValidationRules.FluentValidation
{
    public class UserLoginValidator : AbstractValidator<UserForLoginDto>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(Messages.EmailIsNotEmpty);
            RuleFor(x => x.Password).NotEmpty().WithMessage(Messages.PasswordIsNotEmpty);
        }
    }
}
