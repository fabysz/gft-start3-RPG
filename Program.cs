using RPG.src.Entities;

namespace RPG
{
    class program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "knight");
            Hero Wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(Wizard.Attack(1));

        }

    }

}