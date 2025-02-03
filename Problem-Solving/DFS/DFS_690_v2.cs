using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.DFS.LCode_690
{

    public class LeetCode_690_v2
    {
        //This solution is inspired by DSA course.
        //Instead of using 2 dictionaries, i used one hash table.
        //Its key the employee's id, and the value is the employee object itself.  

        public Dictionary<int, Employee> GetEmployee(IList<Employee> employees)
        {
            Dictionary<int, Employee> employeesTable = new();

            foreach (Employee employee in employees)
            {
                employeesTable.Add(employee.id, employee);
            }

            return employeesTable;
        }

        private int DFS(Dictionary<int, Employee> employees, int id)
        {

            int importance = employees[id].importance;

            foreach (int empId in employees[id].subordinates)
            {
                importance += DFS(employees, empId);
            }

            return importance;
        }

        public int GetImportance(IList<Employee> employees, int id)
        {

            var getEmployee = GetEmployee(employees);
            int subordinatesImportance = DFS(getEmployee, id);

            return subordinatesImportance;
        }
    }
}
