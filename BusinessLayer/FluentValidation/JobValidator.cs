using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Peşənin adı boş buraxıla bilməz !");
            RuleFor(x => x.Name).MinimumLength(4).WithMessage("Peşənin adı 4 hərfdən az ola bilməz!");
        }
    }
}
