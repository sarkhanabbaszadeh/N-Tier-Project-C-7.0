using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Məhsul adı boş buraxıla bilməz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Məhsul adı ən azı 3 hərfdən ibarət olmalıdır!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Qiymət boş buraxıla bilməz!");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Miqdar sayı boş buraxıla bilməz");
        }
    }
}
