using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazarın Adı ve Soyadını Boş Bırakamazsınız!")
                       .MinimumLength(2).WithMessage("Lütfen en az 2 karakter Giriniz!")
                       .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.AuthorImage).NotEmpty().WithMessage("Yazarın Resim Yolunu Boş Bırakamazsınız!");
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("Yazarın Hakkında Kısmını Boş Bırakamazsınız!")
                 .MinimumLength(20).WithMessage("Lütfen en az 20 karakter Giriniz!")
                 .MaximumLength(250).WithMessage("Lütfen en fazla 250 karakter Giriniz!");
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Yazarın Mesleğini Boş Bırakamazsınız!")
                   .MinimumLength(5).WithMessage("Lütfen en az 5 karakter Giriniz!")
                 .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.AuthorShort).NotEmpty().WithMessage("Yazarın Yeteneklerini Boş Bırakamazsınız!")
                 .MinimumLength(10).WithMessage("Lütfen en az 10 karakter Giriniz!")
                 .MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter Giriniz!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Yazarın Mail Adresini Boş Bırakamazsınız!")
                .MinimumLength(10).WithMessage("Lütfen en az 10 karakter Giriniz!")
                 .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Yazarın Şifresini Boş Bırakamazsınız!")
                 .MinimumLength(5).WithMessage("Lütfen en az 5 karakter Giriniz!")
                 .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Yazarın Telefon Numarasını Boş Bırakamazsınız!")
                .MinimumLength(11).WithMessage("Lütfen en az 11 karakter Giriniz!");
        }
    }
}
