using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Contacts.Persistance
{
    public interface ILeaveRequestRepository<T> : IGenericRepository<LeaveType>
    {

    }
}
}