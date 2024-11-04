using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.DFS.LCode_690
{

    public class LeetCode_690
    {
        private Dictionary<int, IList<int>> GetEmployeesSubordinates(IList<Employee> employees)
        {
            Dictionary<int, IList<int>> employeeSubordinates = new();

            foreach (Employee employee in employees)
            {
                employeeSubordinates.Add(employee.id, employee.subordinates);
            }

            return employeeSubordinates;
        }

        private Dictionary<int, int> GetEmployeeImportance(IList<Employee> employees)
        {
            Dictionary<int, int> employeeImportance = new();

            foreach (Employee employee in employees)
            {
                employeeImportance.Add(employee.id, employee.importance);
            }

            return employeeImportance;
        }


        private int DFS(Dictionary<int, IList<int>> employees,
                        Dictionary<int, int> employeeImportance,
                        int id)
        {
 
            int importance = employeeImportance[id];

            foreach (int empId in employees[id])
            {
                importance += DFS(employees, employeeImportance, empId);
            }

            return importance;
        }

        public int GetImportance(IList<Employee> employees, int id)
        {

            var employeesSubordinates = GetEmployeesSubordinates(employees);
            var employeesImportance = GetEmployeeImportance(employees);

            int subordinatesImportance = DFS(employeesSubordinates, employeesImportance, id);

            return subordinatesImportance;
        }
    }
}
