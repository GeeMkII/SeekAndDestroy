using FluentValidation;
using SAD.Domain.Interfaces;

namespace SAD.App.Warehouse
{//AbstractVal - parametr generyczny przyjmuje typ do walidacji
    public class WarehouseDtoVaildator : AbstractValidator<WarehouseDto>
    {
        public WarehouseDtoVaildator(IWarehouseRepo repo)
        {
           // SeoName();
           // RuleFor(c => c.SEOName)
            // .NotEmpty()
           // .MinimumLength(2)
           //  .MaximumLength(3)
           //  ;
            //RuleFor(c => c.Hardnes)
            //    .NotEmpty()
            //    .MinimumLength(4).WithMessage("xxx")
            //    .MaximumLength(5)                
            // 
            //  .WithErrorCode("S355, HB450, HB500, HB550")
            //;

            //RuleFor(c => c.Width)
            //    .NotEmpty()
            //    .GreaterThan(100)
            //    .LessThan(2550)
            //     .WithMessage("Required")
            //    .WithErrorCode("Between 100 - 2550")
            //;

            //RuleFor(c => c.Height)
            //    .NotEmpty()
            //    .GreaterThan(1000)
            //    .LessThan(12100)
            //    .WithErrorCode("Between 1000 - 12100")
            //;
            //RuleFor(c => c.Thicness)
            //    .NotEmpty()
            //    .GreaterThan(1)
            //    .LessThan(60)
            //   .WithMessage("Required")
            //  .WithErrorCode("Between 1 - 60")
            // ;
            //RuleFor(c => c.PalletRackName)
            //    .NotEmpty()
            //    .MinimumLength(4)
            //    .MaximumLength(20)
            //   .WithMessage("Required")
            //   .WithErrorCode("Between 4 - 20 char")
            //;

            // RuleFor(c => c.Name)
            //     .Custom((valPosition, context) =>
            //     {
            //         var inWarhause = repo.GetByName(valPosition).Result;
            //         if (inWarhause != null)
            //        {
            //            context.AddFailure($"{valPosition} -Position taken");
            //       }


            // )
            //   .WithMessage("Required")
            //  .WithErrorCode("Between 2 or 3 char")
            //    ;
            //
        }
    }
}
