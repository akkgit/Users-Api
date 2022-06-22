using DataAccess.Models;
using FluentValidation;
using Users.Dto;

namespace Users.Validators
{
    public class CreateUserValidator : AbstractValidator<CreateUserDto>
    {
        public CreateUserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.LastName).NotEmpty();
        }
    }

}
