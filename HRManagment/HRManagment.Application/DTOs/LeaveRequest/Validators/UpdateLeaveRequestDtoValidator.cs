﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using HRManagment.Application.Contracts.Persistence;
namespace HRManagment.Application.DTOs.LeaveRequest.Validators
{
    public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public UpdateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveRequestDtoValidator(_leaveTypeRepository));

            RuleFor(p => p.Id)
             .NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
