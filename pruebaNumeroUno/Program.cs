using System;

namespace pruebaNumeroUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            do
            {
                Console.WriteLine("type a number between 1 and 1000 ");

                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            } while (!(number >= 1 && number <= 1000));

            for(int i =1; i < number; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("foo bar");
                }
                else if (i % 3 == 0){
                    Console.WriteLine("bar");
                }

                else if ((i % 5 == 0))
                {
                    Console.WriteLine("foo");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

            pruebaDos dos = new pruebaDos();
            Console.WriteLine("escribe la oracion que desea contar las vocales");
            string oracion = Console.ReadLine();
            dos.contar(oracion);
            
        }


    }
}
