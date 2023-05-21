using AutoMapper;
using HRManagment.Application.Exception;
using HRManagment.Application.Features.LeaveRequests.Handlers.Request.Commands;
using HRManagment.Application.Features.LeaveTypes.Handlers.Request.Commands;
using HRManagment.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRManagment.Application.Features.LeaveRequests.Handlers.Commands
{
  public  class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequets = await _leaveRequestRepository.Get(request.Id);
            if (leaveRequets == null)
                throw new NotFoundException(nameof(LeaveRequests), request.Id);

            await _leaveRequestRepository.Delete(leaveRequets);

            return Unit.Value;
        }
    }
}
