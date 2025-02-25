using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표배우기
{
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔창의 크기를 설정합니다.
            Console.SetWindowSize(80, 25); // 가로 80, 세로 25

            // 콘솔 버퍼의 크기를 설정합니다. (스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25); 

            Console.CursorVisible = false; // 커서를 보이지 않게 합니다.

            Console.Clear(); // 콘솔창을 지웁니다.
            /*Console.SetCursorPosition(40, 12); // 콘솔창의 가로 40, 세로 12 위치로 커서를 이동합니다.
            Console.Write("Hello, World!"); // 커서 위치에 문자열을 출력합니다.
            Thread.Sleep(5000); // 1초 대기합니다.*/

            /*Console.Clear(); // 콘솔창을 지웁니다.
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("┃                                  대장장이                                    ┃");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");  
            
            Thread.Sleep(5000); // 1초 대기합니다.*/



            for (int x = 0; x < 25; x++)
            {
                Console.Clear(); // 콘솔창을 지웁니다.
                Console.SetCursorPosition(10, x);
                Console.Write("◎");
                Thread.Sleep(500); // 0.1초 대기합니다.


            }
            
        }
    }
}
