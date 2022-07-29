namespace LineComparisonProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the line comparison problem");
            
            float lineResultOne = LineComparison.cordinatesOfLineOne();
            Console.WriteLine(lineResultOne);

            float lineResultTwo = LineComparison.cordinatesOfLineTwo();
            Console.WriteLine(lineResultTwo);

            if(lineResultOne == lineResultTwo)
            {
                Console.WriteLine("Both lines are Equal ");
            }
            else
            {
                Console.WriteLine("Both lines are not Equal");
            }

        }
    }
}