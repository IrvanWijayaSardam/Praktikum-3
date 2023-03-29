using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class MyThread
{
    public static void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("cuci baju ke {0}", i);
            Thread.Sleep(3000);
        }
    }
    public static void Thread2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Setria baju ke {0}", i);
            Thread.Sleep(3000);
        }
    }
}