using System;

namespace _02Exception
{
    class Program
    {
        private static void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            Console.WriteLine($"----- Unhandled exception ---- {e.Exception.ToString()}");
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"----- Unhandled exception ---- {((Exception)e.ExceptionObject).ToString()}");
        }
        static void Main(string[] args)
        {
            
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            try
            {
                Console.WriteLine("Main try indul");
                FoProgram();
                Console.WriteLine("Main try leall");

            }
            catch (Exception)
            {
                Console.WriteLine("Main catch indul");

                Console.WriteLine("Main catch leall");
            }
            finally
            {
                Console.WriteLine("Main finally indul");

                Console.WriteLine("Main finally leall");
            }


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        

        private static void FoProgram()
        {
            try
            {
                Console.WriteLine("Foprogram try indul");
                AlProgram();
                Console.WriteLine("Foprogram try leall");
               
            }
            catch (Exception)
            {
                Console.WriteLine("Foprogram catch indul");
                AlProgram();
                Console.WriteLine("Foprogram catch leall");
            }
            finally
            {
                Console.WriteLine("Foprogram finally indul");

                Console.WriteLine("Foprogram finally leall");
            }
        }

        private static void AlProgram()
        {
            try
            {
                Console.WriteLine("Alprogram try indul");
                throw new ConfuseCurrencyException("Nincs elég pénz a vásárláshoz");
                Console.WriteLine("Alprogram tryleall");
            }
            catch (Exception)
            {
                Console.WriteLine("Alprogram catch indul");
                Console.WriteLine("Alprogram catch leall");

            }
            finally
            {
                Console.WriteLine("Alprogram finally indul");

                Console.WriteLine("Alprogram finally leall");
            }
        }
    }
}
