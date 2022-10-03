using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidation : AbstractValidator<CarImage>
    {
        public CarImageValidation()
        {
            RuleFor(c => c.ImagePath).NotEmpty();
        }
    }
}
