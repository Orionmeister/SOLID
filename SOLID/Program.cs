using SOLID;

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

//Before Liskov Substitution

SumCalculatorBad calculator = new SumCalculatorBad(numbers);
Console.WriteLine($"The sum off all the numbers: {calculator.Calculate()}");
Console.WriteLine();
EvenNumbersSumCalculatorBad evenCalculator = new EvenNumbersSumCalculatorBad(numbers);
Console.WriteLine($"The sum of even numbers: {evenCalculator.Calculate()}");

//After Liskov Substitution
//This class might be an interface for dependency injection

Calculator calculator1 = new SumCalculator(numbers);
Console.WriteLine($"The sum off all the numbers: {calculator.Calculate()}");
Console.WriteLine();
Calculator evenCalculator1 = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of even numbers: {evenCalculator.Calculate()}");