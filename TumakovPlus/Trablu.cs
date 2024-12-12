

namespace TumakovPlus
{
    public class Problem
    {
        public int Number { get; set; }
    public string Description { get; set; }
    public ProblemType Type { get; set; }

    public Problem(int number, string description, ProblemType type)
    {
        Number = number;
        Description = description;
        Type = type;
    }
    }
}
