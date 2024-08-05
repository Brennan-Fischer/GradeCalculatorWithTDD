namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Calculator
    {

        public static char CalculateGrade(int score)
        {
            if (score < 0 || score > 100)
                throw new ArgumentOutOfRangeException(nameof(score), "score must be between 0 and 100.");
            else if (score >= 90)
                return 'A';
            else if (score >= 80)
                return 'B';
            else if (score >= 70)
                return 'C';
            else if (score >= 60)
                return 'D';
            return 'F';

        }
    }


}
