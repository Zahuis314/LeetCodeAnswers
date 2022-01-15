using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public static class Utils
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public static void IncreaseDictionary<T>(Dictionary<T, int> dict, T value, int defaultValue = 1) where T : notnull
        {
            if (dict.ContainsKey(value))
                dict[value] += 1;
            else
                dict.Add(value, defaultValue);
        }
        public static void DecreaseToDictionary<T>(Dictionary<T, int> dict, T value, bool remove = true) where T : notnull
        {
            dict[value] -= 1;
            if (remove && dict[value] == 0)
                dict.Remove(value);
        }
        public static List<Tuple<List<T>,R>> LoadTestCase<T,R>(string path)
        {
            List<Tuple<List<T>, R> > result = new List<Tuple<List<T>, R>>();
            var testcases = File.ReadAllLines(Path.Combine(@"..\..\..\TestCases", path));
            foreach(var testcase in testcases)
            {
                var line_parsed = testcase.Split(' ');
                R answer = (R)Convert.ChangeType(line_parsed[1],typeof(R));
                var cases = line_parsed[0].Split(',');
                List<T> list = new List<T>(cases.Select(x=> (T)Convert.ChangeType(x, typeof(T))));
                result.Add(new Tuple<List<T>, R>(list, answer));
            }
            return result;
        }
    }
}
