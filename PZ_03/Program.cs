namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какие праздники в этом месяце? ");
            Console.WriteLine("Введите номер месяца");
            int a=Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("1 янвря - Новый год, 2 января - Новый мяу-год у кошек, 7 января - Рождество");
                    break;
                case 2:
                    Console.WriteLine("14 февраля - День всех влюбленных, 20 февраля - Масленица, 23 февраля - День защитника Отечества ");
                    break;
                case 3:
                    Console.WriteLine("1 марта - Праздник прихода весны, 8 марта - Международный женский день");
                    break;
                case 4:
                    Console.WriteLine("1 апреля – День смеха, 12 апреля – День космонавтики");
                    break;
                case 5:
                    Console.WriteLine(" 1 мая - День весны и труда, 9 мая - День Победы");
                    break;
                case 6:
                    Console.WriteLine("12 июня - День России, 27 июня -  День молодежи");
                    break;
                case 7:
                    Console.WriteLine("2 июля - День «Я забыл», 10 июля - День котенка");
                    break;
                case 8:
                    Console.WriteLine("1 августа - День рождения ВСХВ-ВДНХ, 9 августа - День победы русского флота над шведами у мыса Гангут");
                    break;
                case 9:
                    Console.WriteLine("1 сентября - День Знаний, 3 сентября - День окончания Второй мировой войны");
                    break;
                case 10:
                    Console.WriteLine("1 октября - День пожилых людей в России, 5 октября - День учителя России, 9 октября - Иоанн Богослов");
                    break;
                case 11:
                    Console.WriteLine("4 ноября - День конфет, 23 ноября - День благодарения");
                    break;
                case 12:
                    Console.WriteLine("30 декабря - День образования СССР, 31 декабря - Канун Нового Года");
                    break;
                default:
                    Console.WriteLine("В году всего 12 месяцев. Введите число от 1 до 12 :)");
                    break;

            }

        }
    }
}