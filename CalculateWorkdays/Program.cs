using System;

namespace CalculateWorkdays
{
    class Program
    {
        private static TimeSpan totalRecup;
        private static TimeSpan day = new TimeSpan(7, 36, 0);

        static void Main(string[] args)
        {

            Console.WriteLine("Saldo Recup uren:  ");
            int hours;
            int.TryParse(Console.ReadLine(), out hours);
            Console.WriteLine("Saldo Recup minuten:  ");
            int minutes;
            int.TryParse(Console.ReadLine(), out minutes);
            totalRecup = new TimeSpan(hours, minutes, 0);

            Console.WriteLine("Hoeveel dagen recup:  ");
            int days;
            int.TryParse(Console.ReadLine(), out days);

            SubstractDays(days);

            Console.ReadLine();

        }

        private static void SubstractDays(int aantal)
        {

            for (int i = 0; i < aantal; i++)

            {
                totalRecup = totalRecup.Subtract(day);
            }

            var h = System.Math.Floor(totalRecup.TotalHours);
            var m = Math.Round((totalRecup.TotalHours - h) * 60);
            Console.WriteLine($"Overblijvende uren = {h} - aantal minuten = {m}");
        }
    }
}
