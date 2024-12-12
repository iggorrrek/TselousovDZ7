using System;


namespace TumakovPlus
{
    public class Temperament
    {
        public int ScandalLevel { get; set; }
        public bool IsDumb { get; set; }

        public Temperament(int scandalLevel, bool isDumb)
        {
            ScandalLevel = scandalLevel;
            IsDumb = isDumb;
        }
        public Temperament()
        {
            Random random = new Random();
            int num = random.Next(0, 11);
            bool b = random.Next(0, 2) == 1;
            ScandalLevel = num;
            IsDumb = b;
        }
    }
}
