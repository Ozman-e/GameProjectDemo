using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player { Id = 1, BirthYear = 2001, FirstName = "ege", LastName = "Ozman", IdentityNumber = 12345 });
            Console.WriteLine("Hello World!");
        }
    }
}
