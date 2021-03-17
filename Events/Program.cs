using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;
namespace Events
{
    class Program
    {
        static int counter = 0;
        static string displayString = "Daniel Simonovski .!!";
        static void Main(string[] args)
        {

            Timer timer = new Timer(300);
            
            timer.Elapsed += new ElapsedEventHandler(WriteChar);
            timer.Elapsed += new ElapsedEventHandler(Simce);
            timer.Start();
            System.Threading.Thread.Sleep(5000);


            ReadLine();
        }

        

        static void WriteChar(object source,ElapsedEventArgs e)
        {
            Write(displayString[counter++ % displayString.Length]);
        }

        static void Simce(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Simce");
        }
    }
}
