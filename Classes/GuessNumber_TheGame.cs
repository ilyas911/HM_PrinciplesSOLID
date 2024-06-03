using HW_PrinciplesSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrinciplesSOLID.Classes
{
    internal class GuessNumber_TheGame : IGuessNumberGame
    {
        private readonly IRandomNumberGenerator _randomNumberGenerator;
        private readonly int _min;
        private readonly int _max;
        private int _targetNumber;
        private int _attempts;

        public GuessNumber_TheGame(IRandomNumberGenerator randomNumberGenerator, int min, int max, int attempts)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _min = min;
            _max = max;
            _attempts = attempts;
        }

        public GuessNumber_TheGame(IRandomNumberGenerator randomNumberGenerator, Settings settings)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _min = settings.MinValue;
            _max = settings.MaxValue;
            _attempts = settings.MaxAttempts;
        }

        public void StartGame()
        {
            _targetNumber = _randomNumberGenerator.Generate(_min, _max);
            Console.WriteLine("Начнем игру!");
            Console.WriteLine($"Угадайте число между {_min} и {_max}");

            while (_attempts > 0)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == _targetNumber)
                {
                    Console.WriteLine("Поздравляем! Вы угадали число!");
                    return;
                }
                else if (guess < _targetNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                _attempts--;
                Console.WriteLine($"У вас осталось {_attempts} попыток");
            }

            Console.WriteLine($"Игра окончена. Было загадано число {_targetNumber}");
        }
    }
}
