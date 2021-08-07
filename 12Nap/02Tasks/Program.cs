
using System;
using System.Threading;
using System.Threading.Tasks;

namespace _02Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //Test2();


            Test3();

            Console.ReadLine();
        }

        private static void Test3()
        {
            var cts = new CancellationTokenSource();
            Action todo = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (cts.Token.IsCancellationRequested)
                    {
                        Console.WriteLine("Cancelt Kaptunk");
                    }
                    cts.Token.ThrowIfCancellationRequested();
                    Console.WriteLine($"i:{i}");
                    Thread.Sleep(100);

                }

            };
            var task = new Task(todo, cts.Token);
            task.Start();
            Thread.Sleep(200);

            Console.WriteLine("Megállítjuk a folyamatot");
            cts.Cancel();
            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    if (e is TaskCanceledException)
                    {
                        Console.WriteLine("Cancel történt");
                    }
                }

            }
        }

        private static void Test2()
        {
            Action todo = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"i:{i}");
                    Thread.Sleep(100);

                }
                throw new StackOverflowException();
            };
            var task = new Task(todo);
            task.Start();

            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {

                Console.WriteLine(ex.Flatten().Message);

                //vagy
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void Test1()
        {
            Action todo = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"i:{i}");
                    Thread.Sleep(300);

                }
            };


            var task = new Task(todo);

            Console.WriteLine($"Statusz : {task.Status}");

            task.Start();
            Console.WriteLine($"Statusz : {task.Status}");
            Thread.Sleep(100);
            Console.WriteLine($"Statusz : {task.Status}");

            task.Wait();
            Console.WriteLine($"Statusz : {task.Status}");
           
        }
    }
}
