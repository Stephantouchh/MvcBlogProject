using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Adınızı ve Soyadınızı Boş Bırakamazsınız!")
                .MinimumLength(3).WithMessage("Lütfen en az 3 karakter Giriniz!")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Adresinizi Boş Bırakamazsınız!")
                .MinimumLength(3).WithMessage("Lütfen en az 3 karakter Giriniz!")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter Giriniz!");
            RuleFor(x => x.CommentText).NotEmpty().WithMessage("Mesaj İçeriğini Boş Bırakamazsınız!")
                .MinimumLength(10).WithMessage("Lütfen en az 10 karakter Giriniz!")
                .MaximumLength(300).WithMessage("Lütfen en fazla 300 karakter Giriniz!");
        }
    }
}
