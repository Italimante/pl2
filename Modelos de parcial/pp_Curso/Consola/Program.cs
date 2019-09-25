using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            string soloLetras = @"^[a-zA-Z]+$";

            string pattern = @"^([0-9][0-9]-)?\d{2,8}$";

            string doc = "21-1234562"; //XX-XXXXX

            if (Regex.IsMatch(doc, pattern))
            {
                Console.WriteLine("Si");
            }
            else {
                Console.WriteLine("No");
            }


            Console.ReadKey();

        }
    }
}
