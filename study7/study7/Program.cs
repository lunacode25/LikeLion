﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //단항 연산자
             int number = 5;
             bool flag = true;


             Console.WriteLine(+number); //양수 출력 : 5
             Console.WriteLine(-number); //음수 출력 : -5

             Console.WriteLine(!flag);  //논리 부정 : false 



             //~ 비트 반전
             //10 1010
             //   0101   4바이트 0000 0000 0000 0000 0000 0000 0000 1010

             int num = 10;
             int result = ~num;   //모든 비트 반전 : 1111 0101 결과 


             Console.WriteLine("원래 값 : " + num);
             Console.WriteLine("~ 연산자 적용 후: " + result);*/


            /* int iKor = 90;
             int iEng = 75;
             int iMath = 58;

             int sum = 0;
             float average = 0.0f;

             sum = iKor + iEng + iMath;

             average = (float)sum / 3;  //평균

             Console.WriteLine("총점 : " + sum);
             Console.WriteLine("평균 : " + average);*/

            /* int a = 10;
             a += 5;  // a  = a + 5;

             Console.WriteLine(a);*/

            /*int a = 10;
            a += 5;  // a  = a + 5;
            Console.WriteLine(a);
            a -= 5;  // a  = a - 5;
            Console.WriteLine(a);
            a *= 5;  // a  = a * 5;
            Console.WriteLine(a);
            a /= 5;  // a  = a / 5;
            Console.WriteLine(a);
            a %= 5;  // a  = a % 5;
            Console.WriteLine(a);*/


            /*//문제 1. 학점 평균 계산 프로그램
                설명: 국어, 영어, 수학 점수를 사용자로부터 입력받아 총점과 평균을 구하는 프로그램을 작성하세요.
                 요구사항: 각 과목의 점수는 정수형으로 입력받습니다.
                총점을 구한 후, 평균을 계산할 때 정수형 총점을 실수형으로 캐스팅하여 소수점까지 정확하게 계산합니다.
                평균은 소수점 둘째 자리까지 출력하세요.
                문제 2. 비트 반전(~) 연산자 활용 프로그램
                설명:
                사용자로부터 정수를 입력받아, 해당 정수의 모든 비트를 반전(~)한 결과를 출력하는 프로그램을 작성하세요.
                요구사항:정수를 입력받습니다.
                비트 반전 연산자(~)를 이용하여 입력된 정수의 비트를 반전합니다.
                원래의 값과 비트 반전 후의 값을 함께 출력합니다.
                ----- 소수점 포맷 출력 예시
                double value = 1234.56;
                Console.WriteLine(value.ToString("F2")); // 출력: "1234.56"*/



            /*Console.Write("국어 점수를 입력하세요: ");
            int korean = int.Parse(Console.ReadLine());

            Console.Write("영어 점수를 입력하세요: ");
            int english = int.Parse(Console.ReadLine());

            Console.Write("수학 점수를 입력하세요: ");
            int math = int.Parse(Console.ReadLine());

            // 총점
            int total = korean + english + math;

            // 평균 
            double average = (double)total / 3;

            Console.WriteLine($"총점: {total}");
            Console.WriteLine($"평균: {average}"); */




        }
    }
}
