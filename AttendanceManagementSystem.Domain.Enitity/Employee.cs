using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Domain.Enitities
{
    public class Employee
    {
        public Guid EmloyeeId { get; set; }
        public string? FullName {  get; set; }
        public string? Position {  get; set; }
        public string? CardNo {  get; set; }
        public IList<Log>?  Logs { get; set; }
        public Employee() { }
        public Employee(string FullName,string Postion,string CardNo)
        {
            this.EmloyeeId = Guid.NewGuid();
            this.FullName = FullName.Trim();
            this.Position = Postion.Trim();
            this.CardNo = CardNo.Trim();
            this.Logs = new List<Log>();

        }
    }
}
