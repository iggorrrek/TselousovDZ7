using System;


namespace TumakovPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JEK jek = new JEK();

            Resident resident1 = new Resident("Иван", "123456", new Problem(1, "Нет отопления", ProblemType.Отопление), new Temperament());
            Resident resident2 = new Resident("Петр", "654321", new Problem(2, "Проблемы с оплатой", ProblemType.Оплата), new Temperament());
            Resident resident3 = new Resident("Сергей", "789012", new Problem(3, "Другие проблемы", ProblemType.Другое), new Temperament());
            Resident resident4 = new Resident("Соня", "345901", new Problem(3, "Другие проблемы", ProblemType.Другое), new Temperament());
            Resident resident5 = new Resident("Саша", "123456", new Problem(1, "Нет отопления", ProblemType.Отопление), new Temperament());
            Resident resident6 = new Resident("Игорь", "097234", new Problem(2, "Проблемы с оплатой", ProblemType.Оплата), new Temperament());
            Resident resident7 = new Resident("Никита", "645923", new Problem(2, "Проблемы с оплатой", ProblemType.Оплата), new Temperament());

            jek.AddResident(resident1);
            jek.AddResident(resident2);
            jek.AddResident(resident3);
            jek.AddResident(resident4);
            jek.AddResident(resident5);
            jek.AddResident(resident6);
            jek.AddResident(resident7);

            jek.ProcessResidents();



            Console.ReadKey();
        }
    }
}
