using FluentValidation;
using RecapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Business.ValidationRules.FluentValidation
{
    public class CarImageValidator: AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.CarId).NotNull();
        }
    }
}
