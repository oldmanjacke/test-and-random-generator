using Lexicon.CSharp.InfoGenerator;
using System;

namespace test_and_random_namn
{
    class Program
    {
        static InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);

        static void Main(string[] args)
        {
            for (int i =0; i <5; i++)
            {

            Console.WriteLine(infoGen.NextAnimal());
            }

        }
    }
}
