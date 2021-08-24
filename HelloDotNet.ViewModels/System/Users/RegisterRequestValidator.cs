using System;
using FluentValidation;

namespace HelloDotNet.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required")
                .MaximumLength(200).WithMessage(
                    "First name cannot over 200 characters");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required")
                .MaximumLength(200).WithMessage(
                    "Last name cannot over 200 characters");

            RuleFor(x => x.DateOfBirth)
                .GreaterThan(DateTime.Now.AddYears(-150)).WithMessage(
                    "Birthday cannot before 150 years ago");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                    .WithMessage("Email format is invalid");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required");

            RuleFor(x => x.UserName).NotEmpty()
                .WithMessage("Username is required");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(6)
                    .WithMessage("Password is at least 6 characters");

            RuleFor(x => x).Custom((request, context) => {
                if (request.ConfirmPassword != request.Password)
                {
                    context.AddFailure("Confirmed password is not match");
                }
            });
        }
    }
}
