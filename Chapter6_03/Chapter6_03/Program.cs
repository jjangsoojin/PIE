using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_03
{
    class Program
    {
        static void Main()
        {
            // 주어진 문자열
            string input = "Do or do not, there is no try.";

            // 문자열의 단어를 뒤집은 결과를 출력
            string reversedWords = ReverseWords(input);
            Console.WriteLine(reversedWords);
        }

        /*
        // 문자열의 단어를 뒤집는 함수
        static string ReverseWords(string str)
        {
            // 임시로 문자열을 저장할 배열
            char[] buffer = new char[str.Length];

            // 문자열을 거꾸로 읽을 위치 지정
            int slen = str.Length;
            int tokenReadPos = slen - 1;
            int wordReadPos, wordEnd, writePos = 0;

            // 문자열을 끝에서부터 읽으면서 단어를 뒤집어서 buffer에 저장
            while (tokenReadPos >= 0)
            {
                // 현재 위치의 문자가 공백인 경우
                if (str[tokenReadPos] == ' ')
                {
                    // buffer에 현재 위치의 문자(공백)을 저장하고 writePos 증가 후 tokenReadPos 감소
                    buffer[writePos++] = str[tokenReadPos--];
                }
                else
                {
                    // 단어의 끝 지점 찾기
                    wordEnd = tokenReadPos;
                    while (tokenReadPos >= 0 && str[tokenReadPos] != ' ')
                        tokenReadPos--;

                    // 단어의 시작 지점 찾기
                    wordReadPos = tokenReadPos + 1;

                    // 단어를 거꾸로 buffer에 저장
                    while (wordReadPos <= wordEnd)
                        buffer[writePos++] = str[wordReadPos++];
                }
            }

            // buffer에 저장된 문자열을 뒤집어서 반환
            Array.Reverse(buffer, 0, writePos);
            return new string(buffer, 0, writePos);
        }
        */
        static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');
            Array.Reverse(words);
            return string.Join("", words);
        }
    }
}
