using System;
using System.IO;
using TumakovDZ;

namespace FileDZ
{
    internal class File2
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadKey();
        }
        static void Task1()
        {
            Console.WriteLine("\nЗадание номер 1\n");

            BankSchet schet1 = new BankSchet(1000, TypeSchet.tekushiy);
            BankSchet schet2 = new BankSchet(200, TypeSchet.sberegatelnuy);
            Console.WriteLine("Перед переводом:");
            schet1.PrintBankSchet3();
            schet2.PrintBankSchet3();
            Console.WriteLine("Сколько вы хотите перевести с первого счета на второй??");
            bool a = decimal.TryParse(Console.ReadLine(), out decimal num);
            bool success = schet1.Perevod(schet2, num);
            if (success)
            {
                Console.WriteLine("Перевод выполнен успешно!");
            }
            else
            {
                Console.WriteLine("Ошибка при переводе.");
            }
            Console.WriteLine("После перевода:");
            schet1.PrintBankSchet3();
            schet2.PrintBankSchet3();
        }
        static void Task2()
        {
            Console.WriteLine("\nЗадание номер 2\n");

            Console.WriteLine("Введите хоть что:");
            string inputString = Console.ReadLine();
            string reversedString = Perevorot(inputString);
            Console.WriteLine(reversedString); 
        }
        static void Task3()
        {
            Console.WriteLine("\nЗадание номер 3\n");

            Console.Write("Введите имя файла: ");
            string FileName = Console.ReadLine();
            string papka = Directory.GetCurrentDirectory();
            string papkafile = Path.Combine(papka, FileName);
            if (!File.Exists(papkafile))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }
            try
            {
                string content = File.ReadAllText(papkafile);
                string upperCase = content.ToUpper();
                string newFileName = Path.GetFileNameWithoutExtension(FileName) + "_uppercase.txt";
                string newPapkafile = Path.Combine(papka, newFileName);
                File.WriteAllText(newPapkafile, upperCase);
                Console.WriteLine($"Файл {newFileName} сохранен.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
        static void Task4()
        {
            Console.WriteLine("\nЗадание номер 4\n");

            int number = 42;
            Check1(number);  
            DateTime date = new DateTime(2024, 12, 31);
            Check2(date);
            string stroka = "I want sleep";
            Check2(stroka);
        }
        static string Perevorot(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        public static void Check1(object obj)
        {
            if (obj is IFormattable formattableObject)
            {
                Console.WriteLine("\nОбъект реализует интерфейс IFormattable.");
                string formattedValue = formattableObject.ToString("D", null);
                Console.WriteLine($"Форматированное значение: {formattedValue}");
            }
            else
            {
                Console.WriteLine("\nОбъект не реализует интерфейс IFormattable.");
            }
        }
        public static void Check2(object obj)
        {
            var formattableAs = obj as IFormattable;
            if (formattableAs != null)
            {
                Console.WriteLine("\nОбъект реализует интерфейс IFormattable (через as).");
                Console.WriteLine($"Форматированное значение: {formattableAs}");
            }
            else
            {
                Console.WriteLine("\nОбъект не реализует интерфейс IFormattable (через as).");
            }
        }
    }
}
