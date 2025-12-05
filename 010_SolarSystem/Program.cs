using _010_SolarSystem;
using System.Collections.Generic;
using System;
using System.Linq; // Додано для використання Linq, якщо знадобиться

namespace _010_SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet moon = new Planet("Мiсяць", 1737.4, 7.3477e22, 2.1958e10, 3.793e7, 27.32);
            Planet phobos = new Planet("Фобос", 11.2, 1.0659e16, 5.761e3, 5.72e3, 0.32);
            Planet deimos = new Planet("Деймос", 6.2, 1.4762e15, 9.99e2, 3.14e2, 1.26);

            List<Planet> earthSatellites = new List<Planet> { moon };
            List<Planet> marsSatellites = new List<Planet> { phobos, deimos };
            List<Planet> noSatellites = new List<Planet>(); // Для планет без супутників

            NonSatelite mercury = new NonSatelite("Меркурiй", 2439.7, 3.3011e23, 6.083e10, 4.098e7, 58.646, 0.4, noSatellites);
            NonSatelite venus = new NonSatelite("Венера", 6051.8, 4.8675e24, 9.38e11, 4.602e8, 243.025, 0.7, noSatellites);
            NonSatelite earth = new NonSatelite("Земля", 6371.0, 5.972e24, 1.083e12, 5.101e8, 1.0, 1.0, earthSatellites);
            NonSatelite mars = new NonSatelite("Марс", 3389.5, 6.4171e23, 1.6318e11, 1.448e8, 1.026, 1.5, marsSatellites);

            // 4. Створюємо список не-супутників (планет)
            List<NonSatelite> nonSatellites = new List<NonSatelite> { mercury, venus, earth, mars };

            // 5. Створюємо об'єкт SolarSystem
            SolarSystem solarSystem = new SolarSystem(nonSatellites);

            // 6. Приклади використання методів SolarSystem
            Console.WriteLine("--- Створення системи завершено ---");
            Console.WriteLine(solarSystem.ToString());

            Console.WriteLine("\n--- Пошук планети Земля ---");
            Planet searchedPlanet = solarSystem.Search("Земля");
            Console.WriteLine($"Знайдено: {searchedPlanet.ToString()}");

            Console.WriteLine("\n--- Пошук супутника Мiсяць ---");
            Planet searchedSatellite = solarSystem.Search("Мiсяць");
            Console.WriteLine($"Знайдено: {searchedSatellite.ToString()}");

            Console.WriteLine("\n--- Максимальна маса в системi ---");
            Console.WriteLine($"Максимальна маса (серед планет та супутникiв): {solarSystem.Max_element()}");
        }
    }
}