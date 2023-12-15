using ClassLibrary1;

class Program
{
    static void Main()
    {

    }

    static void CallFightingGame()
    {
        Character mage = new Character("Merlin", 20, 5, 100);
        Character dragon = new Character("Kalemite", 100, 500, 2000);
        Character warrior = new Character("Aragon", 15, 60, 650);

        while (mage.Health > 0 && warrior.Health > 0)
        {
            mage.Attack(warrior);
            if (warrior.Health > 0)
            {
                warrior.Attack(mage);
            }
        }

        while (dragon.Health > 0 && warrior.Health > 0)
        {
            warrior.Attack(dragon);
            if (dragon.Health > 0)
            {
                dragon.Attack(warrior);
            }
        }
    }
}