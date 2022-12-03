using FluentValidation;

namespace OrnekUygulama.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email boş olamaz!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Doğru bir Email giriniz!");

            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("Lütfen product name'i boş geçmeyiniz");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Lütfen product name'i 100 karakterden fazla girmeyiniz....");
        }
    }
}
