using Problem_Solving.DFS.LCode_690;
using Problem_Solving.TwoPointers;

namespace Problem_Solving;

class Program
{


    static void Main(string[] args)
    {
        ValidPointers VP = new();
        string s;
        // s = VP.IsPalindrome("A man, a plan, a canal: Panama");
        s = VP.IsPalindrome(",.");
        System.Console.WriteLine(s);

        s = VP.IsPalindrome("0p");
        System.Console.WriteLine(s);

        s = VP.IsPalindrome("--==x;;;;;;;;;;;;;;)))))))))))))))))X+++++++++==============");
        System.Console.WriteLine(s);

 
    }
}