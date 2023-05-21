using AutoMapper;
using HRManagment.Application.DTOs.LeaveRequest.Validators;
using HRManagment.Application.DTOs.LeaveType.Validators;
using HRManagment.Application.Exception;
using HRManagment.Application.Features.LeaveRequests.Handlers.Request.Commands;
using HRManagment.Application.Contracts.Persistence;
using HRManagment.Application.Responses;
using HRManagment.Domain;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HRManagment.Application.Contracts.Infrastructure;
using HRManagment.Application.Models;

namespace HRManagment.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, ILeaveTypeRepository leaveTypeRepository, IMapper mapper, IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.LeaveRequestDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Messages = "Creation Failed";
                response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
            }
            else
            {
                var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
                leaveRequest = await _leaveRequestRepository.Add(leaveRequest);

                response.Success = true;
                response.Messages = "Creation Successful";
                response.Id = leaveRequest.Id;
            }
          

            var email = new Email
            {
                To = "hikmetqasimov26@gmail.com",
                Body = $"Your leave request for {request.LeaveRequestDto.StartDate:D} to {request.LeaveRequestDto.EndDate} " +
                $"has been submitted successfully",
                Subject = "Leave Request Submitted"
            };
            await _emailSender.SendEmail(email);
         

            return response;
        }
    }
}
