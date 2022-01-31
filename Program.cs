using System;
using RPG.src.Entities;

namespace RPG
{
    class Program 
    {
        static void Main(string[] args){

            Knight hero = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23 , "White Wizard");
            Ninja ninja = new Ninja("Wedge", 42 , "Ninja");
            BlackWizard blackWizard = new BlackWizard("Topapa", 42 , "Black Wizard");

            
            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(blackWizard.Attack(1));
            Console.WriteLine(blackWizard.Attack(7));
        }

    }

}

    