using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个运算数：");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：(+ , - , * , /)");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个运算数：");
            float number2 = float.Parse(Console.ReadLine());
            switch (char.ToUpper(symbol))
            {
                case '+':
                    Console.WriteLine("{0}{1}{2}={3}",number1,symbol,number2,number1 + number2);
                    break;
                case '-':
                    Console.WriteLine("{0}{1}{2}={3}", number1, symbol, number2, number1 - number2);
                    break;
                case '*':
                    Console.WriteLine("{0}{1}{2}={3}", number1, symbol, number2, number1 * number2);
                    break;
                case '/':
                    if (number2 != 0)
                        Console.WriteLine("{0}{1}{2}={3}", number1, symbol, number2, number1 / number2);
                    else
                        Console.WriteLine("被除数不能为0!");
                    break;
            }
        }
    }
}
