using System.Collections.Generic;
using System.Linq;
using static OopLessonFour.CountElements;
using static OopLessonFour.ConsoleOutput;

namespace OopLessonFour

{
    internal static class Program
    {
        public static void Main()
        {
            var myDigitList = new List<int>
            {
                1,1,1,2,2,3,4,4,4,4,5,5,6,6,6,7,8,8,8,8,9,9,9,9,9
            };
            
            var myGenericList = new List<float>
            {
                1.5F,1.5F,1.5F,2.1F,2.1F,3,4.5F,4.5F,4.5F,4.5F,5.1F,5.1F,6.5F,6.5F,6.5F,7.5F,8.1F,8.1F,8.1F,8.1F,9.5F,9.5F,9.5F,9.5F,9.5F
            };
            
            var myDigitDict = GetCounts(myDigitList);
            var myGenericDict = GetCounts(myGenericList);
            var myLinqDict = myGenericList.GroupBy(l => l)
                .Select(g => new {Value = g.Key, Count = g.Count()});

            Print(myDigitDict);
            
            Print(myGenericDict);
            
            Print(myLinqDict);
        }
    }
}