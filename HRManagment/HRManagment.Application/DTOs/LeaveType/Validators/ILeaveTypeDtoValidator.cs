using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace HRManagment.Application.DTOs.LeaveType.Validators
{
    public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} character");

            RuleFor(p => p.DefaultDays)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .GreaterThan(0).WithMessage("{PropertyName} must not be at least 1.")
              .LessThan(100).WithMessage("{PropertyName} must be lessthan {ComparisonValue}");
        }
    }
}
