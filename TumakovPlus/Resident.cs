using System;


namespace TumakovPlus
{
    public class Resident
    {
        public string Name { get; set; }
        public string PassportNumber { get; set; }
        public Problem Problem { get; set; }
        public Temperament Temperament { get; set; }

        public Resident(string name, string passportNumber, Problem problem, Temperament temperament)
        {
            Name = name;
            PassportNumber = passportNumber;
            Problem = problem;
            Temperament = temperament;
        }

        public int ChooseWindow()
        {
            // Логика выбора окна для тупых людей
            if (Temperament.IsDumb)
            {
                Random random = new Random();
                return random.Next(1, 4); // Случайный выбор окна от 1 до 3
            }

            // Логика выбора окна для умных людей
            if (Problem.Type == ProblemType.Отопление)
                return 1;
            else if (Problem.Type == ProblemType.Оплата)
                return 2;
            else
                return 3;
        }
    }
}
