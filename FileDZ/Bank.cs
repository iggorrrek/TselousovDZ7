using System;


namespace TumakovDZ
{
    public enum TypeSchet
    {
        tekushiy,
        sberegatelnuy,
        obshiy
    }
    public class BankSchet
    {
        private static int idCounter = 1;
        public int id { get; }
        public decimal balanceschet { get; set; }
        private TypeSchet typeschet { get; set; }

        public BankSchet(decimal initialbalance, TypeSchet typeSchet)
        {
            this.balanceschet = initialbalance;
            this.typeschet = typeSchet;
            id = NovuyID();
        }
        public void Snyatie(decimal value)
        {
            balanceschet -= value;
        }
        public void Popolneniy(decimal value)
        {
            balanceschet += value;
        }
        private static int NovuyID()
        {
            return idCounter++;
        }
        public TypeSchet Typeschet
        {
            get { return typeschet; }
            set { typeschet = value; }
        }
        public void PrintBankSchet3()
        {
            Console.WriteLine($"\nНомер счета: {id}");
            Console.WriteLine($"Баланс: {balanceschet}");
            Console.WriteLine($"Тип счета: {typeschet}\n");
        }
        public bool Perevod(BankSchet toAccount, decimal summa)
        {
            if (summa > balanceschet)
            {
                Console.WriteLine("Недостаточно средств.");
                return false;
            }
            Snyatie(summa);
            toAccount.Popolneniy(summa);
            return true;
        }
    }
}
