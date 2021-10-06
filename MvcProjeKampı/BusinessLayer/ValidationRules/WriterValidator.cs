using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakımda kısmını Boş Geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan kısmını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage(" Lütfen en az 2 karekter girişi yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage(" Lütfen 50 karekterden fazla değer yapmayınız");
        }

    }
}
