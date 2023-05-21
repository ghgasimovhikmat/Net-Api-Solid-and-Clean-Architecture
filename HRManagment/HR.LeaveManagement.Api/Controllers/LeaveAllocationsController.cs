using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using HRManagment.Application.DTOs.LeaveAllocation;
using HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Queries;
using HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Commands;

namespace HR.LeaveManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveAllocationsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public LeaveAllocationsController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        //Get: api/<LeaveAllocationsController>
        public async Task<ActionResult<List<LeaveAllocationDto>>> Get()
        {
            var leavetypes = await _meditor.Send(new GetLeaveAllocationListRequest());
            return leavetypes;
        }
        [HttpPost]
        //Post api/ <LeaveAllocationsController>/
        public async Task<ActionResult<LeaveAllocationDto>> Post([FromBody] CreateLeaveAllocationDto leaveAllocationDto)
        {
            var command = await _meditor.Send(new CreateLeaveAllocationCommand { LeaveAllocationDto = leaveAllocationDto });

            return Ok(command);
        }
        [HttpPut]
        //PUT api/ <LeaveAllocationsController>/
        public async Task<ActionResult> Put([FromBody] UptadeLeaveAllocationDto leaveAllocationDto)
        {
            var response = await _meditor.Send(new UpdateLeaveAllocationCommand { LeaveAllocationDto = leaveAllocationDto });

            return NoContent();
        }
        [HttpDelete("{Id}")]
        //Delete: api/ <LeaveAllocationsController>/5
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _meditor.Send(new DeleteLeaveAllocationCommand { Id = id });
            return NoContent();
        }
    }
}
