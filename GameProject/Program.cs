using GameProject;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gm = new GamerManager(new UserValidationManager());

            gm.Add(new Gamer { Id = 1, BirthYear = 1989, FirstName = "sefa", LastName = "memis" });

        }
    }
}
