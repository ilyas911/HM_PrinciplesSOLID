using HW_PrinciplesSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrinciplesSOLID.Classes
{
    public class MyInputDataConsole: IInputData
    {
        public void InitializeSetup()
        {
            Console.WriteLine("Перед началом игры задайте свои настройки, пожалуйста!");
        }
        public void InitializeInputMin()
        {
            Console.Write("Задайте минимальное число - ");
        }
        public void InitializeInputMax()
        {
            Console.Write("Задайте максимальное число - ");
        }
        public void InitializeInputAttempts()
        {
            Console.Write("Задайте максимальное число попыток - ");
        }
        public int InputMin()
        {
            return InputChecktoNaturalNumber();
        }
        public int InputMax()
        {
            return InputChecktoNaturalNumber();
        }
        public int InputAttempts()
        {
            return InputChecktoNaturalNumber();
        }
        public static int InputChecktoNaturalNumber()
        {
            string input = Console.ReadLine();
            int number;
            bool isNumber = false;
            if (int.TryParse(input, out number))
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
    }
}
