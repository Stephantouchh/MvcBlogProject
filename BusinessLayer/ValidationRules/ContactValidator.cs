using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adınızı Boş Bırakamazsınız!")
                 .MinimumLength(3).WithMessage("Lütfen en az 3 karakter Giriniz!")
                 .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyadınızı Boş Bırakamazsınız!")
               .MinimumLength(3).WithMessage("Lütfen en az 3 karakter Giriniz!")
               .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Adresinizi Boş Bırakamazsınız!")
            .MinimumLength(3).WithMessage("Lütfen en az 3 karakter Giriniz!")
            .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Mesaj Konusunu Boş Bırakamazsınız!")
            .MinimumLength(3).WithMessage("Lütfen en az 3 karakter Giriniz!")
            .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj Açıklamasını Boş Bırakamazsınız!")
          .MinimumLength(10).WithMessage("Lütfen en az 10 karakter Giriniz!");
        }
    }
}
