namespace PZ_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NetworkSubscriber sub1 = new NetworkSubscriber("Кинзабаева Нурсиля Зульфитдинофна", TypeOfTariff.Standart);
            NetworkSubscriber sub2 = new NetworkSubscriber("Зубкова Надежда Сергеевна", TypeOfTariff.Economy);
            
            Console.WriteLine(sub1);
            sub1.MakeCall(60, TypeOfTariff.Standart);
            sub1.SendGB(5, TypeOfTariff.Standart);

            Console.WriteLine($"количество тарифа Maxi: {NetworkSubscriber.countOfMaxi}\n" +
            $"количество тарифа Standart: {NetworkSubscriber.countOfStandart}\n" +
            $"количество тарифа Economy: {NetworkSubscriber.countOfEconomy}");

        }
    }
}