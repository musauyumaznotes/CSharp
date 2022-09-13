using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçemezsiniz");
            RuleFor(x => x.MessageContent).MinimumLength(10).WithMessage("Mesaj en az 10 karakter olmalıdır");
            RuleFor(x => x.Subject).MinimumLength(2).WithMessage("Konu en az 2 karakter olmalıdır");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu en fazla 100 karakter olmalıdır");
        }
    }
}
