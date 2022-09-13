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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar Hakkında Alanını Boş Geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Ünvan Alanını Boş Geçemezsiniz");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar Adı Minimum 2 Karakter Olmalı");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar Soyadı Minimum 2 Karakter Olmalı");
            RuleFor(x => x.WriterAbout).MaximumLength(100).WithMessage("yazar Hakkında Alanı Maximum 100 Karakter Olmalı");
        }
        
    }
}
