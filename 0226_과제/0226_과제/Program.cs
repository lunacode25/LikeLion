using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0226_과제
{
    class Program
    {
        static void Main(string[] args)
        {

            /*// 크기가 5인 정수 배열 생성 및 값 저장
            int[] numbers = { 10, 20, 30, 40, 50 };

            // 가로 방향으로 배열 요소 출력
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }*/

            Console.Write("숫자 입력: ");
            string[] input = Console.ReadLine().Split(); // 공백 기준으로 나누기
            //숫자 출력
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }


        }
    }
}
