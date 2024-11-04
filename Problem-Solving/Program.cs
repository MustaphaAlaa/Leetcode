using Problem_Solving.DFS.LCode_690;

namespace Problem_Solving;

class Program
{


    static void Main(string[] args)
    {


        

        var ints = new List<List<object>>  {
            new List<object> {1,5, new List<int>  { 2, 3 } },
            new List<object> {2,3, new List<int>  {  } },
            new List<object> {3,3, new List<int>  {  } },
        };

        LeetCode_690_v2 d = new();

        var emps = new List<Employee>  {
            new Employee {id = 1, importance = 5, subordinates =  new List<int>  { 2, 3 } },
            new Employee {id = 2, importance = 3, subordinates =  new List<int>  {  } },
            new Employee {id = 3, importance = 3, subordinates =  new List<int>  {  } },
        };





        var totalImportance = d.GetImportance(emps, 1);


        Console.WriteLine(totalImportance);


    }
}