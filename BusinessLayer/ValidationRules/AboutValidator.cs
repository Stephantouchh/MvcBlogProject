using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.AboutContent1).NotEmpty().WithMessage("Hakkımda 1 Kısmını Boş Bırakamazsınız!")
                  .MinimumLength(20).WithMessage("Lütfen en az 20 karakter Giriniz!");
            RuleFor(x => x.AboutContent2).NotEmpty().WithMessage("Hakkımda 2 Kısmını Boş Bırakamazsınız!")
                 .MinimumLength(20).WithMessage("Lütfen en az 20 karakter Giriniz!");
            RuleFor(x => x.AboutImage1).NotEmpty().WithMessage("Hakkımda Resim 1 Kısmını Boş Bırakamazsınız!")
                .MinimumLength(20).WithMessage("Lütfen en az 20 karakter Giriniz!");
            RuleFor(x => x.AboutImage2).NotEmpty().WithMessage("Hakkımda Resim 2 Kısmını Boş Bırakamazsınız!")
            .MinimumLength(20).WithMessage("Lütfen en az 20 karakter Giriniz!");
        }
    }
}
