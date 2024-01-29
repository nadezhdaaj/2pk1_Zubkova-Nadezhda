using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class
{   enum Gender {male, female}
    internal class Human
{
    public string name; //имя человека
    public string surname; // фамилия
    public DateTime dataOfBirth; // дата рождения
    public Gender gender; // пол
    public string nationality; // гражданство

    public int GetAge()
    {
        return DateTime.Now.Year - dataOfBirth.Year;
    }

    public void  PrintInfo()
    {
        Console.WriteLine($"Человек: (surname), (name) \n" +
          $"Дата рождения:{dataOfBirth.ToShortDateString}, возраст {GetAge}" +
          $"пол {gender}" +
          $"гражданство {nationality}");
    }

    public Human (string name, string surname, DateTime db, Gender gender, string nation)
    {
        this.name = name;
        this.surname = surname;
        dataOfBirth = db;
        nationality = nation;
        age = GetAge();
           
    }

}
}
