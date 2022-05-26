using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core.Models
{
   public  class HostelValidator : AbstractValidator<Hostel>
    {
        public HostelValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Description).NotEmpty().MinimumLength(5).MaximumLength(50);
            RuleFor(x => x.CountBad).InclusiveBetween(1, 6);
            RuleFor(x=>x.FreeBedCount).InclusiveBetween(1, 6);
        }
    }
}
