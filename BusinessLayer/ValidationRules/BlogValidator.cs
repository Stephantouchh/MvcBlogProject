using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Bırakamazsınız!")
                   .MinimumLength(3).WithMessage("Lütfen en az 3 karakter Giriniz!")
                   .MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter Giriniz!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Başlığını Boş Bırakamazsınız!")
                  .MinimumLength(30).WithMessage("Lütfen en az 30 karakter Giriniz!");
        }
    }
}
