using System;
using System.Text;

namespace Capitulo5
    //ejercicio5.17
{
    class capitulo
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un valor entre 1 y 3000");
            n = int.Parse(Console.ReadLine());
            if (n <= 3000 && 0 < n)
            {

                Console.WriteLine("Valor inicial: " + n);
                Console.WriteLine("Valor en numeros romanos:");
                Console.WriteLine(intRom(n));
            }
            else
            {
                Console.WriteLine("El numero debe estar entre 1 y 3000");
            }
        }

        public static string intRom(int n)
        {
            string[] simboloromano = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] int_valor = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var numRomano = new StringBuilder();
            var IndiNum = 0;
            while (n != 0)
            {
                if (n >= int_valor[IndiNum])
                {
                    n -= int_valor[IndiNum];
                    numRomano.Append(simboloromano[IndiNum]);
                }
                else
                {
                    IndiNum++;
                }
            }

            return numRomano.ToString();
        }
    }
}
