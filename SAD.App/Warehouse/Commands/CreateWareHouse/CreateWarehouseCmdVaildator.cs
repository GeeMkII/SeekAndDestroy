// Ignore Spelling: App Vaildator Dto repo

using FluentValidation;
using FluentValidation.Internal;
using SAD.Domain.Interfaces;

namespace SAD.App.Warehouse.Commands.CreateWareHouse
{//AbstractVal - parametr generyczny przyjmuje typ do walidacji
    public class CreateWarehouseCmdVaildator : AbstractValidator<CreateWareHouseCmd>
    {

        public CreateWarehouseCmdVaildator(IWarehouseRepo repo)
        {
            RuleFor(c => c.SEOName)
                .Custom((value, context) =>
                    {
                        var wareHouseInBase = repo.GetBySeo(value).Result;
                        if (wareHouseInBase != null)
                        {
                            context.RootContextData["SEONameInvalid"] = true;
                        }
                    }
                );

            RuleFor(c => c.PalletRackName)
             .NotEmpty()
             .MinimumLength(3)
             .MaximumLength(10)
             .WithErrorCode("Between 4 - 20 char")
             ;
            RuleFor(c => c.PalletRackPosition)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(3)
                .WithErrorCode("Between 2 - 3 char")
                .Custom((value, context) =>
                {
                    if (context.RootContextData.TryGetValue("SEONameInvalid", out var seoNameInvalid) && (bool)seoNameInvalid)
                    {
                        context.AddFailure($"{value} existing. Place not empty");
                    }

                })

            ;
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
