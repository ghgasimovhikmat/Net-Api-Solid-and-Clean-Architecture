using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using HRManagment.Application.DTOs.LeaveRequest;
using HRManagment.Application.Features.LeaveRequests.Handlers.Request.Queries;
using HRManagment.Application.DTOs;
using HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Queries;
using HRManagment.Application.Features.LeaveRequests.Handlers.Request.Commands;
using HRManagment.Application.Features.LeaveRequests.Request.Queries;
namespace HR.LeaveManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public LeaveRequestsController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        //Get: api/<LeaveRequestsController>
        public async Task<ActionResult<List<LeaveRequestListDto>>> Get()
        {
            var leaverequests = await _meditor.Send(new GetLeaveRequestListRequest());
            return leaverequests;
        }
        [HttpGet("{Id}")]
        //Get: api/ <LeaveRequestsController>/5
        public async Task<ActionResult<LeaveRequestDto>> Get(int id)
        {
            var leaverequest = await _meditor.Send(new GetLeaveRequestDetailRequest { Id = id });
            return Ok(leaverequest);
        }
        [HttpPost]
        //Post api/ <LeaveRequestsController>
        public async Task<ActionResult> Post([FromBody] CreateLeaveRequestDto leaveRequestDto)
        {
            var response = await _meditor.Send(new CreateLeaveRequestCommand { LeaveRequestDto = leaveRequestDto });
            return Ok(response);
        }
        [HttpPut]
        //PUT api/ <LeaveRequestsController>/
        public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveRequestDto leaveRequest)
        {
            var response = await _meditor.Send(new UpdateLeaveRequestCommand { Id = id, LeaveRequestDto = leaveRequest });

            return NoContent();
        }
        [HttpPut("changeapproval/{id}")]
        //PUT api/  changeApproval <LeaveRequestsController>/
        public async Task<ActionResult> ChangeApproval(int id, [FromBody] ChangeLeaveRequestApprovalDto changeLeaveRequestApprovalDto)
        {
            var response = await _meditor.Send(new UpdateLeaveRequestCommand { Id = id, ChangeLeaveRequestApprovalDto = changeLeaveRequestApprovalDto });

            return NoContent();
        }
        [HttpDelete("{Id}")]
        //Delete: api/ <LeaveRequestsController>/5
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _meditor.Send(new DeleteLeaveRequestCommand { Id = id });
            return NoContent();
        }
    }
}
