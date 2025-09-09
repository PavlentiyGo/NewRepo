using System.Collections.Generic;

static double NumberRequest()
{
    Console.WriteLine("Введите число для операции");
    double firstNum = Convert.ToDouble(Console.ReadLine());
    return firstNum;
}
static double[] NumbersRequest()
{
    Console.WriteLine("Введите 1 число для операции");
    double firstNum = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите 2 число для операции");
    double secondNum = Convert.ToDouble(Console.ReadLine());
    double[] arr = new double[2];
    arr[0] = firstNum;
    arr[1] = secondNum;
    return arr;
}
static double OperationSolve(string operation)
{
    double[] arr = NumbersRequest();
    double first = arr[0];
    double second = arr[1];
    switch (operation)
    {
        case "+":
            Memory.currentMemory += first + second;
            return first + second;
        case "-":
            Memory.currentMemory += first - second;
            return first - second;
        case "*":
            Memory.currentMemory += first * second;
            return first * second;
        case "/":
            if (second == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Деление на 0 невозможно, выберите другое число");
                Console.ResetColor();
                return double.MaxValue;
            }
            Memory.currentMemory += first / second;     
            return first / second;
        case "%":
            Memory.currentMemory += first % second;
            return first % second;
        default:
            return double.MaxValue;
    }
}
static double OperationResult()
{
    Console.WriteLine("Введите операцию: +, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR");
    string operation = Console.ReadLine();
    double num;
    switch (operation)
    {
        case "+":
        case "-":
        case "*":
        case "/":
        case "%":
            return OperationSolve(operation);
        case "1/x":
            num = NumberRequest();
            if (num == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Деление на 0 невозможно, выберите другое число");
                Console.ResetColor();
                return double.MaxValue;
            }
            Memory.currentMemory += 1/num;
            return 1 / num;
        case "x^2":
            num = NumberRequest();
            Memory.currentMemory += Math.Pow(num, 2);
            return Math.Pow(num, 2);
        case "sqrt":
            num = NumberRequest();
            Memory.currentMemory += Math.Pow(num, 0.5);
            return Math.Pow(num, 0.5);
        case "M+":
            Memory.memory += Memory.currentMemory;
            break;
        case "M-":
            Memory.memory -= Memory.currentMemory;
            break;
        case "MR":
            Console.WriteLine(Memory.memory);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введена неверная операция, ведите предложенную из списка");
            Console.ResetColor();
            return double.MaxValue;
    }
    return double.MaxValue;
}
bool flag = true;
while (flag)
{
    double result = OperationResult();
    if (result == double.MaxValue)
    {
        continue;
    }
    Console.WriteLine($"Результат операции {result}");
    Console.WriteLine("Для продолжения нажмите 1");
    flag = Console.ReadLine() == "1";
}

static class Memory
{
    public static double memory = 0;
    public static double currentMemory = 0;
}
