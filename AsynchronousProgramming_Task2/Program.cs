using System;
using System.Threading.Tasks;

namespace AsynchronousProgramming_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() => {
                return 42;
            });

            Console.WriteLine(t.Result);

            Task<int> t2 = Task.Run(() => {
                return 42;
            }).ContinueWith((i) => {

                return t.Result * 2;
            });

            Console.WriteLine(t2.Result);


            Console.ReadLine();
        }
    }
}
