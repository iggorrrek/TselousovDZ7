using System;
using System.Collections.Generic;


namespace TumakovPlus
{
    public class JEK
    {
        private Stack<Resident> residents = new Stack<Resident>();

        public void AddResident(Resident resident)
        {
            residents.Push(resident);
        }

        public void ProcessResidents()
        {
            while (residents.Count > 0)
            {
                Resident resident = residents.Pop();
                int window = DetermineWindow(resident);
                Console.WriteLine($"{resident.Name} направляется в окно {window}.");
            }
        }

        private int DetermineWindow(Resident resident)
        {
            // Определяем окно по проблеме
            if (resident.Problem.Number == 1) return 1; // Проблемы с отоплением
            if (resident.Problem.Number == 2) return 2; // Проблемы с оплатой
            return 3; // Остальные проблемы
        }

        public void HandleQueue()
        {
            // Логика обработки очереди
            // Здесь можно добавить логику для обгона и неправильного выбора окна
        }
    }

}
