using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    // Перечисление, описывающее типы тарифов
    enum TypeOfTariff { Maxi, Standart, Economy }

    // Класс, представляющий абонента сети связи
    internal class NetworkSubscriber
    {
        // Поля класса
        string _name; // ФИО абонента
        int _minute; // продолжительность разговора в минутах
        int _gb; // количество ГБ интернет-трафика

        // Минимальное количество минут для каждого тарифа
        int _minMaxi = 1000;
        int _minStandart = 500;
        int _minEconomy = 300;

        // Базовое количество ГБ для каждого тарифа
        int _gbMaxi = 50;
        int _gbStandart = 30;
        int _gbEconomy = 10;

        // Статические поля - количество абонентов для каждого тарифа
        public static int countOfMaxi = 0;
        public static int countOfStandart = 0;
        public static int countOfEconomy = 0;

        // Свойство типа тарифа
        public TypeOfTariff Type { get; set; }

        // Свойство ФИО абонента с проверкой на пустую строку
        public string Name
        {
            get => _name;
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Введена пустая строка. Введите ФИО");
                    _name = Console.ReadLine();
                }
                else
                {
                    _name = value;
                }
            }
        }

        // Переопределение метода ToString для получения информации об абоненте в виде строки
        public override string ToString()
        {
            return $"{Name}\n" +
            $"Тип тарифа: {(Type == TypeOfTariff.Maxi ? "Макси" : Type == TypeOfTariff.Standart ? "Стандарт" : "Экономный")}\n";
        }

        // Конструктор класса, принимающий ФИО и тип тарифа
        public NetworkSubscriber(string name, TypeOfTariff type)
        {
            Name = name;
            Type = type;

            if (type == TypeOfTariff.Maxi) countOfMaxi++;
            else if (type == TypeOfTariff.Standart) countOfStandart++;
            else countOfEconomy++;
        }

        // Конструктор 
        public NetworkSubscriber()
        {
            countOfMaxi++;
            countOfStandart++;
            countOfEconomy++;
        }

        // Метод для имитации звонка, уменьшающий количество доступных минут
        public void MakeCall(int duration, TypeOfTariff type)
        {
            if (type == TypeOfTariff.Maxi) duration = _minMaxi - _minute;
            else if (type == TypeOfTariff.Standart) duration = _minStandart - _minute;
            else duration = _minEconomy - _minute;
            Console.WriteLine($"Aбонент {Name} совершил звонок продолжительность {_minute} мин, остаток минут {duration}");
        }

        // Метод для им. передачи данных, уменьшающий количество доступных ГБ трафика
        public void SendGB(int remainingGB, TypeOfTariff type)
        {
            if (type == TypeOfTariff.Maxi) remainingGB = _gbMaxi - _gb;
            else if (type == TypeOfTariff.Standart) remainingGB = _gbStandart - _gb;
            else remainingGB = _gbEconomy - _gb;
            Console.WriteLine($"Aбонент {Name} отправил данные объемом {_gb} ГБ, остаток тарифа: {remainingGB} ГБ");
        }
    }