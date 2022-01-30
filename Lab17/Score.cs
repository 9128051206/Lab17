using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Score <T>
    {
        public T Num { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public Score(T num, int balance, string name)
        {
            Num = num;
            Balance = balance;
            Name = name;
        }

        public string GetInfo()
        {
            return $"{Num} {Balance} {Name}";
        }
    }
}
