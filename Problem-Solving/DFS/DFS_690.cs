using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.DFS
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
                         HashSet<int> visited,
                         int id)
        {
            visited.Add(id);


            bool IsVisited = false;

            int importance = employeeImportance[id];


            foreach (int EmpId in employees[id])
            {
                IsVisited = visited.Contains(EmpId);

                if (IsVisited)
                    continue;

                importance += DFS(employees, employeeImportance, visited, EmpId);
            }

            return importance;
        }

        public int GetImportance(IList<Employee> employees, int id)
        {

            var employeesSubordinates = GetEmployeesSubordinates(employees);
            var employeesImportance = GetEmployeeImportance(employees);
            var visited = new HashSet<int>();


            int SubordinatesImportance = DFS(employeesSubordinates, employeesImportance, visited, id);


            return employeesImportance[id] + SubordinatesImportance;
        }
    }


    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
}
