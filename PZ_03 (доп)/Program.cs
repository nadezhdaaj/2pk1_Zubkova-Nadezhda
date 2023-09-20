namespace PZ_03__доп_
{
    internal class Program
    {
        static void Main(string[] args)
        { //использовать бесконечный цикл. Пользователь вводит название услуги ему выдается цена данной услуги. 
            // при пустом значении цикл завершается. В конце вывести общую сумму услуг
            Console.WriteLine("Введите название услуги");
            string nameServer = Console.ReadLine();
            for(; ;)
            {
                Console.WriteLine("Всё для вас, всё бесплатно");
            }
        }
    }
}