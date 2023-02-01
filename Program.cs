using System;
namespace test
{
    public class Program
    {
        static void Main()
        {
            var addition = new Addition();
            int additionNumber1 = 10;
            int additionNumber2 = 5;
            int resultAddition = addition.Operate(additionNumber1, additionNumber2);

            var substraction = new Substraction();
            int substractionNumber1 = 12;
            int substractionNumber2 = 4;
            int resultSubstraction = substraction.Operate(substractionNumber1, substractionNumber2);

            var multiplication = new Multiplication();
            int multiplicationNumber1 = 5;
            int multiplicationNumber2 = 3;
            int resultMultiplication = multiplication.Operate(multiplicationNumber1, multiplicationNumber2);

            var division = new Division();
            int divisionNumber1 = 20;
            int divisionNumber2 = 4;
            int resultDivision = division.Operate(divisionNumber1, divisionNumber2);

            Console.WriteLine($"Addition: first number={additionNumber1}, second number={additionNumber2}, Result={resultAddition}");
            Console.WriteLine($"Substraction: first number={substractionNumber1}, second number={substractionNumber2}, Result={resultSubstraction}");
            Console.WriteLine($"Multiplication: first number={multiplicationNumber1}, second number={multiplicationNumber2}, Result={resultMultiplication}");
            Console.WriteLine($"Division: first number={divisionNumber1}, second number={divisionNumber2}, Result={resultDivision}");
        }
    }
}