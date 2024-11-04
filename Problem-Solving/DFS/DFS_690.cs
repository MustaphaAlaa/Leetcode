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


            bool isVisited = false;

            int importance = employeeImportance[id];


            foreach (int empId in employees[id])
            {
                isVisited = visited.Contains(empId);

                if (isVisited)
                    continue;

                importance += DFS(employees, employeeImportance, visited, empId);
            }

            return importance;
        }

        public int GetImportance(IList<Employee> employees, int id)
        {

            var employeesSubordinates = GetEmployeesSubordinates(employees);
            var employeesImportance = GetEmployeeImportance(employees);
            var visited = new HashSet<int>();


            int subordinatesImportance = DFS(employeesSubordinates, employeesImportance, visited, id);


            return subordinatesImportance;
        }
    }


    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
}
