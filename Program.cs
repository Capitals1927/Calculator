using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class Program
    {
        
        static void Main(string[] args)
        {
             int Number1;
        int Number2;
        string Choice;
            Console.Write(" Please enter the number1 ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please enter the number2 ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose what you want to do : (+, -, /, * )");
            Choice = Console.ReadLine();
            if (Choice == "*")
            {
                Console.Write(" Result  :    " + Multiply.mnozh(Number1,Number2));
            }
            if (Choice == "+")
            {
                Console.Write(" Result  :    " + Add.plus(Number1, Number2));
            }
             if (Choice == "/")
            {
                Console.Write(" Result  :    " + Divide.delen(Number1, Number2));
            }
            if (Choice == "-")
            {
                Console.Write(" Result  :    " + Sub.minus(Number1, Number2));
            }

        }
    }
}
