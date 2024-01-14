using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace chpater6_02
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
        // 문자열에서 지정된 문자들을 삭제하는 함수
        public string removeChars(string str, string remove)
        {
            char[] s = str.ToCharArray();
            char[] r = remove.ToCharArray();
            int src, dst = 0;
            // flags는 자동으로 false로 초기화되며, 128의 크기는 ASCII를 가정합니다.
            bool[] flags = new bool[128];
            // 제거할 문자에 대한 플래그 설정
            for (src = 0; src < r.Length; src++)
            {
                flags[r[src]] = true;
            }
            // 이제 모든 문자를 반복하면서, 플래그가 설정되지 않은 경우에만 복사
            for (src = 0; src < s.Length; src++)
            {
                if (!flags[s[src]])
                {
                    s[dst++] = s[src];
                }
            }
            // 최종적으로 새로운 문자 배열을 사용하여 새로운 문자열 생성 및 반환
            return new string(s, 0, dst);
        }
    }
}