using System.Collections.Generic;

namespace OopLessonFour
{
    public static class CountElements
    {
        public static Dictionary<T, int> GetCounts<T>(IEnumerable<T> list)
        {
            var dct = new Dictionary<T, int>();
            
            foreach (var l in list)
                if (dct.ContainsKey(l))
                    dct[l]++;
                else
                    dct.Add(l, 1);
            return dct;
        }
    }
}