﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.DTOs.LeaveType.Validators
{
   public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());
        }
    }
}
