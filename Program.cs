using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RegularExpressions;



namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "23 * 45 =";
            var regexpLeft = new Regex(@"\d+\s*(\+|\-|\*|\/)");
            var regexpRight = new Regex(@"(\+|\-|\*|\/)\s*\d+");
            var regNumber = new Regex(@"\d+");
            var regexpOperation  = new Regex(@"\d+\s*(\+|\-|\*|\/)");
            MatchCollection matchesLeft = regexpLeft.Matches(input);
            MatchCollection matchesRight = regexpRight.Matches(input);
            foreach (Match match in matchesLeft)
            {
                Console.WriteLine("Левый операнд и орперация: " + match.ToString());
                MatchCollection numberLeft = regNumber.Matches(match.ToString());
                Console.WriteLine("Правый операнд: " + numberLeft[0]);

            }
            foreach (Match match in matchesRight)
            {
                Console.WriteLine("Левый операнд и орперация: " + match.ToString());
                MatchCollection numberRight = regNumber.Matches(match.ToString());
                Console.WriteLine("Правый операнд: " + numberRight[0]);

            }
            Console.ReadKey();
        }
    }
}
