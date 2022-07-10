using System;

namespace Stroki_m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = "Nikolay is a good boy.Nikolay go to park.";
            string str1 = "Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. Были описаны основные операторы и методы, которые используются для работы со строками";
            string str2 = "Login1,LOgin2,login3,loGin4";

            Console.WriteLine(str.Replace("Nikolay", "Oleg"));
            Console.WriteLine(Zamena(str1));
            foreach (string n in Masiw(str2))
            {
                Console.WriteLine(n);
            }
            
          

        }
        public static string Zamena(string str1)
        {
            str1 = str1.Remove(0, (str1.IndexOf("Были")));
            return str1.Remove(str1.IndexOf(", которые"));

        }
        public static string[] Masiw(string str2)
        {
            str2 = str2.ToLower();
            string[] array = str2.Split(',');
           
            
            return array;
        }
    }
}
