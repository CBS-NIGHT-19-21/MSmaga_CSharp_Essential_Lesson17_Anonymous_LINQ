
using Task_Additional_Calculator;

class Program
{
    static void Main()
    {

        Console.WriteLine( Calculator.Add(13, 19) );
        Console.WriteLine( Calculator.Add("13", "19"));
        Console.WriteLine( Calculator.Sub(19.0d, 13d)); 
        Console.WriteLine( Calculator.Mul(13.0m, 19m));
        Console.WriteLine( Calculator.Mul(19.0f, 13f));

        Console.ReadLine();
    }
}
