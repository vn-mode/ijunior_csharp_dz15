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

            if (password == userInputPassword)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(secretMessage);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                while (inputCounter > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Вы ввели неверный пароль. Оставшееся количество попыток: " + (inputCounter - 1)  + " Введите пароль: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    userInputPassword = Console.ReadLine();

                    if (password == userInputPassword)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(secretMessage);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    inputCounter--;

                    if(inputCounter == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы исчерпали все попытки. Прощайте.");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }
                
            }

        }
    }
}
