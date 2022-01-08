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
    }
}
