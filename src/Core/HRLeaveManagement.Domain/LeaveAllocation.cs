using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRLeaveManagement.Domain;

public class LeaveAllocation
{
    public int Id { get; set; }
    public int NumberOfDays { get; set; }
    public LeaveType LaveType { get; set; }
    public int Period { get; set; }
}
