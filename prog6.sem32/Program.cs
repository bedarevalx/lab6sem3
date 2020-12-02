using System;
namespace prog6.sem32
{
    class Program
    {
        class nation
        {
            void Read()
            {
                Console.WriteLine("Введите название государства:");
                Console.WriteLine(title);
                Console.WriteLine("Введите кол-во населения:");
                Console.WriteLine(population);
                Console.WriteLine("Введите военную мощь (=<2):");
                Console.WriteLine(millitarypow);
            }
            void Init(string a, int b, float c)
            {
                title = a;
                population = b;
                millitarypow = c;
            }
            void surrend()
            {
                Console.WriteLine($"Государство {title} сдалось");
                surrender = true;
            }
            void endwar()
            {
                score = population * millitarypow;
            }
            string title;
            int population;
            float score;
            float millitarypow;
            bool surrender = false;
            bool win = false;
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
