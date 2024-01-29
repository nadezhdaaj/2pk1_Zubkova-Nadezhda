namespace PZ_18
{   // ВЫПОЛНИЛИ ЗУБКОВА НАДЕЖДА И КИНЗАБАЕВА НУРСИЛЯ - 7 вариант
    internal class Program
    {
        static void Main(string[] args)
        {
            NetworkSubscriber subscriber1 = new NetworkSubscriber("Кинзабаева Нурсиля Зульфитдиновна", TypeOfTariff.Maxi);
            NetworkSubscriber subscriber2 = new NetworkSubscriber("Зубкова Надежда Сергеевна", TypeOfTariff.Standart);

            // Вывод информации об абонентах
            Console.WriteLine(subscriber1.ToString());
            Console.WriteLine(subscriber2.ToString());

            subscriber1.MakeCall(200, subscriber1.RemainingMinutes);
            subscriber1.SendGB(5, subscriber1.RemainingGB);
            subscriber2.MakeCall(150, subscriber2.RemainingMinutes);
            subscriber2.SendGB(10, subscriber2.RemainingGB);

            NetworkSubscriber.PrintSubscribersCount(); // Вывод информации об общем количестве абонентов на каждом тарифе
        }
    }
}