using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator : AbstractValidator<Feature>
    {
        public FeatureValidator() 
        {
            RuleFor(x => x.FeatureHeader).NotEmpty().WithMessage("Feature Header can not to be empty");
            RuleFor(x => x.FeatureTitle).NotEmpty().WithMessage("Feature Title can not to be empty");
            RuleFor(x => x.FeatureName).NotEmpty().WithMessage("Feature Name can not to be empty");

            RuleFor(x => x.FeatureHeader).MinimumLength(3).WithMessage("Feature Header at least contain 3 characters");
            RuleFor(x => x.FeatureTitle).MinimumLength(3).WithMessage("Feature Title at least contain 3 characters");
            RuleFor(x => x.FeatureName).MinimumLength(3).WithMessage("Feature Name at least contain 3 characters");

            RuleFor(x => x.FeatureHeader).MaximumLength(7).WithMessage("Feature Header at maximumly contain 7 characters");
            RuleFor(x => x.FeatureTitle).MaximumLength(50).WithMessage("Feature Title at maximumly contain 50 characters");
            RuleFor(x => x.FeatureName).MaximumLength(50).WithMessage("Feature Name at maximumly contain 50 characters");
        }
    }
}
