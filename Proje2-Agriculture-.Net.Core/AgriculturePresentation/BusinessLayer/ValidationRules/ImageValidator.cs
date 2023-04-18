using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel başlığını boş geçemezsiniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklamasını boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş geçilemez");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen 20 karakterden daha fazla veri girişi yapmayınız.");
            RuleFor(x => x.Title).MinimumLength(7).WithMessage("Lütfen 7 karakterden daha az veri girişi yapmayınız.");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha fazla veri girişi yapmayınız.");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Lütfen 10 karakterden daha az veri girişi yapmayınız.");
        }
    }
}
