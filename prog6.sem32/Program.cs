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
            private void Surrend()
            {
                Console.WriteLine($"Государство {title} сдалось");
                surrender = true;
            }
            private void Endwar()
            {
                score = population * millitarypow;
            }
            public string title;
            public int population;
            public float score;
            public float millitarypow;
            public bool surrender = false;
            public bool win = false; 
        };
        class peacefull : nation {
        private void Devpopulation()
        {
            Console.WriteLine($"\nУ государства {title} выросла популяция, военная сила уменьшена");
            population =(int)(population*1.5);
            millitarypow = (int)(millitarypow-0.1);
        }
        private void Display()
        {
            Console.WriteLine($"Информация о государстве {title}");
            Console.WriteLine($"Популяция - {population}");
            Console.WriteLine($"Военная мощь - {millitarypow}");
            Console.WriteLine($"Тип государства - Дружелюбное");
        }
    };
    static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
