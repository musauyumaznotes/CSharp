using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar Adı ve Soyadı Boş geçilemez");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Yazar mail alanı Boş geçilemez");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Yazar şifre alanı Boş geçilemez");

            RuleFor(x => x.WriterName).MinimumLength(4).MaximumLength(50).WithMessage("Yazar isim soyismi en 4 en fazla 50 karakter olabilir");
            //RuleFor(x => x.WriterName).MinimumLength(4).MaximumLength(50).WithMessage("Yazar isim soyismi en 4 en fazla 50 karakter olabilir");

        }
    }
}
