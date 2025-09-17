using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

//add While loop

Console.WriteLine("There are 2 bile titans infront of you, what stratagem do you use (use arrow keys)");
Console.ReadLine();
Console.WriteLine("------------ Stratagems available ------------");
Console.WriteLine("Railgun => Down - Right - Down - Up - Left - Right");
Console.WriteLine("Commando Rocket Launcher => Down - Left - Up - Down - Right");

Console.WriteLine("Orbital Laser => Right - Down - Up - Right - Down");
Console.WriteLine("Orbital Napalm Barrage => Right - Right - Down - Left - Right");
Console.WriteLine("Orbital Railcannon Strike => Right - Up - Down - Down - Right");
Console.WriteLine("500kg Bomb => Up - Right - Down - Down - Down");

Console.WriteLine("Quasar Cannon => Down - Down - Up - Left - Right");
Console.WriteLine("Shield Generator Pack => Down - Up - Left - Right - Left - Right");
Console.WriteLine("True flag => Down - Up - Right - Right");

Console.WriteLine("Autocannon Sentry => Down - Up - Right - Up - Left - Up");
Console.WriteLine("Rocket Sentry => Down - Up - Right - Right - Left");
Console.WriteLine("Emancipator Exosuit => Left - Down - Right - Up");

Console.WriteLine("Portable Hellbomb => Down - Right - Up - Up - Up");
Console.WriteLine("Expendable Napalm => Down - Down - Left - Up - Left");
Console.WriteLine("Solo Silo => Down - Up - Right - Down - Down");
Console.WriteLine("");

int bile_titan = 6500;
int bile_titan2 = 6500;
int Helldiver = 150;

List<ConsoleKey> input = new List<ConsoleKey>();
ConsoleKey key;

while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
{
    if (key == ConsoleKey.UpArrow || key == ConsoleKey.RightArrow || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow)
    {
        input.Add(key);
        Console.WriteLine(key);
    }
}


ConsoleKey[] Railgun = { ConsoleKey.DownArrow, ConsoleKey.RightArrow, ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow };

ConsoleKey[] Commando = { ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.RightArrow };

ConsoleKey[] Orbital_laser = { ConsoleKey.RightArrow, ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.RightArrow, ConsoleKey.DownArrow };

ConsoleKey[] Orbital_Napalm_Barrage = { ConsoleKey.RightArrow, ConsoleKey.RightArrow, ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.UpArrow };

ConsoleKey[] Orbital_Railcannon_Strike = { ConsoleKey.RightArrow, ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.DownArrow, ConsoleKey.RightArrow };

ConsoleKey[] bomb_500kg = { ConsoleKey.UpArrow, ConsoleKey.RightArrow, ConsoleKey.DownArrow, ConsoleKey.DownArrow, ConsoleKey.DownArrow };

ConsoleKey[] Quasar_Cannon = { ConsoleKey.DownArrow, ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow };

ConsoleKey[] Shield_Generator_Pack = { ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow };

ConsoleKey[] True_flag = { ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.RightArrow, ConsoleKey.RightArrow, ConsoleKey.DownArrow };

ConsoleKey[] Autocannon_Sentry = { ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.RightArrow, ConsoleKey.UpArrow, ConsoleKey.LeftArrow, ConsoleKey.UpArrow };

ConsoleKey[] Rocket_Sentry = { ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.RightArrow, ConsoleKey.RightArrow, ConsoleKey.LeftArrow };

ConsoleKey[] Emancipator_Exosuit = { ConsoleKey.LeftArrow, ConsoleKey.DownArrow, ConsoleKey.RightArrow, ConsoleKey.UpArrow, ConsoleKey.LeftArrow, ConsoleKey.DownArrow, ConsoleKey.UpArrow };

ConsoleKey[] Portable_Hellbomb = { ConsoleKey.DownArrow, ConsoleKey.RightArrow, ConsoleKey.UpArrow, ConsoleKey.UpArrow, ConsoleKey.UpArrow };

ConsoleKey[] Expendable_Napalm = { ConsoleKey.DownArrow, ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.UpArrow, ConsoleKey.LeftArrow };

ConsoleKey[] Solo_Silo = { ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.RightArrow, ConsoleKey.DownArrow, ConsoleKey.DownArrow };

if (string.Join('|', input) == string.Join('|', Railgun))
{
    Console.WriteLine("You used a Railgun");
    Console.WriteLine();
    Console.WriteLine("Do you.....");
    Console.WriteLine("Fully charge for more damage but has a chanse to explode");
    Console.WriteLine("Use safe mode to charge it up (write: Safe charge)");
    string charge = Console.ReadLine().Trim().ToUpper();
    if (charge == "FULLY CHARGE")
    {
        Random rnd = new Random();
        int rando = rnd.Next(1, 5);
        if (rando == 1 || rando == 2 || rando == 3)
        {
            Console.WriteLine();
            Console.WriteLine("Full charge successful");
            Console.WriteLine("who do you attack");
            Console.WriteLine("Bile titan 1 or ....");
            Console.WriteLine("Bile titan 2");
            string attack123 = Console.ReadLine().Trim().ToUpper();

            if (attack123 == "BILE TITAN 1")
            {
                Console.WriteLine();
                Console.WriteLine("You attacked Bile titan 1");
                Console.WriteLine("Attack damage = 1500");
                bile_titan -= 1500;
            }

            else if (attack123 == "BILE TITAN 2")
            {
                Console.WriteLine("");
                Console.WriteLine("You attacked Bile titan 2");
                Console.WriteLine("Attack damage = 1500");
                bile_titan2 -= 1500;
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Try again.....");
            }
        }

        else if (rando == 4)
        {
            Console.WriteLine();
            Console.WriteLine("You charged the railgun and the kaboom");
            Console.WriteLine("insta death");
            Helldiver -= 150;
        }

    }
    else if (charge == "SAFE CHARGE")
    {
        Console.WriteLine();
        Console.WriteLine("Safe charge");
        Console.WriteLine("damage done = 600");
        Console.WriteLine("who do you attack");
        Console.WriteLine("Bile titan 1 or ....");
        Console.WriteLine("Bile titan 2");
        string safe_attack = Console.ReadLine().Trim().ToUpper();
        if (safe_attack == "BILE TITAN 1")
        {
            Console.WriteLine();
            Console.WriteLine("You attacked Bile titan 1");
            Console.WriteLine("Attack damage = 600");
            bile_titan -= 600;
        }

        else if (safe_attack == "BILE TITAN 2")
        {
            Console.WriteLine("");
            Console.WriteLine("You attacked Bile titan 2");
            Console.WriteLine("Attack damage = 600");
            bile_titan2 -= 600;
        }

        else
        {
            Console.WriteLine("");
            Console.WriteLine("Try again.....");
        }
    }
}

else if (string.Join('|', input) == string.Join('|', Commando))
{
    Console.WriteLine("You used a The Commando");
    Console.WriteLine();
    Console.WriteLine("Do you shot the....");
    Console.WriteLine("Bile titan 1 or");
    Console.WriteLine("Bile titan 2");
    string commando_biletitan = Console.ReadLine().Trim().ToUpper();
    if (commando_biletitan == "BILE TITAN 1")
    {
        Console.WriteLine("");
        Console.WriteLine("You did 5000 damage");
        bile_titan -= 5000;
    }

    else if (commando_biletitan == "BILE TITAN 2")
    {
        Console.WriteLine("");
        Console.WriteLine("You did 5000 damage");
        bile_titan2 -= 5000;
    }

    else
    {
        Console.WriteLine("");
        Console.WriteLine("Try again.....");
    }
}

else if (string.Join('|', input) == string.Join('|', Orbital_laser))
{
    Console.WriteLine("You used Orbital laser");
    Console.WriteLine();
    Console.WriteLine("Orbital laser will be up for 10 sec");
    Console.WriteLine("Orbital laser does 600 DPS");
    if (bile_titan > 0)
    {
        Console.WriteLine("you did 5000 damage to bile titan 1");
        bile_titan -= 5000;
    }

    else if (bile_titan < 0)
    {
        Console.WriteLine("You did 5000 damage to bile titan 2");
        bile_titan2 -= 5000;
    }
}

else if (string.Join('|', input) == string.Join('|', Orbital_Napalm_Barrage))
{
    Console.WriteLine("You used The Orbital Napalm Barrage");
    Console.WriteLine();
    Console.WriteLine("A Barrage of fire missiles");
    bile_titan -= 6500;
    bile_titan2 -= 6500;
}

else if (string.Join('|', input) == string.Join('|', Orbital_Railcannon_Strike))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', bomb_500kg))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', Quasar_Cannon))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', Shield_Generator_Pack))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', True_flag))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', Autocannon_Sentry))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', Rocket_Sentry))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', Emancipator_Exosuit))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', Portable_Hellbomb))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', Expendable_Napalm))
{
    Console.WriteLine("");
}

else if (string.Join('|', input) == string.Join('|', Solo_Silo))
{
    Console.WriteLine("");
}

else
{
    Console.WriteLine("");
    Console.WriteLine("Try again.....");
}
Console.ReadLine();