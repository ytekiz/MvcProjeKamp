using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class MessageValidator: AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.Subjetc).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Geçemezsiniz");
            RuleFor(x => x.Subjetc).MinimumLength(2).WithMessage(" Lütfen en az 2 karekter girişi yapın");
            RuleFor(x => x.Subjetc).MaximumLength(100).WithMessage(" Lütfen 100 karekterden fazla değer yapmayınız");
        }
    }
}
