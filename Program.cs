using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    public class Program
    {

    public static void m1()
    {
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("method thred"+i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("method finished");
     }

    public static void m2()
    {
        for(char i ='A';i < 'E';i++)
        {
            Console.WriteLine("method2 thread"+i);
                
        }
        Console.WriteLine("method 2 finished");
    }
        static void Main(string[] args)
        {
        Thread t1= new Thread(m1);
        t1.Start();
        t1.Join();

        Thread t2 = new Thread(m2);
        t2.Start();
        t2.Join();


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("main thread "+i);
            Thread.Sleep(1000);
        }
       
        Console.WriteLine("main thread finished");
        }
    }

