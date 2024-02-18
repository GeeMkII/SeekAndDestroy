using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Commands.EditWareHouse
{
    public class EditWareHouseCmdValidator : AbstractValidator<EditWareHouseCmd>
    {
        public EditWareHouseCmdValidator()
        {
            
            RuleFor(c => c.Hardness)
               .NotEmpty()
               .MinimumLength(4).WithMessage("xxx")
               .MaximumLength(5)
               .WithErrorCode("S355, HB450, HB500, HB550")
             ;
            RuleFor(c => c.Width)
                .NotEmpty()
                .GreaterThan(100)
                .LessThan(2550)
                 .WithMessage("Required")
                .WithErrorCode("Between 100 - 2550")
            ;

            RuleFor(c => c.Height)
                .NotEmpty()
                .GreaterThan(1000)
                .LessThan(12100)
                .WithErrorCode("Between 1000 - 12100")
            ;
            RuleFor(c => c.Thickness)
                .NotEmpty()
                .GreaterThan(1)
                .LessThan(60)
                .WithMessage("Required")
                .WithErrorCode("Between 0.9 - 50")
             ;
        }
    }
}
