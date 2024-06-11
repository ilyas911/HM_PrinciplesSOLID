using HW_PrinciplesSOLID.Interfaces;
using HW_PrinciplesSOLID.Classes;

internal class Program
{   
    private static void Main()
    {
        IInputData inputter = new MyInputDataConsole();
        IOutputInfo outputter = new MyOutputInfoConsole();  

        inputter.InitializeSetup();
        inputter.InitializeInputMin();
        int minValue = inputter.InputMin();

        inputter.InitializeInputMax();
        int maxValue = inputter.InputMax();

        inputter.InitializeInputAttempts();
        int maxAttemtps = inputter.InputAttempts();

        Settings gameSettings = new Settings(minValue, maxValue, maxAttemtps);
        IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        IGuessNumberGame guessNumberGame = new GuessNumber_TheGame(randomNumberGenerator, gameSettings, outputter);
        guessNumberGame.StartGame();
    }
}