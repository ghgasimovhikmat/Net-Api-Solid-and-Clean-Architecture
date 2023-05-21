using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using HRManagment.Application.DTOs.LeaveType;
using HRManagment.Application.Features.LeaveTypes.Handlers.Queries;
using HRManagment.Application.Features.LeaveTypes.Request.Queries;
using HRManagment.Application.Features.LeaveTypes.Handlers.Request.Commands;
using HRManagment.Application.Responses;

namespace HR.LeaveManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypesController : ControllerBase
    {
        private readonly IMediator _meditor;

        public LeaveTypesController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        //Get: api/<LeaveTypesController>
        public async Task<ActionResult<List<LeaveTypeDto>>> Get()
        {
            var leavetypes = await _meditor.Send(new GetLeaveTypeListRequest());
            return Ok(leavetypes);
        }
        [HttpGet("{id}")]
        //Get: api/ <LeaveTypesController>/5
        public async Task<ActionResult<LeaveTypeDto>> Get(int id)
        {
            var leavetype = await _meditor.Send(new GetLeaveTypeDetailRequest { Id = id });
            return Ok(leavetype);
        }
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        //Post api/ <LeaveTypesController>/
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateLeaveTypeDto leaveType)
        {
            var command = new CreateLeaveTypeCommand { LeaveTypeDto = leaveType };
            var response = await _meditor.Send(command);

            return Ok(response);

        }
        [HttpPut("{Id}")]
        //PUT api/ <LeaveTypesController>/
        public async Task<ActionResult> Put(int id,[FromBody] LeaveTypeDto leaveType)
        {
            var command = new UpdateLeaveTypeCommand { LeaveTypeDto = leaveType };
            var response = await _meditor.Send(command);
            return NoContent();
        }
        [HttpDelete("{Id}")]
        //Delete: api/ <LeaveTypesController>/5
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _meditor.Send(new DeleteLeaveTypeCommand { Id = id });
            return NoContent();
        }
    }
}
