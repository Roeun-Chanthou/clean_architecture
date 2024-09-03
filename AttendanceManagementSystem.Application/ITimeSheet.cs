using AttendanceManagementSystem.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Application
{
    public interface ITimeSheet
    {
        void AddEmployee(Employee emp);
        void UpdateEmployee(string EmployeeId, string FullName, string Position);
        void LogEmployee(string cardNo, Log logInfo);
        List<EmployeeView> GetAllEmployee();
        List<Employee> GetAllEmployee(bool isSimpleVersion);
        void DeleteEmployee(string EmployeeId); // New method
        void UpdateEmployee(string text1, string text2, string text3, string text4);
    }
}

