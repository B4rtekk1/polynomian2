using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using polynomian;

namespace WielomianyInformatyka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] wspolczynniki1 = new double[100];
            double[] wspolczynniki2 = new double[100];
            int n = 0;
            int nMax;


            Console.WriteLine("Wypisz współczynniki pierwszego wielomianu. Maksymalnie 100 współczynników. Jeżeli współczynnik ma być róny 0 wpisz 0 inaczej program przejdzie do odczytywania kolejnego wielomianu");
            
            while (double.TryParse(Console.ReadLine(), out double result1) && n < 100)
            {
                    wspolczynniki1[n] = result1;
                    n++;
            }
            nMax = n;
            
                           
            n = 0;
            Console.Clear();

            Console.WriteLine("Wypisz współczynniki drugiego wielomianu. Maksymalnie 100 współczynników. Jeżeli współczynnik ma być róny 0 wpisz 0 inaczej program przejdzie do odczytywania kolejnego wielomianu");
            
            while (double.TryParse(Console.ReadLine(), out double result2))
            {
                    wspolczynniki2[n] = result2;
                    n++;
            }

            if(n > nMax)
            {
                nMax = n;
            }
            
           
            

            Console.Clear();
            if (wspolczynniki1[0] == 0 && wspolczynniki2[0] == 0)
            {
                Console.WriteLine("Wielomian zerowy");
                Console.ReadLine();
            }
            else
            {
                Class1 class1 = new Class1();


                Console.WriteLine("Stopień wielomianu:");
                class1.grade(nMax);

                Console.WriteLine();

                Console.WriteLine("Współczynniki po dodaniu:");
                for (int i = 0; i < nMax; i++)
                {
                    class1.add(wspolczynniki1[i], wspolczynniki2[i]);

                }
                Console.WriteLine();

                Console.WriteLine("Współczynniki po odejmowaniu:");
                for (int i = 0; i < nMax; i++)
                {

                    class1.substraction(wspolczynniki1[i], wspolczynniki2[i]);
                }
                Console.WriteLine();

                Console.WriteLine("Współczynniki po mnożeniu:");
                for (int i = 0; i < nMax; i++)
                {

                    class1.multiplication(wspolczynniki1[i], wspolczynniki2[i]);
                }
                Console.ReadKey();
            }

        }
    }
}
