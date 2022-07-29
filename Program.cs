namespace LineComparisonProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the line comparison problem");
            
            float lineResultOne = LineComparison.cordinatesOfLineOne();
            float lineResultTwo = LineComparison.cordinatesOfLineTwo();
        
            if(lineResultOne == lineResultTwo)
            {
                Console.WriteLine("Both lines are Equal ");
            }
            else if (lineResultOne > lineResultTwo)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Both lines are not Equal");
            }

        }
    }
}