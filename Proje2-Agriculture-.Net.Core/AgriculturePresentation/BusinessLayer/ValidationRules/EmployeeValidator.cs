using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Personel ismini boş geçemezsiniz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim yolu boş geçilemez");
            RuleFor(x => x.EmployeeName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha fazla veri girişi yapmayınız.");
            RuleFor(x => x.EmployeeName).MinimumLength(3).WithMessage("Lütfen 3 karakterden daha az veri girişi yapmayınız.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha fazla veri girişi yapmayınız.");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen 3 karakterden daha az veri girişi yapmayınız.");

        }
    }
}
