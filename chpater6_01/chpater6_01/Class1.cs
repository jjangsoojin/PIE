using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace chpater6_01
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
    public class Class1
    {
        public char MiddleNode(string str)
        {
            Dictionary<char, int> charHash = new Dictionary<char, int>();
            
            // 문자 횟수 체크
            foreach (char c in str)
            {
                if (charHash.ContainsKey(c))
                {
                    charHash[c]++;
                }
                else
                {
                    charHash[c] = 1;              
                }
            }
           
            // 한번만 쓰인 문자 체크
            foreach (char c in str)
            {
                if (charHash[c] == 1)
                {
                    return c;
                }
            }
            return ' ';
        }
    }
}