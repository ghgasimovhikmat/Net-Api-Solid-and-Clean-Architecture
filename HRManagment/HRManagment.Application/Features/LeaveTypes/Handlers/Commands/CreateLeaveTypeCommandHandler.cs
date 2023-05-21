using System;
using MediatR;
using HRManagment.Application.Features.LeaveTypes.Request.Queries;
using System.Threading.Tasks;
using System.Threading;
using HRManagment.Application.Contracts.Persistence;
using AutoMapper;
using HRManagment.Domain;
using HRManagment.Application.DTOs.LeaveType.Validators;
using HRManagment.Application.Exception;
using HRManagment.Application.Responses;
using System.Linq;

namespace HRManagment.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, BaseCommandResponse>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);
        
            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Messages = "Creation Failed";
                response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
            }
            else
            {
                var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
                leaveType = await _leaveTypeRepository.Add(leaveType);

                response.Success = true;
                response.Messages = "Creation Successful";
                response.Id = leaveType.Id;
            }

            return response;
        }
    }
}
