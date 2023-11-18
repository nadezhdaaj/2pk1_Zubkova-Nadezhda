namespace PZ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ненормированную строку: ");
           
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            int start = 0;
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == ' ' && chars[i - 1] == ' ')
                {
                    continue;
                }
                else if (i > 0 && chars[i] != ' ' || i == 0)
                {
                    start = i;
                    break;
                }
            }

            for (int i = start; i < chars.Length - 1; i++)
            {
                if (i < chars.Length - 2 && chars[i + 1] == ' ' && chars[i] == ' ')
                {
                    chars[i + 1] = '\0';
                }
            }

            string result = new string(chars, start, chars.Length - start - 1);
            Console.WriteLine("Ввывод нормированной строки: " + result.Trim());

            }
        }
    }



    
