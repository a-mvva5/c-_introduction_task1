using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ilk ededi daxil edin :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Son ededi daxil edin :");
            int m = Convert.ToInt32(Console.ReadLine()); ;
            int sum = 0;
            while (n<m)
            {
                if (n% 7 == 0)
                {
                    sum++;
                }
                n++;
            }
            Console.Write("Ilk ve son ededleri arasindaki 7 -e bolunen ededlerin sayi:  ");
            Console.Write(sum);
        }
    }
}
