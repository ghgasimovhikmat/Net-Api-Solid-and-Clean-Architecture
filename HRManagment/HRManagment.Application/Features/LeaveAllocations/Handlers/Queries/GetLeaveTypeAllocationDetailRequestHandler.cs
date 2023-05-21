using HRManagment.Application.DTOs;
using HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Queries;
using MediatR;
using System;

using System.Threading;
using System.Threading.Tasks;

using AutoMapper;
using HRManagment.Application.Contracts.Persistence;
using HRManagment.Application.DTOs.LeaveAllocation;

namespace HRManagment.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveTypeAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeAllocationDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationDetail(request.Id);
            return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
        }
    }
}
