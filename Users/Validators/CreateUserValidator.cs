using DataAccess.Models;
using FluentValidation;

namespace Users.Validators
{
    public class CreateUserValidator : AbstractValidator<User>
    {
        public CreateUserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.LastName).NotEmpty();
        }
    }

}
