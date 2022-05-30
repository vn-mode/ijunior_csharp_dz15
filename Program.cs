using System;

namespace vn_mode_csharp_dz15
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "pass123";
            string secretMessage = "Это секретное сообщение";
            int inputCounter = 3;
            string userInputPassword;

            Console.Write("Введите пароль: ");
            userInputPassword = Console.ReadLine();
            for ( ; inputCounter > 0; )
            {
                if (password == userInputPassword)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(secretMessage);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else if(inputCounter > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы ввели неверный пароль. Оставшееся количество попыток: {--inputCounter}. Введите пароль:");
                    Console.ForegroundColor = ConsoleColor.White;
                    userInputPassword = Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы исчерпали все попытки. Прощайте.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }

        }
    }
}
