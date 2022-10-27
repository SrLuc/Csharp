
internal class Program
{
    private static void Main(string[] args)
    {
        //Instanciando Magias
        Spell Ice = new Spell(4);
        Ice.name = "Frozen";
        Ice.type = "Stun";

        Spell Water = new Spell(3);
        Water.name = "Rain";
        Water.type = "Boost";

        Spell Fire = new Spell(7);
        Fire.name = "Fireball";
        Fire.type = "True damage";

        Spell Lazer = new Spell(8);
        Lazer.name = "ThunderStorm";
        Lazer.type = "True damage and stun";

        Spell Earth = new Spell(8);
        Earth.name = "Golem";
        Earth.type = "Shield";

        Spell Space = new Spell(10);
        Space.name = "Black hole";
        Space.type = "Mystic";

        Spell Light = new Spell(7);
        Light.name = "Illuminate";
        Light.type = "Divine";

        Spell Psych = new Spell(6);
        Psych.name = "Confused";
        Psych.type = "Ilusion";


        //Instanciando Armas
        Weapon Sword = new Weapon(5);
        Sword.name = "Caladbolg";
        Sword.type = "Artefact of Legion";

        Weapon Axe = new Weapon(8);
        Axe.name = "Blindling Light";
        Axe.type = "Fear of Undeads";

        Weapon Spear = new Weapon(6);
        Spear.name = "Nation Spear";
        Spear.type = "Fear Spear of Nation";

        Weapon Arch = new Weapon(7);
        Arch.name = "Legion Arch";
        Arch.type = "Posion Arch";

        Weapon Gun = new Weapon(8);
        Gun.name = "Striker";
        Gun.type = "Small Shotgun";

        Weapon Staff = new Weapon(8);
        Staff.name = "Obivilion";
        Staff.type = "Undead Plage";



        //Instanciando Personagens
        Charcater Bob = new Charcater("Necromancer", 7, 7, Staff);
        Bob.name = "Bob";
        //Console.WriteLine("\n" + "The " + Bob.Group + " " + Bob.name + " is using The " + Staff.name + " The Staff of " + Staff.type);

        Charcater Alvo = new Charcater("Paladin", 8, 5, Light);
        Alvo.name = "Alvo";
        //Console.WriteLine(Alvo.name + " The " + Alvo.Group + " have power of " + Light.name + ", this power is " + Light.type);

        Charcater Alex = new Charcater("EliteShooter", 9, 4, Gun);
        Alex.name = "Alex";
        //Console.WriteLine("The " + Alex.Group + " " + Alex.name + " It is equipped with " + Gun.type + ", " + Gun.name);

        Charcater Arthur = new Charcater("IceMage", 5, 5, Ice);
        Arthur.name = "Arthur";
        //Console.WriteLine("The " + Arthur.Group + " " + Arthur.name + " Can, " + Ice.type + " your enemies with " + Ice.name + " Spell");

        Charcater Celo = new Charcater("Ilusioner", 4, 6, Psych);
        Celo.name = "Celo";
        //Console.WriteLine("The " + Celo.Group + " " + Celo.name + " can confused your enimies an battlefiel with " + Psych.type + " Spell ");


        //BATALHA ENTRE OS PERSONAGENS
        System.Console.WriteLine("THE FIGHT WILL START!!!!");
        Console.WriteLine("\n" + "The " + Bob.Group + " " + Bob.name + " is using The " + Staff.name + " The Staff of " + Staff.type);
        Console.WriteLine(Alvo.name + " The " + Alvo.Group + " have power of " + Light.name + ", this power is " + Light.type);
        for (var i = 0; i < 5; i++)
        {
            Bob.Fight(Alvo);
            Alvo.Fight(Bob);    
        }

        System.Console.WriteLine("\n\n");

        System.Console.WriteLine("THE OTHER FIGHT WILL START!!!!");
        Console.WriteLine("The " + Alex.Group + " " + Alex.name + " It is equipped with " + Gun.type + ", " + Gun.name);
        Console.WriteLine("The " + Arthur.Group + " " + Arthur.name + " Can, " + Ice.type + " your enemies with " + Ice.name + " Spell");
        for (var i = 0; i < 4; i++)
        {
            Alex.Fight(Arthur);
            Arthur.Fight(Alex);    
        }
        
    }
}