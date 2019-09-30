using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskVlaknaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> uloha = Task.Run(() =>
                 {
                     Random random = new Random();
                     return random.Next(100);
                 });
            int cislo = uloha.Result;
            Console.WriteLine(cislo);
            Console.ReadKey();
        }
    }
}
