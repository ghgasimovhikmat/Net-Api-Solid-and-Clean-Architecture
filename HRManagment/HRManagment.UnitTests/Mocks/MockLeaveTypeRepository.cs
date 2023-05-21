using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagment.Application.Contracts.Persistence;
using HRManagment.Domain;
using Moq;

namespace HRManagment.UnitTests.Mocks
{
    public static class MockLeaveTypeRepository
    {
        public static Mock<ILeaveTypeRepository> GetLeaveTypeRepository()
        {
            var leaveTypes= new List<LeaveType>
            {
                new LeaveType
                {
                    Id=1,
                    DefaultDays=10,
                    Name="Test Vacation"
                },
                  new LeaveType
                {
                    Id=2,
                    DefaultDays=10,
                    Name="Test Vacation"
                },
                    new LeaveType
                {
                    Id=3,
                    DefaultDays=15,
                    Name="Test Maternity"
                },
            };
            var mockRepo = new Mock<ILeaveTypeRepository>();
            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(leaveTypes);

            mockRepo.Setup(r => r.Add(It.IsAny<LeaveType>())).ReturnsAsync((LeaveType leaveType) =>
            {
                leaveTypes.Add(leaveType);
                return leaveType;
            });
            return mockRepo;
        }
    }
}
