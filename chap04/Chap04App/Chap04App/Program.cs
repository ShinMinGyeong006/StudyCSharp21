using System;

namespace Chap04App
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = 37656234;
            if (values % 2 == 0)
            {
                Console.WriteLine("짝수입니다.");
            }
            else
            {
                Console.WriteLine("홀수입니다.");
            }
            if (values % 3 == 0)
            {
                Console.WriteLine("3의 배수입니다.");
            }
            else
            {
                Console.WriteLine("3의 배수가 아닙니다.");
            }
        }   
    }
}
