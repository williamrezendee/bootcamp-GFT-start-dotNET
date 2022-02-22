using System;
using Abstraindo_Jogo_RPG_POO_CSharp.src.Entities;

namespace Abstraindo_Jogo_RPG_POO_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(10));
        }
    }
}