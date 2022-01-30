using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер расчетного счета");
            int numint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс расчетного счета");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();
            
            Score<int> score1 = new Score<int>(numint, balance, name);
            Console.WriteLine(score1.GetInfo());

            Console.WriteLine("Введите строковый номер расчетного счета");
            string numstring = Console.ReadLine();
            Console.WriteLine("Введите баланс расчетного счета");
            balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            name = Console.ReadLine();
            
            Score<string> score2 = new Score<string>(numstring, balance, name);
            Console.WriteLine(score2.GetInfo());
            Console.ReadKey();
        }        
    }
}
