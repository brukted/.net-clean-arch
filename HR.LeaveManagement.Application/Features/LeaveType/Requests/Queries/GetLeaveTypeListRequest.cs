using System;
using HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Requests
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
        public GetLeaveTypeListRequest()
        {
        }
    }
}

