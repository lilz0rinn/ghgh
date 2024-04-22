using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()

    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        Dictionary<int, string> italianCities = new Dictionary<int, string>
        {
            {1, "Рим (Rome)"},
            {2, "Мілан (Milan)"},
            {3, "Неаполь (Naples)"},
            {4, "Венеція (Venice)"},
            {5, "Флоренція (Florence)"},
            {6, "Турін (Turin)"},
            {7, "Болонья (Bologna)"},
            {8, "Палермо (Palermo)"}
        };

        Dictionary<int, string> spainCities = new Dictionary<int, string>
        {
            {1, "Мадрид (Madrid)"},
            {2 , "Барселона (Barcelona)"},
            {3, "Валенсія (Valencia)"},
            {4, "Севілья (Seville)"},
            {5, "Сарагоса (Zaragoza)"},
            {6, "Малага (Malaga)"},
            {7, "Мурсія (Murcia)"},
            {8, "Палма-де-Мальорка (Palma de Mallorca)"}
        };
        Dictionary<int, string> ukrCities = new Dictionary<int, string>
        {
            {1, "Київ"},
            {2, "Харків"},
            {3, "Одеса"},
            {4, "Дніпро"},
            {5, "Львів"},
            {6, "Запоріжжя"},
            {7, "Кривий Ріг"},
            {8, "Миколаїв"},
        };


        Dictionary<int, List<string>> selectedCities = new Dictionary<int, List<string>>();

        
        Dictionary<int, string> selectedCountry = new Dictionary<int, string>
        {
            { 1, "Італія" },
            { 2, "Іспанія" },
            { 3, "Україна" },
            { 4, "Список обраного" },

        };
       

        

        while (true)
        {


            Console.WriteLine("ПЕРЕЛІК КРАЇН: ");
            Console.WriteLine("             1.  Італія");
            Console.WriteLine("             2.  Іспанія ");
            Console.WriteLine("             3.  Україна  ");
            Console.WriteLine("             4.  Список обраного ");
            Console.WriteLine("Введіть номер країни: ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            if (selectedCountry.ContainsKey(input))
            {
                selectedCountry[4] = selectedCountry[input];
            }
            Console.Clear();
            
          
           int country = input;
           
        if (!selectedCities.ContainsKey(country))
        {
            selectedCities[country] = new List<string>();
        }
        
            if (input == 1)
            {
                Console.WriteLine("Виберіть місто: ");
                foreach (var city in italianCities)
                {
                    Console.WriteLine($"{city.Key}. {city.Value}");
                }
                
                int cityNumber = Convert.ToInt32(Console.ReadLine());
                if (cityNumber == 0) break;

                if (italianCities.ContainsKey(cityNumber))
                {
                    selectedCities[country].Add(italianCities[cityNumber]);
                }

                Console.Clear();
            }
            else if (input == 2)
            {
                Console.WriteLine("Виберіть місто: ");
                foreach (var city in spainCities)
                {
                    Console.WriteLine($"{city.Key}. {city.Value}");
                }

                int cityNumber = Convert.ToInt32(Console.ReadLine());
                if (cityNumber == 0) break;

                if (spainCities.ContainsKey(cityNumber))
                {
                    selectedCities[country].Add(spainCities[cityNumber]);
                }
                Console.Clear();
            }
            else if (input == 3)
            {
                Console.WriteLine("Виберіть місто: ");
                foreach (var city in ukrCities)
                {
                    Console.WriteLine($"{city.Key}. {city.Value}");
                }

                int cityNumer = Convert.ToInt32(Console.ReadLine());
                if (cityNumer == 0 ) break;

                if (ukrCities.ContainsKey(cityNumer))
                {
                    selectedCities[country].Add(ukrCities[cityNumer]);
                }
                Console.Clear();
            }
            else if (input == 4)
            {
                Console.Clear();
                Console.WriteLine("Список обраного: ");
                foreach (var selection in selectedCities)
                {
                    if (selection.Value.Count > 0){
                    Console.WriteLine($"Країна: {selectedCountry[selection.Key]}, Вибрані міста: {string.Join(", ", selection.Value)}");
                    }
                }
                Console.WriteLine("\nНатисніть будь-якку кнопку щоб повернутися ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Невірний вибір, спробуйте ще раз.");
            }
        }
    }
}