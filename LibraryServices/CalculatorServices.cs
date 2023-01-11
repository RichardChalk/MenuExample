namespace LibraryServices
{
    public class CalculatorServices : ICalculatorServices
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }

   
}
