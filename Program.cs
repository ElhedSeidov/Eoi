namespace ConsoleAppMath
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MathHelper mathHelper = new MathHelper();
            Console.WriteLine(mathHelper.PrintValue(2,5));   
            Console.WriteLine(mathHelper.PrintValue(true));
            mathHelper.PrintValue("wer", "erw");
            Console.WriteLine(mathHelper.PrintValue(2, 5, 7));
        }   
    }
}