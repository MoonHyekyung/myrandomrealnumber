using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int nan = ran.Next(0, 101);
            int input;

            do
            {
                Console.Write("0부터 100사이의 숫자를 입력해주세요 : ");
                input = int.Parse(Console.ReadLine());
                if (input > nan)
                {
                    Console.WriteLine(input + "보다는 작은 숫자입니다.");
                }else if(input < nan)
                {
                    Console.WriteLine(input + "보다는 큰 숫자입니다.");
                }
                Console.WriteLine();
            } while (input != nan);
            Console.WriteLine("정답입니다!");
        }
    }
}
