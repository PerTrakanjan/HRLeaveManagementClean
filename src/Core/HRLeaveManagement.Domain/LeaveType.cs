using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common

namespace HRLeaveManagement.Domain
{
    public class LeaveType : BaseEntity
    {
        public int Id { get; set}
        public string Name { get; set; } = string.Empty
        public int DefaultDays { get; set; }
    }

}