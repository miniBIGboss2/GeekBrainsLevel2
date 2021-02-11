using System;
using System.Collections;
using System.Collections.Generic;

namespace OopLessonFour
{
    public static class ConsoleOutput
    {
        public static void Print<T>(Dictionary<T, int> dictionary)
        {
            foreach (var d in dictionary)
                Console.WriteLine($"Число {d.Key} встречается {d.Value} раз.");
        }

        public static void Print(IEnumerable dictionary)
        {
            var key = (Dictionary<float, int>) dictionary;
            
            foreach (var el in key)
                Console.WriteLine($"Число {el.Key} встречается {el.Value} раз. ");
        }
    }
}