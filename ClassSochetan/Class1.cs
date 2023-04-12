using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClassSochetan
{
    
    public class ClassSochetan : Component
    {
        int[] vect;

        public ClassSochetan()
        {
        }

        public ClassSochetan(int N)
        {
            vect = new int[N];
            for (int i = 0; i < N; i++) vect[i] = i;
        }

        public int[] getSohetan(double[] vect, double val, int k, int n)
        {
            int[] A    = new int[k];
            int[] retV = new int[n];
            int p;

            for(int i = 0; i < k; i++) A[i] = i;

            p = k;
            while (p >= 1)
            {
                 // {вывод подмножества на экран}
                //  for m := 1 to k do
                //  write(A[m],' ');
                //  writeln;
                double summ = 0.0;
                for (int i = 0; i < k; i++) summ += A[i];

                if (summ == val)
                {
                    for (int i = 0; i < k; i++) retV[A[i]] = 1;
                    return retV;
                }
 
                if  (A[k] == n) p = p - 1;
                else
                    p = k;
 
                if (p >= 1) 
                {
                    for(int i = k; i > p; i--) A[i] = A[p] + i - p + 1;
                }
          }

            return retV;
       }

        public void getSohetan(int k, int n)
        {
           
            int[] A = new int[k];
            int p;

            for (int i = 0; i < k; i++) A[i] = i;

            Console.WriteLine("Begin");

            p = k;
            while (p > 1)
            {
                Console.WriteLine(" вывод подмножества на экран");

                for (int m = 0; m < k; m++)
                {
                    Console.Write("{0:N}  ", A[m]);
                    Console.WriteLine();
                }

                Console.WriteLine("End вывод подмножества на экран");
                Console.Read();

                if (A[k - 1] == n) p = p - 1;
                else
                    p = k;

                if (p > 1)
                {
                    for (int i = k; i > p; i--) A[i] = A[p] + i - p + 1;
                }
            }

        }
    }
}
