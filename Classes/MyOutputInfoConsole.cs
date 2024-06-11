using HW_PrinciplesSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrinciplesSOLID.Classes
{
    public class MyOutputInfoConsole: IOutputInfo
    {
        public void OutputGameStarting()
        {
            Console.WriteLine("Начнем игру!");
        }
        public void OutputConditions(object min, object max)
        {
            Console.WriteLine("Угадайте число между " + min.ToString() + " и " + max.ToString());
        }
        public void OutputCongratulations()
        {
            Console.WriteLine("Поздравляем! Вы угадали число!");
        }
        public void OutputRemainingAttempts(int attempts)
        {
            Console.WriteLine("У вас осталось " + attempts + " попыток");
        }
        public void OutputGameFinished(object targetNumber)
        {
            Console.WriteLine("Игра окончена. Было загадано число " + targetNumber.ToString());
        }
        public void OutputNumberIsGreater()
        {
            Console.WriteLine("Загаданное число больше");
        }
        public void OutputNumberIsLess()
        {
            Console.WriteLine("Загаданное число меньше");
        }
    }
}
