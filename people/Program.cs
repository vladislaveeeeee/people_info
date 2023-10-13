using System;
using System.Reflection;

namespace MyApp 
{
    internal class Program
    {
        class Human
        {
            public int Id { get; set; }
            public int IdentificationCode { get; set; }
            public string PassportNumber { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Gender { get; set; }
            public DateTime BirthDate { get; set; }

            public Human() { }
            
            public void InputInfo()
            {
                do
                {
                    Console.Write("Введіть ідентифікатор: ");
                    Id = int.Parse(Console.ReadLine());
                } while (Id < 100000 || Id > 999999);

                do
                {
                    Console.Write("Введіть ідентифікаційний код(9 цифр): ");
                    IdentificationCode = int.Parse(Console.ReadLine());
                } while (IdentificationCode < 100000000 || IdentificationCode > 999999999);

                do
                {
                    Console.Write("Введіть номер паспорта (13 цифр): ");
                    PassportNumber = Console.ReadLine();
                } while (PassportNumber.Length != 13 || !PassportNumber.All(char.IsDigit));

                Console.Write("Введіть ім'я: ");
                FirstName = Console.ReadLine();

                Console.Write("Введіть прізвище: ");
                LastName = Console.ReadLine();

                Console.Write("Введіть номер телефона: ");
                PhoneNumber = Console.ReadLine();

                do
                {
                    Console.Write("Введіть електронну адресу (не більше 10 символів і @gmail.com): ");
                    Email = Console.ReadLine();
                } while (Email.Length > 10 || !Email.EndsWith("@gmail.com"));

                Console.Write("Введіть стать: ");
                Gender = Console.ReadLine();

                Console.Write("Введіть дату народження (рррр-мм-дд): ");
                BirthDate = DateTime.Parse(Console.ReadLine());
            }

            public void DisplayInfo()
            {
                Console.WriteLine("\n\nІнформація про особу:");
                Console.WriteLine($"Ідентифікатор: {Id}");
                Console.WriteLine($"Ідентифікаційний код: {IdentificationCode}");
                Console.WriteLine($"Номер паспорта: {PassportNumber}");
                Console.WriteLine($"Ім'я: {FirstName}");
                Console.WriteLine($"Прізвище: {LastName}");
                Console.WriteLine($"Номер телефона: {PhoneNumber}");
                Console.WriteLine($"Електронна адреса: {Email}");
                Console.WriteLine($"Стать: {Gender}");
                Console.WriteLine($"Дата народження: {BirthDate.ToShortDateString()}");
            }


        }
        static void Main(string[] args)
        {
            Human Vlad = new Human();
            Vlad.InputInfo();
            Vlad.DisplayInfo();


        }
    }
}