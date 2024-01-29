using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PZ_18
{
    public enum TypeOfTariff
    {
        Maxi, // Максимальный тариф
        Standart,// Стандартный тариф
        Economy // Экономичный тариф
    }

    internal class NetworkSubscriber
    {
        // Счетчики абонентов на различных тарифах
        public static int countOfMaxi = 0;
        public static int countOfStandart = 0;
        public static int countOfEconomy = 0;

        private string fullName; // ФИО
        public string FullName
        {
            get => fullName;
            set
            {
                if (value == "") // Если введена пустая строка
                {
                    Console.WriteLine("Введена пустая строка. Введите ФИО"); 
                    fullName = Console.ReadLine();
                }
                else
                {
                    fullName = value;
                }
            }
        }

        public TypeOfTariff Tariff { get; set; } // Тариф абонента

        // Остаток минут и Гб на тарифе
        public int RemainingMinutes { get; private set; }
        public int RemainingGB { get; private set; }

        public NetworkSubscriber(string fullName, TypeOfTariff tariff)
        {
            FullName = fullName;
            Tariff = tariff;

            switch (tariff) // Установка остатка минут и Гб в зависимости от выбранного тарифа
            {
                case TypeOfTariff.Maxi:
                    RemainingMinutes = 1000;
                    RemainingGB = 50;
                    countOfMaxi++;
                    break;
                case TypeOfTariff.Standart:
                    RemainingMinutes = 500;
                    RemainingGB = 30;
                    countOfStandart++;
                    break;
                case TypeOfTariff.Economy:
                    RemainingMinutes = 300;
                    RemainingGB = 10;
                    countOfEconomy++;
                    break;
            }
        }

        public void MakeCall(int duration, int remainingMinutes) // Метод для подсчета минут
        {
            RemainingMinutes -= duration;
            Console.WriteLine($"\nАбонент: {FullName} совершила звонок продолжительностью {duration} мин, остаток минут {RemainingMinutes}");
        }

        public void SendGB(int amount, int remainingGB) // Метод для подсчета гигабайтов
        {
            RemainingGB -= amount;
            Console.WriteLine($"Абонент: {FullName} передала информацию в объеме {amount} Гб, остаток тарифа: {RemainingGB} Гб");

        }
        public override string ToString()
        {
            return $"Абонент: {FullName}, Тариф: {Tariff}";
        }

        public static void PrintSubscribersCount() // Статический метод для вывода количества абонентов на каждом тарифе
        {
            Console.WriteLine($"\nКоличество абонентов на тарифе Maxi: {countOfMaxi}\n" +
                              $"Количество абонентов на тарифе Standart: {countOfStandart}\n" +
                              $"Количество абонентов на тарифе Economy: {countOfEconomy}");
        }
    }
}