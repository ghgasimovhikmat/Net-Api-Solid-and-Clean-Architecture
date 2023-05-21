
using AutoMapper;
using HRManagment.Application.DTOs;
using HRManagment.Application.DTOs.LeaveAllocation;
using HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Queries;
using HRManagment.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HRManagment.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveTypeAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

     
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetails();
            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocation);
        }
    }
}
