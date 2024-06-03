using HW_PrinciplesSOLID.Interfaces;
using HW_PrinciplesSOLID.Classes;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    public static void SetupFromConsole(ref int minValue, ref int maxValue, ref int maxAttemtps)
    {
        Console.Write("Задайте минимальное число - ");
        minValue = InputWithCheck();
        Console.Write("Задайте максимальное число - ");
        maxValue = InputWithCheck();
        Console.Write("Задайте максимальное число попыток - ");
        maxAttemtps = InputWithCheck();
    }

    public static int InputWithCheck()
    {
        string input = Console.ReadLine();
        int number;
        bool isNumber = false;
        if(int.TryParse(input, out number))
        {
            isNumber = true;
        }
        while (!isNumber) 
        {
            Console.Write("Неправильный ввод данный! Нужно ввести именно ЦЕЛОЕ ЧИСЛО! - ");
            input = Console.ReadLine();
            if (int.TryParse(input, out number))
                isNumber = true;
        }
        return number;
    }
    private static void Main()
    {
        int minValue = 0;
        int maxValue = 0;
        int maxAttemtps = 0;
        Console.WriteLine("Перед началом игры задайте свои настройки, пожалуйста!");
        SetupFromConsole(ref minValue, ref maxValue, ref maxAttemtps);
        Settings gameSettings = new Settings(minValue, maxValue, maxAttemtps);
        IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        IGuessNumberGame guessNumberGame = new GuessNumber_TheGame(randomNumberGenerator, gameSettings);
        guessNumberGame.StartGame();
    }
}