using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;

namespace Problem_Solving.TwoPointers;

class ValidPointers
{

 
    public string IsPalindrome(string s)
    {
        int i = 0, j = s.Length - 1;

        while (i < s.Length && j >= 0)
        {

            while (!char.IsLetterOrDigit(s[i]) && i < j)
                i++;

            while (!char.IsLetterOrDigit(s[j]) && j < 1)
                j--;

            if (char.ToLower(s[i]) != char.ToLower(s[j]))
                return $"false: {s}";

            i++;
            j--;
        }

        return $"true: {s}";
    }


}
