namespace UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------TESTS----------------");
            CalculadoraTest calculadoraTest = new CalculadoraTest();
            calculadoraTest.Calculadora_Sumar_RetornaEntero();
            calculadoraTest.Calculadora_Restar_RetornaEntero();
        }

    }
}