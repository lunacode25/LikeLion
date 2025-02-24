using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // 이것의 의미는 task를 사용하기 위해서 사용한다.
namespace study8
{
    class Program
    {
        static void Main(string[] args) // 이것의 의미는 프로그램이 시작되는 부분이다.
        {
            //두 겂을 비교하여 관계를 평가한다. 
            // == 같다 != 같지 않다 a < b  c > d  <=  =>

            /* int x = 5, y = 10;

             Console.WriteLine(x < y); // true 이것의 의미는 x가 y보다 작다는 것이다.
             Console.WriteLine(x > y); // false 이것의 의미는 x가 y보다 크다는 것이다.
             Console.WriteLine(x <= y); // true 이것의 의미는 x가 y보다 작거나 같다는 것이다.
             Console.WriteLine(x >= y); // false 이것의 의미는 x가 y보다 크거나 같다는 것이다.
             Console.WriteLine(x == y); // false 이것의 의미는 x와 y가 같다는 것이다.
             Console.WriteLine(x != y); // true 이것의 의미는 x와 y가 같지 않다는 것이다.

             //논리 연산자

             bool a = true; // 이것의 의미는 참을 의미한다.
             bool b = false; // 이것의 의미는 거짓을 의미한다.

             Console.WriteLine(a && b); // false 이것의 의미는 a와 b가 모두 참이어야 참이다.
             Console.WriteLine(a || b); // true 이것의 의미는 a와 b중 하나만 참이어도 참이다.
             Console.WriteLine(!a); // false 이것의 의미는 a가 거짓이면 참이다.*/

            /*int x = 5, y = 3;// 0101 0011

            Console.WriteLine(x & y); // 이것의 의미는 x와 y를 비트단위로 AND 연산을 한다.
            Console.WriteLine(x | y); // 이것의 의미는 x와 y를 비트단위로 OR 연산을 한다.
            Console.WriteLine(x ^ y); // 이것의 의미는 x와 y를 비트단위로 XOR 연산을 한다.
            Console.WriteLine(~x); // 이것의 의미는 x를 비트단위로 NOT 연산을 한다.
            Console.WriteLine(x << 2); // 이것의 의미는 x를 2비트 왼쪽으로 시프트한다.
            Console.WriteLine(x >> 2); // 이것의 의미는 x를 2비트 오른쪽으로 시프트한다.*/


            /*int score = 85;

            if (score >= 90)// 이것의 의미는 score가 90보다 크거나 같으면 A학점을 출력한다.
            {
                Console.WriteLine("A 학점");
            }
            else
            {
                Console.WriteLine("B 학점");
            }*/


            /*int score = 60;

            if (score >= 90)
            {
                Console.WriteLine("A 학점");// 이것의 의미는 score가 90보다 크거나 같으면 A학점을 출력한다.
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");// 이것의 의미는 score가 80보다 크거나 같으면 B학점을 출력한다.
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");// 이것의 의미는 score가 70보다 크거나 같으면 C학점을 출력한다.
            }
            else
            {
                Console.WriteLine("F 학점");// 이것의 의미는 score가 70보다 작으면 F학점을 출력한다.
            }*/


            //가지고 있는 소지금을 입력하세요 : 
            //0~100 무한의 대검 +1
            //101~200 카타나 +2
            //201~300 진은검 +3
            //301~400 집판검 +4
            //401~500 엑스칼리버 +5
            //501~600 유령검 +6


            //2단계 
            //캐릭터 멋사검존
            //무기 : 가지고 있는 무기이름 표시하기
            //공격력 : 100 + 1 

            /*문제 1.세 정수의 최대값 구하기
            문제 설명:
            사용자로부터 3개의 정수를 입력받아 그 중 가장 큰 값을 출력하는 프로그램을 작성하세요.
            요구사항:
            사용자에게 세 개의 정수를 입력받습니다.
            if문을 사용하여 가장 큰 정수를 결정합니다.
            결과를 “최대값: X” 형식으로 출력합니다.*/

            /*Console.Write("첫 번째 정수를 입력하세요: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("두 번째 정수를 입력하세요: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("세 번째 정수를 입력하세요: ");
            int num3 = int.Parse(Console.ReadLine());

            // 초기 최대값을 첫 번째 숫자로 설정
            int max = num1;

            // 두 번째 숫자가 더 크면 max를 갱신
            if (num2 > max)
            {
                max = num2;
            }

            // 세 번째 숫자가 더 크면 max를 갱신
            if (num3 > max)
            {
                max = num3;
            }

            // 결과 출력
            Console.WriteLine("최대값: " + max);*/


            /*문제 2.점수에 따른 학점 평가
            문제 설명:
            학생의 점수를 입력받아 아래 기준에 따라 학점을 출력하는 프로그램을 작성하세요.

            90 이상: A 학점
            80 이상 90 미만: B 학점
            70 이상 80 미만: C 학점
            60 이상 70 미만: D 학점
            60 미만: F 학점*/

           /* Console.Write("점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());

            // 학점 변수
            string grade;

            // 학점 결정
            if (score >= 90)
            {
                grade = "A 학점";
            }
            else if (score >= 80)
            {
                grade = "B 학점";
            }
            else if (score >= 70)
            {
                grade = "C 학점";
            }
            else if (score >= 60)
            {
                grade = "D 학점";
            }
            else
            {
                grade = "F 학점";
            }

            // 결과를 출력합니다.
            Console.WriteLine("학점: " + grade);*/


            /*문제 3.간단한 사칙연산 계산기
            문제 설명:
            사용자로부터 두 개의 숫자와 연산자(+, -, *, /)를 입력받아 해당 연산을 수행하고 
            결과를 출력하는 계산기 프로그램을 작성하세요.

            요구사항:
            두 개의 숫자와 연산자 기호를 입력받습니다.
            if문을 사용하여 연산자를 확인하고 해당 연산을 수행합니다.
            나눗셈의 경우 0으로 나누는 상황을 처리하여 에러 메시지를 출력합니다.
            결과는 “결과: X” 형식으로 출력합니다.*/

            /*// 첫 번째 숫자 입력
            Console.Write("첫 번째 숫자를 입력하세요: ");
            double num1 = double.Parse(Console.ReadLine()); // 

            // 연산자 입력 (문자열의 첫 번째 문자를 사용)
            Console.Write("연산자를 입력하세요 (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            // 두 번째 숫자 입력
            Console.Write("두 번째 숫자를 입력하세요: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;
            bool valid = true; // 올바른 연산인지 판단하기 위한 변수

            // 입력된 연산자에 따라 계산 수행
            if (op == '+')
            {
                result = num1 + num2;
            }
            else if (op == '-')
            {
                result = num1 - num2;
            }
            else if (op == '*')
            {
                result = num1 * num2;
            }
            else if (op == '/')
            {
                // 0으로 나누는 경우 체크
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("오류: 0으로 나눌 수 없습니다.");
                    valid = false;
                }
            }
            else
            {
                Console.WriteLine("잘못된 연산자입니다.");
                valid = false;
            }

            // 올바른 연산이면 결과 출력
            if (valid)
                Console.WriteLine("결과: " + result);*/







        }
    }
}
