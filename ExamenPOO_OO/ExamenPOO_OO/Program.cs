using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Simulateur.Simuler();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
