using System;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveAllocation>
    {
        Task ChangeApprovalStatus(object leaveRequest, bool? approved);
    }
}

