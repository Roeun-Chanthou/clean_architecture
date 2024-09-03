using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Domain.Enitities
{
    public class EmployeeView
    {
        public Guid EmployeeId { get; set; }
        public string? FullName {  get; set; }
        public string? Postion {  get; set; }
        public string? CardNo {  get; set; }
       
    }
}
