using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Bırakamazsınız!")
                   .MinimumLength(3).WithMessage("Lütfen en az 3 karakter Giriniz!")
            .MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter Giriniz!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklamasını Boş Bırakamazsınız!")
            .MinimumLength(30).WithMessage("Lütfen en az 30 karakter Giriniz!")
            .MaximumLength(1000).WithMessage("Lütfen en fazla 1000 karakter Giriniz!");
        }
    }
}
