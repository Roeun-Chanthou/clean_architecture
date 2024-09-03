using AttendanceManagementSystem.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AttendanceManagementSystem.Application
{
    public class FileTimeSheet : ITimeSheet
    {
        public List<Employee>? Employees { get; set; }

        public FileTimeSheet()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            if (string.IsNullOrEmpty(emp.FullName) || string.IsNullOrEmpty(emp.Position) || string.IsNullOrEmpty(emp.CardNo))
            {
                throw new ArgumentException("Please provide all employee data!");
            }
            else if (Employees!.Any(e => e.CardNo == emp.CardNo))
            {
                throw new ArgumentException("Duplicate card number. Please provide a unique card number.");
            }
            else
            {
                Employees?.Add(emp);
            }
        }


        public List<EmployeeView> GetAllEmployee()
        {
            return Employees!.Select(emp => new EmployeeView()
            {
                EmployeeId = emp.EmloyeeId,
                FullName = emp.FullName,
                Postion = emp.Position,
                CardNo = emp.CardNo
            }).ToList();
        }

        public List<Employee> GetEmployee(bool isSimpleVersion)
        {
            return Employees!;
        }

        public void LogEmployee(string cardNo, Log logInfo)
        {
            if (string.IsNullOrEmpty(cardNo))
            {
                throw new ArgumentException("Card No cannot be empty");
            }
            int foundIndex = Employees!.FindIndex(emp => emp.CardNo == cardNo.Trim());
            if (foundIndex < 0)
            {
                throw new ArgumentException($"Card No {cardNo} not found in employee list.");
            }
            Employees[foundIndex].Logs!.Add(logInfo);
        }

        public void UpdateEmployee(string EmployeeId, string FullName, string Position, string CardNo)
        {
            if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Position) || string.IsNullOrEmpty(CardNo))
            {
                throw new ArgumentException("Please provide all employee data!");
            }
             
            Guid employeeGuid;
            if (!Guid.TryParse(EmployeeId, out employeeGuid))
            {
                throw new ArgumentException("Invalid Employee ID format.");
            }

            int foundIndex = Employees!.FindIndex(em => em.EmloyeeId == employeeGuid);
            if (foundIndex < 0)
            {
                throw new ArgumentException("Employee not found.");
            }

            if (Employees.Any(e => e.CardNo == CardNo && e.EmloyeeId != employeeGuid))
            {
                throw new ArgumentException("Duplicate card number. Please provide a unique card number.");
            }

            Employees[foundIndex].FullName = FullName;
            Employees[foundIndex].Position = Position;
            Employees[foundIndex].CardNo = CardNo;
        }

        public List<Employee> GetAllEmployee(bool isSimpleVersion)
        {
            return Employees!;
        }

        public void DeleteEmployee(string EmployeeId)
        {
            Guid employeeGuid;
            if (!Guid.TryParse(EmployeeId, out employeeGuid))
            {
                throw new ArgumentException("Invalid Employee ID format.");
            }

            int foundIndex = Employees!.FindIndex(emp => emp.EmloyeeId == employeeGuid);
            if (foundIndex < 0)
            {
                throw new ArgumentException("Employee not found.");
            }
            Employees.RemoveAt(foundIndex);
        }

        public void UpdateEmployee(string EmployeeId, string FullName, string Position)
        {
            throw new NotImplementedException();
        }
    }
}
