using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGameConsole
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Board b = new Board();
            ConsoleKeyInfo k;
            
            b.Draw();
            for(k =Console.ReadKey();k.Key!=ConsoleKey.Escape;k =  Console.ReadKey())
            {
                b.Update();
                b.Draw();
            }
        }

    }

}
