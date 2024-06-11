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
        public IOutputInfo Outputter;
        private readonly IRandomNumberGenerator _randomNumberGenerator;
        private readonly int _min;
        private readonly int _max;
        private int _targetNumber;
        private int _attempts;

        public GuessNumber_TheGame(IRandomNumberGenerator randomNumberGenerator, int min, int max, int attempts, IOutputInfo outputter)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _min = min;
            _max = max;
            _attempts = attempts;
            Outputter = outputter;
        }

        public GuessNumber_TheGame(IRandomNumberGenerator randomNumberGenerator, Settings settings, IOutputInfo outputter)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _min = settings.MinValue;
            _max = settings.MaxValue;
            _attempts = settings.MaxAttempts;
            Outputter = outputter;
        }

        public void StartGame()
        {
            _targetNumber = _randomNumberGenerator.Generate(_min, _max);
            Outputter.OutputGameStarting();
            Outputter.OutputConditions(_min, _max);
            while (_attempts > 0)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == _targetNumber)
                {
                    Outputter.OutputCongratulations();
                    return;
                }
                else if (guess < _targetNumber)
                {
                    Outputter.OutputNumberIsGreater();
                }
                else
                {
                    Outputter.OutputNumberIsLess();
                }
                _attempts--;
                Outputter.OutputRemainingAttempts(_attempts);
            }
            Outputter.OutputGameFinished(_targetNumber);
        }
    }
}
