using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataSumStringsasNumbers
{
    public static class SumStrings
    {
        public static string sumStrings(string a, string b)
        {
            var carry = 0;
            var answer = "";
            for(var i=1; i<= Math.Max(a.Length, b.Length); i++)
            {
                var sum = int.Parse(a.Length >= i ? a[a.Length - i].ToString() : "0") + int.Parse(b.Length >= i ? b[b.Length - i].ToString() : "0") + carry;
                carry = sum > 9 ? 1 : 0;
                answer = (sum%10).ToString() + answer;
            }
            return (carry == 0 ? answer : "1" + answer).TrimStart('0');
        }
    }
}
