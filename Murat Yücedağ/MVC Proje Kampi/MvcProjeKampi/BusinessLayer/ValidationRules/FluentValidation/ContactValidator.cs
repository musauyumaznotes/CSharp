using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x =>x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemzsiniz");
            RuleFor(x =>x.Subject).NotEmpty().WithMessage("Konu adını Boş Geçemzsiniz");
            RuleFor(x =>x.Username).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemzsiniz");
            RuleFor(x =>x.Subject).MinimumLength(2).WithMessage("En Az 2 karakter girişi yapılmalıdır");
            RuleFor(x =>x.Username).MinimumLength(2).WithMessage("En Az 2 karakter girişi yapılmalıdır");
            RuleFor(x =>x.Subject).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapılabilir");
        }
    }
}
