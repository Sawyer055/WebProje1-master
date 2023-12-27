using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Name area cannot be empty!");
            RuleFor(x => x.CustomerName).MinimumLength(3).WithMessage("Please enter minimum 3 character");
            RuleFor(x => x.CustomerName).MaximumLength(30).WithMessage("Please enter maximum 30 character");
            RuleFor(x => x.CustomerSurname).NotEmpty().WithMessage("Surname area cannot be empty!");
            RuleFor(x => x.CustomerSurname).MinimumLength(3).WithMessage("Please enter minimum 3 character");
            RuleFor(x => x.CustomerSurname).MaximumLength(30).WithMessage("Please enter maximum 30 character");
            RuleFor(x => x.CustomerPassword).NotEmpty().WithMessage("Password area cannot be empty!");
            RuleFor(x => x.CustomerPassword).MinimumLength(3).WithMessage("Please enter minimum 3 character");
            RuleFor(x => x.CustomerPassword).MaximumLength(20).WithMessage("Please enter maximum 30 character");
            RuleFor(x => x.CustomerEmail).NotEmpty().WithMessage("Email area cannot be empty!");
            RuleFor(x => x.CustomerPhoneNumber).NotEmpty().WithMessage("Phone number area cannot be empty!");

        }
    }
}
