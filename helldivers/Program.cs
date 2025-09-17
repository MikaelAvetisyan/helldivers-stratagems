using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

//add While loop
Console.WriteLine(@" 
  _  _     _ _    _ _               ___ _            _                          ___                
 | || |___| | |__| (_)_ _____ _ _  / __| |_ _ _ __ _| |_ __ _ __ _ ___ _ __    / __|__ _ _ __  ___ 
 | __ / -_) | / _` | \ V / -_) '_| \__ \  _| '_/ _` |  _/ _` / _` / -_) '  \  | (_ / _` | '  \/ -_)
 |_||_\___|_|_\__,_|_|\_/\___|_|   |___/\__|_| \__,_|\__\__,_\__, \___|_|_|_|  \___\__,_|_|_|_\___|
                                                             |___/                                 ");
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
    Console.WriteLine(@"                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
             &&&&&&    &&&&&&&&&    &&&&&& &&&&&&&&&&&&&&&&&&&&&&&&&&&&&                  
              &&&&&&&&&&&&&&&&&&&&&&&&&&&  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&                
                  &&&&&&       &&&&&&      &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&              
                  &&&&&&       &&&&&&      &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&              
              &&&&&&&&&&&&&&&&&&&&&&&&&&&  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&                
             :&&&&&    &&&&&&&&&    &&&&&& &&&&&&&&&&&&&&&&&&&:$&&$$$$$                   
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
          ;                     ;x+++x$XX$X&$+:                                X$         
         &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&         
         &&+++++++++++++++++++++++++++++++;;++++++;;;;;+++++++++++++++++++++++x&+         
         &&++++++++++++xxXx++++++++++;+++++++++++X&&&&&&$+++;++;++;++;++;++;+++&&         
         &$;;++;++;++;&&&&&&x++$&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&         
         &&&&$++++;+;+&     $&&&  &&                                                      
         :$;&&&&&&&&&+&    &&&                                                            
                   :&&&&X&&&&                                                             
                      &&&&&                                                               
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          ");
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
    Console.WriteLine(@"                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                   &&&                                                                    
                   &&&&                                                                   
                   &&&&&&                                                                 
                   &&&&&&&&                                                               
                   &&&&&&&&&                                                              
                                                                                          
                   &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&                   
                   &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&                 
                   &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&                
                                              +&&&&&&&&&&&&&&&&&&&&&&&&&&&                
                   &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&                
                   &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&                 
                   &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&X                   
                                                                                          
                   &&&&&&&&&                                                              
                   &&&&&&&&                                                               
                   &&&&&&                                                                 
                   &&&&                                                                   
                   &&                                                                     
                                                                                          
                                                                                          
                                                                                          
                                       &&&&&&&&&&&&&&&&&&&&&&&&&                          
            &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&;            
            &x+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++x&&            
            &x++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++X&            
            &x++;++;++;++;++;++;++;++;++;++;++;++;++;++;++;++;++;++;++;++;++X&            
            &x++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++X&            
            &&&&&&&&&&&&&&&$++++;++;++;++;++;++;++;++;++;++;++;++;++;++;++x&&&            
            &&&&&&&&&&&&&$ ;x+;+++++++++++++++++++++++++++++xx$Xx++++x&&&&&&&             
                           &&&&&&&x+;++;++;++;+&&&&&&&&&x++$&&&&&&$&&&&X                  
                            xxx+&&&&&+++++++++x&       ;x&&&&    &&                       
                                    &&x+;++;++X&       &&&       &&&                      
                                     &&++++++$&&     &&&&:       &&                       
                                      &++&&&&&&&&&&&&&&&x                                 
                                      &xx&             &                                  
                                      &&&&                                                
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          
                                                                                          ");
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
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                @@@@                                                
                                                @@@@                                                
                                                @@@@                                                
                                                @@@@                                                
                                                @@@@                                                
                                                @@@@                                                
                                                @@@@                                                
                                                @@@@                                                
                                                @@@@                                                
                                     @@         @@@@         @@                                     
                                   @@@@@@       @@@@       @@@@@@                                   
                                     @@@@@@     @@@@     @@@@@@                                     
                                       @@@@@@   @@@@   @@@@@@                                       
                                         @@  @@@@@@@@@@  @@                                         
                                           @@@@@@@@@@@@@@                                           
                                @@@@@@@@  @@@@@@@@@@@@@@@@  @@@@@@@@                                
                               @@@@@@@@@@ @@@@@@@@@@@@@@@@ @@@@@@@@@@                               
                                @@@@@@@@  @@@@@@@@@@@@@@@@  @@@@@@@@                                
                                           @@@@@@@@@@@@@@                                           
                                             @@@@@@@@@@                                             
                                @@@@    @@@@            @@@@    @@@@                                
                             @@@@@    @@@@@@@@@@    @@@@@@@@@@    @@@@@                             
                           @@@@@@    @@@@@@@@@@@    @@@@@@@@@@@    @@@@@@                           
                         @@@@@@@    @@@@@@@@@@@@    @@@@@@@@@@@@@   @@@@@@@                         
                         @@@@@      @@@@@@@@@@@@    @@@@@@@@@@@@      @@@@@                         
                                                                                                    
                     @@@@@@@@    @@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@    @@@@@@@@                     
                    @@@@@@@@@   @@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@   @@@@@@@@@                    
                   @@@@@@@@@    @@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@    @@@@@@@@@                   
                  @@@@@@@@@@    @@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@    @@@@@@@@@@                  
                  @@@@@@@@@@   @@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@   @@@@@@@@@@@                 
                 @@@@@@@@@@@   @@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@   @@@@@@@@@@@                 
                 @@@@@@@@@@   @@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@  @@@@@@@@@@@                 
                 @@@@@@@@@@    @@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@    @@@@@@@@@@                 
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
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
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                            @@@                                                     
                                            @@@@@                                                   
                                            @@@@@@@                                                 
                                            @@@@@@@@@@                                              
                                            @@@@@@@@@@@                                             
                                            @@@@@@@@@@@@                                            
                                          @@@@@@@@@@@@@@                                            
                                        @@@@@@@@@@@@@@@@@@@@                                        
                                       @@@@@@@@@@@@@@@@@@@@@                                        
                         @@@@        @@@@@@@@@@@@@@@@@@@@@@@@     @@@@                              
                         @@@@@@@     @@@@@@@@@@@ @@@@@@@@@@@@     @@@@@@                            
                         @@@@@@@@    @@@@@@@@     @@@@@@@@@@@@    @@@@@@@@                          
                        @@@@@@@@@@   @@@@@@@@       @@@@@@@@@@   @@@@@@@@@@                         
                       @@@@@@@@@@@@@  @@@@@@@@      @@@@@@@@@  @@@@@@@@@@@@@@                       
                     @@@@@@@@@@@@@@@@   @@@@@@@    @@@@@@@@   @@@@@@@@@@@@@@@@                      
                     @@@@@@@@@@@@@@@@@    @@@@@    @@@@@     @@@@@@@@@@@@@@@@@                      
                     @@@@@@   @@@@@@@@                   @@  @@@@@@@  @@@@@@@@@                     
                     @@@@@     @@@@@@@   @@@@@@@@  @@@@@@@@  @@@@@@     @@@@@@@                     
                     @@@@@@   @@@@@@   @@@@@@@@@@  @@@@@@@@@  @@@@@@   @@@@@@                       
                        @@@    @@@   @@@@@@@@@@@@  @@@@@@@@@@    @@@    @@@                         
                                   @@@@@@@@@@@@@@  @@@@@@@@@@@@@           @@                       
                                                                                                    
                    @@@@@@@@     @@@@@@@@@@@@@@      @@@@@@@@@@@@@@     @@@@@@@@                    
                  @@@@@@@@@@@  @@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@  @@@@@@@@@@@                  
                 @@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@                 
                @@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@   @@@@@@@@@@@                
               @@@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@   @@@@@@@@@@@@               
               @@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@               
              @@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@@   @@@@@@@@@@@@              
              @@@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@@   @@@@@@@@@@@@              
              @@@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@@   @@@@@@@@@@@@              
               @@@@@@@@@      @@@@@@@@@@@@@@@@@@     @@@@@@@@@@@@@@@@@      @@@@@@@@@               
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
    Console.WriteLine("You used The Orbital Napalm Barrage");
    Console.WriteLine();
    Console.WriteLine("A Barrage of fire missiles");
    Console.WriteLine("Kills both");
    bile_titan -= 6500;
    bile_titan2 -= 6500;
}

else if (string.Join('|', input) == string.Join('|', Orbital_Railcannon_Strike))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                             &&      &&                                             
                                            &&&&&  &&&&&                                            
                                             &&&&&&&&&&&                                            
                                              &&&&&&&&                                              
                                              &&&&&&&&                                              
                                            &&&&&&&&&&&&                                            
                                            &&&&&  &&&&&                                            
                                            &&&&&  &&&&&                                            
                                             &&&&&&&&&&&                                            
                                              &&&&&&&&                                              
                                              &&&&&&&&                                              
                                            &&&&&&&&&&&&                                            
                                            &&&&&  &&&&&                                            
                                                                                                    
                                            &&&&&&&&&&&&                                            
                                            &&&&&&&&&&&&&                                           
                                            &&&&&&&&&&&&&                                           
                                            &&&&&&&&&&&&&                                           
                                   &&       &&&&&&&&&&&&&      &&                                   
                                &&&&   &&&  &&&&&&&&&&&&&  &&   &&&&                                
                             &&&&&&   &&&&   &&&&&&&&&&&  &&&&    &&&&&                             
                           &&&&&&   &&&&&&&&  &&&&&&&&  &&&&&&&&   &&&&&&                           
                         &&&&&&&   &&&&&&&&&& &&&&&&&&  &&&&&&&&&   &&&&&&&                         
                                              &&&&&&&&                                              
                       &&&&&&&    &&&&&&&&&&& &&&&&&&&  &&&&&&&&&&    &&&&&&&&                      
                     &&&&&&&&&   &&&&&&&&&&&&  &&&&&&  &&&&&&&&&&&&   &&&&&&&&&                     
                    &&&&&&&&&    &&&&&&&&&&&&&  &&&&  &&&&&&&&&&&&&    &&&&&&&&&                    
                   &&&&&&&&&&   &&&&&&&&&&&&&&&      &&&&&&&&&&&&&&&   &&&&&&&&&&                   
                   &&&&&&&&&&   &&&&&&&&&&&&&&&&    &&&&&&&&&&&&&&&&   &&&&&&&&&&                   
                   &&&&&&&&&&  &&&&&&&&&&&&&&&&&    &&&&&&&&&&&&&&&&&  &&&&&&&&&&                   
                  &&&&&&&&&&&  &&&&&&&&&&&&&&&&&&   &&&&&&&&&&&&&&&&&  &&&&&&&&&&&                  
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
    Console.WriteLine("You used The Orbital Railcannon Striker");
    Console.WriteLine("");
    Console.WriteLine("A big Railcannon on your ship (does 7500 damage)");
    Console.WriteLine("The Railcannon auto aims");
    string railcannon_chose = Console.ReadLine();
    if (bile_titan > 0)
    {
        Console.WriteLine("");
        Console.WriteLine("You struck Bile titan 1");
        Console.WriteLine("Bile titan 1 dead");
        bile_titan -= 7500;
    }
    else if (bile_titan < 0)
    {
        Console.WriteLine("");
        Console.WriteLine("You struck Bile titan 2");
        Console.WriteLine("Bile titan 2 dead");
        bile_titan2 -= 7500;
    }
}

else if (string.Join('|', input) == string.Join('|', bomb_500kg))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                      ;;                    ;;;:                                    
                                      ;;;;                  ;;;;;;;                                 
                                   .;;;;;;;;               .;;;;;;;;;;.                             
                                     .;;;;;;              ;;;;;:;;;;;;;;.                           
                                        ;;;;              ;;;;;;;;;;;;;;                            
                                  ;$&&    :;            :;;;:;:;;;;;;;;;                            
                                  ;$&&&:                ;;;;:;:;;;;;:;;;                            
                                  &&&&&&&X             .;;:;;;;;;;;;:;;;                            
                                  &&&&&&&&X:          :;;;;;;;;;;;;;:;;;                            
                                 +&&&&&&&&&x          ;;;;;;;;;;;;;;:;;;                            
                              .x&&&&&&&&&&.         :;;;;;;;;;;;;;;;:;;;                            
                        $&&&&&&&&&&&&&&&&&          :;;;;;;::;;;;;;;:;;;                            
                   .   +&&&&&&&&&&&&&&&&&$            ;;;;:::;;;;;;;:;;;                            
             .;;;;;;;;    &&&&&$&&&&&&&&&&&&&&&&&&&&    ;;;;;;;;;;;;:;;;                            
               .;;;;;;;;    &&&&&&&&&&&&&&&&&&&&&&&&&&    ;;;;:;:;;;;;;;                            
                  ;;;;;;;:    +X.     x&&&&&&&&&&&&&&&&x    ;;;;:;:;;;;;                            
                                      .x&&&&&&&&&&&&&&&&&+    ;;;;::;;;;                            
                                      x&&&&&&&&&&&&&&&&&&&$    .;;;;;;;;                            
                                      &&&&&&&&&&&&&&&&&&&&&&X.   :;;;;;;                            
                                     :&&&&&&&&&&&&&&&&&&&&&&&&:   ;;:;;;                            
                                      ;&&&&&&&&&&&&&&&&&&&&&&&x.  ;;;;;;                            
                                :;;;.   .&&&&&&&&&&&&&&&&&&&&&.   ;;;;;;                            
                            ;;;;;;;;;;    x&&&&&&&&&&&&&&&&&&&.   ;;;;;;                            
                       .;;;;;;;;;;;;;;;;    $&&&&&&&&&&&&&&&&&.   ;;;;;;                            
                   ;;;;;;;;:;;;;;;;:;:;;;;    &&&&&&&&&&&&&&&&.   ;;;;;;                            
              ;;;;;;;;;:;;:;;;:;;;;:::;;;;;;    &&&&&&&&&&&&&&&+  ;;;;;;                            
              ;;;;;;;;;::::;;;;;;;;;;;;:;:;;;:     .        :.    ;;:;;;                            
                ;;;:;;;;;;;;;;;;;;;;;;;:;;;:;;;:                  ;;;;;;.                           
                .;;;;;:;;;;;;;;;;;;;;;;;;:;:;:;;;:::::::::::::::;;;;;;;;;;.                         
                  ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                        
                  :;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;:;:;;;:                      
                    ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;::;;:;;;;;;                    
                                                                 .;;;;:;:;;;;;;;;;                  
                                                                   ;;;;;:;;;;;;;;;;.                
                                                                     :;;;;;;;;;;;:;;                
                                                                      .;;;;;;;;;;;;;                
                                                                         ;;;;;;;::;;:.              
                                                                          .;;;;;;;;;;.              
                                                                                ::;;;;              
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
    Console.WriteLine("You used 500 kg bomb");
    Console.WriteLine("");
    Console.WriteLine("Very big bomb and with a precise strike you can kill anybody");
    Console.WriteLine("You threw randomy and hoped for the best");

    Random hello = new Random();
    int hello1 = hello.Next(1, 6);

    if (hello1 == 1)
    {
        Console.WriteLine("");
        Console.WriteLine("You hit bile titan 1 directly on him, you killed emm");
        bile_titan -= 10000;
    }
    else if (hello1 == 2)
    {
        Console.WriteLine("");
        Console.WriteLine("You hit bile titan 2 directly on him, You killed emm");
        bile_titan2 -= 10000;
    }
    else if (hello1 == 3)
    {
        Console.WriteLine("");
        Console.WriteLine("You hit bile titan 1 right beside it, didnt kill him but you did a lot of damage");
        bile_titan -= 3750;
    }
    else if (hello1 == 4)
    {
        Console.WriteLine("");
        Console.WriteLine("You hit bile titan 2 right beside it, didnt kill him but you did a lot of damage");
        bile_titan2 -= 3750;
    }
    else if (hello1 == 5)
    {
        Console.WriteLine("");
        Console.WriteLine("Didnt hit any of them, unlucky");
    }

}

else if (string.Join('|', input) == string.Join('|', Quasar_Cannon))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                            :;&&                                    
                                                            &&&&                                    
                                                  ..x;      x&&&        xX                          
                                                 :&&&&&;    +&&&      &&&&X                         
                                                    &&&&&x         ;&&&&X                           
                                                      X$     xx;     .;.                            
                                                          &&&&&&&&&:                                
                                                        +&&&&&&&&&&&;                               
                     x&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&$ .&&&&&&x                     
                      &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&$&&&&&&&&&&&&&$;  &&&&&&                      
                                                         ;&&&&&&&&&&                                
                                                          +&&&&&&&.                                 
                                                     ;&&            x&&$                            
                                                   x&&&&&;         .&&&&&&                          
                                                 :&&&&x     $&&&.     &&&&x                         
                                                            x&&&                                    
                                                            &&&&:                                   
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
               .xx:.  .. .  ..      .:xx                                                            
              :+XXXXXXXXXXXXXXXXXXXXXXXX.                                                           
               .XXxxXXXxxxxxxXXXXXXXxxXx                                                            
                xx;;;;;;;;;;;;;;;;;;;;x+                                                            
               .+x++++++++++++++++++++x+:...           :;;.                                         
         .XXXXXXx++++++++++++++++++++++xXXXXXXXx+;+xXXXXXXXXXXx+x+;;::::;;:. ....     ..            
          xX;;;;++++++++++++++++++++++++;;;;+xXXXXXXXx;;;;;+xXXXXXXXXXXXXXXXXXXXXXXXXXXXXX          
          xX++++++++++++++++++++++++++++++++++;;;;;;;+++++++;;;;;;;;;;;;;;::::::::;;;;;;xx          
          xX;;;;;;;;;;;;;;;;+++++++++++++++;;;;++++++++++++++++++;;;;;;++xXXXXXXXXXXXXXXXX          
          XXXXXXXXXXXXXXXXXx+;;;+++++;;;;;xXXXXXx;+++;;;;;;+xxxxXXXXXXXXXX+......      .::          
          ;+;;;;++;;;::;;xXXXXXxx+;++xXXXXXX+;+xXXx++xXXXXXXxxXXXXx+xx;:;.                          
                            :+Xxxx++xXxxXx;.    ;+xxxx++xxx+..Xx                                    
                               .XXxxx+            xXXX        Xx                                    
                                :+XX:            .XXX;       .XX                                    
                                 :XX;.         .XXX;        .;xx                                    
                                .+XXx:       .XXXX;                                                 
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
    Console.WriteLine("You used Quasar Cannon");
    Console.WriteLine("");
    Console.WriteLine("A laser cannon, needs to be charged up to deal damage");
    Console.WriteLine("Does 2150 damage");
    Console.WriteLine("Who do you shot");
    string Quasar_shot = Console.ReadLine().Trim().ToUpper();
    if (Quasar_shot == "BILE TITAN 1")
    {
        Console.WriteLine("Did 2150 damage to Bile titan 1");
        bile_titan -= 2150;
    }
    else if (Quasar_shot == "BILE TITAN 2")
    {
        Console.WriteLine("Did 2150 damage to Bile titan 2");
        bile_titan2 -= 2150;
    }
}

else if (string.Join('|', input) == string.Join('|', Shield_Generator_Pack))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                            :;.:..................................;;                
                                            XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX;.              
                                            +x:;::::::::::::::::::::::::::::::::::xx                
                                            XXxx+;++++++++++++++++++++++++++++;;+xXX;               
                                            .;XXx++;;++++++++++++++++++++++;;++xXX+.                
                                               ;XXx+;;;;;;;;;;;;;;;;;;;;;;;;+xXXx.                  
                                                .xXXxxxxxxxxxxxxxxxxxxxxxxxXXXx:                    
                                            xx    ;XXXXXXXXXXXXXXXXXXXXXXXXXX+    +x:.              
                                            XXx:           .        .            +XX.               
                                            xXXX+                              +XXXx                
                                            xx+xXXXXXXXXXX  :+XXXX+:  xXXXXXXXXXx+xx                
                                            XXXXxxXXXXXXXX  :+XXXXx:  xXXXXXXxx;;;Xx                
                              .              :xXXXXXx;;;xx  +XXXXXX+  ;+++;:;;;+++Xx                
                    .&&&&&&&&&&&&&&&&&&$            ;x++Xx            ;+xx+++;;+;;Xx                
            x&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&    xX;+x;             :+x;;;+++;+xx                
            &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&;   xX;+xxxXXXXXXXXXXxxx+++;;++;;+xx                
            &&&&&&&&&&&&&&&&&&&&. &&&&&&&&&&&&&&    xX;;+xxXXXXXXXXXXxx+;++++++;;+xx                
            $&&&&&&&&&&&&&&&&&    &&&&&&&&&&&&&&    xX;;;+++++++++++++++++;;+;+;;+xx                
            $&&&&&&&&&&&&&&&&$  x&&&&&&&&&&&&&&&    xX;;;+;;+;;+;;+;;+;;+;+;;++;;+xx                
            $&&&&&&&&&&&&&&&.   &&&&&&&&&&&&&&&&    xX;;;++;;+;;+;;+;;+;;+;+;;+;;+xx                
            $&&&&&&&&&&&&&&;   .&&&&&&&&&&&&&&&&    xX;;;+;+;;+;;+;;+;;+;;+;+;+;;+xx                
            $&&&&&&&&&&&&&    ;$&&&&&&&&&&&&&&&&    xX;;;+;;+;;+;;+;;+;;+;;+;;+;;+xx                
            $&&&&&&&&&&&;    .&&&&&&&&&&&&&&&&&&    xX;;;++;;+;;+;;+;;+;;+;;+;+;;+xx                
            $&&&&&&&&&;                $&&&&&&&&    xX;;;+;+;;+;;+;;+;;+;;+;;++;;+xx                
            $&&&&&&&&$     .;;      $&&&&&&&&&&&    xX;;;+;;+;;+;;+;;+;;+;;+;;+;;+xx                
            $&&&&&&&&&&&&&&&&&;    .&&&&&&&&&&&&    xX;;;++;;+;;+;;+;;+;;+;;+;+++;xx                
            $&&&&&&&&&&&&&&&&&    &&&&&&&&&&&&&&    xX;;;+;+;;+;;+;;+;;+;;+;+++;;;Xx.               
            $&&&&&&&&&&&&&&&&X  :$&&&&&&&&&&&&&&    XX;++++++++++++++++++++++;;;+xXX.               
            $&&&&&&&&&&&&&&&.   &&&&&&&&&&&&&&&&    xX;;;;;;;;;;;;;;;;;;;;;;;;+xXXx;                
            &&&&&&&&&&&&&&&&  :$&&&&&&&&&&&&&&&&:   XXxxxxxxxxxxxxxxxxxxxxxxxxXXX;                  
            &&&&&&&&&&&&&&$;  &&&&&&&&&&&&&&&&&&;  .XXXXXXXXXXXXXXXXXXXXXXXXXXX+                    
              X&&&&&&&&&&&+X&&&&&&&&&&&&&&&&&&+     ;;:::;;;;;;;;;;;;;;;;:::;.                      
                 x&&&&&&&&&&&&&&&&&&&&&&&&&$                                                        
                    .&&&&&&&&&&&&&&&&&&&                                                            
                        &&&&&&&&&&&&&                                                               
                           $&&&&&$                                                                  
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
    Console.WriteLine("You used Shield Generator Pack");
    Console.WriteLine("");
    Console.WriteLine("Shield Generator gives you extra chanse on life");
    Console.WriteLine("Shield gives an additional 200 hp to your main hp amount");
    Helldiver += 200;
}

else if (string.Join('|', input) == string.Join('|', True_flag))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                    ::$;                    ;$::                                    
                                      &&x                  x&&                                      
                                      &&&&                &&&&                                      
                                        &&&&.          .&&&&                                        
                                        &&&&&&+       &&&&&&                                        
                                          &&&&&&    &&&&&&                                          
                                          ;&&&    &&&&&&&;                                          
                                                x&&&&&&;                                            
                                               &&&&&&x                                              
                                            .$&&&&&$                                                
                                          +&&&&&&&    &&&$                                          
                                    x;   ;&&&&&&    &&&&&&:   ;x                                    
                                .&&&&&&x   :&&.     ;&&&x   x&&&&&&.                                
                                 +&&&&&&$                  $&&&&&&+                                 
                                    ;&&&&&&:             &&&&&&;                                    
                                  &&&&&&&&&&&&:      :&&&&&&&&&&&&                                  
                               :&&&&&&x+&&&&&;        ;&&&&&;x&&&&&&;                               
                             :&&&&&&&;   .xx            xx.   ;&&&&&&&:                             
                              .x&&&$                            $&&&x.                              
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                   ..               
         ;XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx.         
                                                                ;x;;;+;;;;+;;;x;                    
                                                              ;xXXxxxXXxXxXxxxXX.                   
                                                              :+xx+;++++++++;+XX.                   
                                                              :+xx++x++++++x++XX.                   
                                                              :+xX+++xxxxxx+++XX.                   
                                                              :+xX+++x++++x+;+XX.                   
                                                              :+xX+++x++++x+++XX.                   
                                                              :+xX+++x++++x+;+XX.                   
                                                              :+xX+++x++++x+++XX.                   
                                                              :+xX+++x++++x+;+XX.                   
                                                              :+xX+++x++++x+++XX.                   
                                                              :+xX+++x++++x+;+XX.                   
                                                              :+xX+++x++++x+++XX.                   
                                                              :+xX++xxxxxxxx+xXX.                   
                                                              :;xx;;;;;;;;;;;;xx.                   
                                                              xXXXXXXXXXXXXXXXXXx:                  
                                                              ;xXXxxxxxxxxxxxxXX:.                  
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
    Console.WriteLine("You got the True Flag, a symbol of hope");
    Console.WriteLine("You put the flag down and Salut");
}

else if (string.Join('|', input) == string.Join('|', Autocannon_Sentry))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                            ...............             :;x+;...........................            
                            xxxxxxxxxxxxxxxxxxxxxx;.      .xxXxxxxxxxxxxxxxxxxxxxxxxxxx+            
                            +x++;++;;;........::;;xxxxx+.     .;++..................::..            
                            +xxx++++xxxxx+;:::::::..::;+xx+.    .+x+:.:::::::::::::.;;:.            
                                         ;++::::::::::::;;+x+.    ;++;;:::::::::::::;;;:            
            ;+xx+;+++++X&&&;    .+;::     :;;;:::::::::.::;;++;.    +xxxxxxxxxxxxxxxxxx;            
            &&&&&&&&&&&&&&.   &&&&&&&&&&    ;;:::::::::::::::;x+.                                   
            &&&&&&&&&&&&;   ;&&&&&&&&&&&:   ;;::::::::::::::::;;+;                                  
            $&&&&&&&&&.    &&&&&&&&&&&&&+   :;::::::::::::::::.:++;.                                
            &&&&&&&&+   +&&&&&&&&&&&&&&&    :;::::::::::::::::::::+;                                
            &&&&&&&;  ;&&&&&&&&&&&&&&&$.   :;;::::::::::::::::::.:++..                              
                                         :xx;:::::::::::::::::::::;;;:                              
            :;++;:;;;;::&&&&     +;.      +x;;::::::::::::::::::::::++                              
            &&&&&&&&&&&&&&    &&&&&&&&&&    :;::::::::::::::::::::::;;                              
            $&&&&&&&&&&&    &&&&&&&&&&&&;   ;;::::::::::::::::::::.:;;..                            
            $&&&&&&&&&    &&&&&&&&&&&&&&;   :;::::::::::::::::::::::;;::                            
            &&&&&&&&.   &&&&&&&&&&&&&&&&    ;;::::::::::::::::::::::::;;                            
            ;;;;;.     :&&xxxXXx;:::;.    :;;;::::::::::::::::::::::::+;                            
                                         .xx;:::::::::::::::::::::::::+;                            
            ..    .;;;.:$$.               ;+x+;;;;;;;;;;;;;;;;;;;;;;++x+                            
            &&&&&&&&&&&&&&;   &&&&&&&&&&    +x++++++++++++++++++++++++x+                            
            $&&&&&&&&&&&    &&&&&&&&&&&&;                                                           
            X&&&$$&&&&    &&&&&$$$$$&&&&+.                                                          
            &&&&&&&&    &&&&&&&&&&&&&&&&    xxxxxxxxxxxxxxxxxxxxxx                                  
            ;;+xx.    &&&&+;;;;;;;;;.     :x+;::::::::::::::::;;;:                                  
                                        .;+;::::::::::::::::::;;:.                                  
                                  .:;+;;;;:...................::..                                  
                                  +xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx;                                  
                                  .;;;::;;;;;;;;;;;;;;;;;;;;;;;;;.                                  
                                                                                                    
                                                                                                    
                          .;xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx;.                          
                          +x;;::::::::::::::::::::::::::::::::::::::::;;x+                          
                        +x;::::::::::::::::::::::::::::::::::::::::::::.:;x+                        
                      :+;:................................................:;+:                      
                   .xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.                   
                  ..;;........................................................;;:.                  
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
    Console.WriteLine("You used a Auto-Cannon Sentry");
    Console.WriteLine("");
    Console.WriteLine("Auto cannon is a very strong sentry that can kill anybody");
    Console.WriteLine("You did 100% damage on one of the bile titan and put the other one on half hp");
    Console.WriteLine("Do you attack....");
    Console.WriteLine("Bile titan 1 or");
    Console.WriteLine("Bile titan 2");
    string autoattack = Console.ReadLine().Trim().ToUpper();
    if (autoattack == "BILE TITAN 1")
    {
        bile_titan -= 6500;
        bile_titan2 -= 3750;
    }
    else if (autoattack == "BILE TITAN 2")
    {
        bile_titan2 -= 6500;
        bile_titan -= 3750;
    }
}

else if (string.Join('|', input) == string.Join('|', Rocket_Sentry))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                            ...............             :;xx;...........................            
                            xxxxxxxxxxxxxxxxxxxxxx;.      .xxXxxxxxxxxxxxxxxxxxxxxxxxxx+            
                            :;..................:;+xxxxx.     .;++..................::..            
                            ;+::::::::;xxxxxxxxxxxxx+;;+xx+.    .+x+:.:::::::::::::.;;:.            
                            ;;::::::+x;;.............:;;:;+x+.    ;++;;:::::::::::::;;;:            
                            ;+::.:+++.                ;;:::;++;.    +xxxxxxxxxxxxxxxxxx;            
                            ;;::;+;:    ;$X$XX$$&$    ;;.::::;x+.                                   
                            ;+;++;    .$&&&&&&&&&&   .;;.:::::;;+;                                  
                            ;x+;     x&&&&&&&&&&&&   .;;.:::::.:++;.                                
                            xx.    +&&&&&&&&&&&&&&   .;;.:::::::::+;                                
                            .     &&&&&&&&&&&&&&&&   .;;.:::::::.:++..                              
                                &&&&&&&&&&&&&&&&&&    ;;.:::::::::;;;:                              
                       +;;;;;$&&&&&&&&&&&&&&&&&&;    .;;::::::::::::++                              
                    &&&&&&&&&&&&&&&&&&&&&&&&&&     .xx;:.:::::::::::;;                              
                  &&&&&&&&&&&&&&&&&&&&&&&&&&x     +x;:::::::::::::.:;;..                            
                &&&&&&&&&&&&&&&&&&&&&&&&&&x     ;+;;::::::::::::::::;;::                            
              x&&&&&&&&&&&&&&&&&&&&&&&&&$.    ;+;;::::::::::::::::::::;;                            
           x&&&&&&&&&&&&&&&&&&&&&&&&&&&;    :;+;::::::::::::::::::::::+;                            
           ;&&&x.     .;;;.;&&&&&&&&&&:   ;++;::::::::::::::::::::::::+;                            
                            &&&&&&&&&&+:  xx++;;;;;;;;;;;;;;;;;;;;;;++x+                            
                .X&&&&:     &&&&&&&&&&x;  +x++++++++++++++++++++++++++x+                            
              ;&&&&&&x      &&&&&&&&&&&X                                                            
           .&&&&&&$    X&&  &&&&&&&&&&;                                                             
                     :&&&&  &&&&&&&&     +xxxxxxxxxxxxxxxxxxxxxxxx                                  
                    &&&&$.  &&&&&&     ;xx;;::::::::::::::::::;;;:                                  
                    &&&&    &&&&:    .++;:::::::::::::::::::::;;:.                                  
                    +.     .&&;    .++;:......................::..                                  
                            $x    ;xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx;                                  
                                  :;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;.                                  
                                                                                                    
                                                                                                    
                          .;xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx;.                          
                          +x;;::::::::::::::::::::::::::::::::::::::::;;x+                          
                        +x;::::::::::::::::::::::::::::::::::::::::::::.:;x+                        
                      :+;:................................................:;+:                      
                   .xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.                   
                  ..;;........................................................;;:.                  
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
}

else if (string.Join('|', input) == string.Join('|', Emancipator_Exosuit))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
          $&xXxxxX&&&$  :XxX$x                                      +X$$xxxX$&&&   .x$$x;.          
         .&&&&&&&&&&X x&&&&&&&&&.                                   &&&&&&&&&&&$ ;&&&&&&&&x         
          &&$&&&&&    &&&&$$$&&&&x.                                 X&&&$&&&.   &&&&$$X$&&&&:       
         .&&&&&&  X&&&&&&&&&&&&&                                    &&&&&&&; &&&&&&&&&&&&&.         
                                                                                                    
          &&&&&&&&&&&$  .$&&&X                                      $&&&&&&&&&&&    &&&&;           
          &&&&&&&&&&   x&&&&&&&&.                                   &&&&&&&&&&X   &&&&&&&&+         
          &&&&&&&&   :&&&&&&&&&&x                                   &&&&&&&&x   &&&&&&&&&&&$        
          &&&&&&&x.x&&&&&&&&&&&&.                                   &&&&&&&& .&&&&&&&&&&&&x.        
          &&&&&+  &&&&&&&&&&&&;                                     $&&&&$  ;&&&&&&&&&&&$;          
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                             ;XXXXXXXX;                                             
                                           .XXXXxXXxXXXX:                                           
                                  .+XXXXXXXXXXXXXXXXXXXXXXXXXXXX+.                                  
                                 :XXXXXXXXxxxx;;xxxx;;+xxxXXXXXXXX:                                 
                                :+XX+;++;+x+;.        .;+x+;++;+XX+:                                
                                .:xX;;+;;+xx;.        .;xx+;;+;;Xx:.                                
                                ..xX;;+;;+xx;.        .;xx+;;+;;Xx..                                
                                .:xX;;++;+x+;.        .;+x+;++;;Xx:.                                
                                .;XXxxXxxxxxxxxxXXXXxxxxxxxxxXxxXX;.                                
                                +XXXXXXXXXXxxxXXXXXXXXxxxXXXXXXXXXX+                                
                                          :xxXXXXXXXXXXxx:                                          
                                  ....    xX;          :Xx    ....                                  
                                ;xXXXXx;  xXXXxxXXXXxxXXXx  ;xXXXXx;                                
                                .:xXXx:.  XXx:  .;;.  :xXX  .:xXXx:.                                
                                ..xxxx:.  XXX;  .::.  ;XXX  .:xxxx..                                
                                .:xxxx..  .;XXXxxxxxxXXX;.  ..xxxx:.                                
                                .:xxxx.     .xXXXXXXXXx.     .xxxx:.                                
                                .;XXx+;.      .;+xx+;.      .;+xXX;.                                
                                .;XXxxXX+:                :+XXxxXX;.                                
                                  :xXXxxXXx:            :xXXxxXXx:                                  
                                    .+xx+xXX            xXxxxx+.                                    
                                      ;x+;xx            :;+xx;                                      
                                      +x+;x;             ;;xx+                                      
                                    xXxx+xXXx.        .xXXxxxxXx                                    
                                .+XXXXXXXXXXXXXX.  .XXXXXXXXXXXXXX+.                                
                                  ..         ...    ...         ..                                  
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
}

else if (string.Join('|', input) == string.Join('|', Portable_Hellbomb))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                            ..                                    ..                
                                           ;XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX;               
                                            xx;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;Xx                
                                           :XXxx++++++++++++++++++++++++++++++++xXXX.               
                                            ;xXXx++++xxxxxxxxxxxxxxxxxxxxxx+++xXXX+.                
                                              :XXXx+;;;;;;;;;;;;;;;;;;;;;;;;+xXXx                   
                                                ;XXXXXXXXXXXXXXXXXXXXXXXXXXXXXx.                    
                                           .x;    xXXXXXXXXXXXXXXXXXXXXXXXXXX+    xX.               
                                           .XXx.                                .xXX.               
                                            XXXXx                              +XXXX                
                                ::          XXxxXXXXXXXXXX  ;xXXXX;.  XXXXXXXXXXx+XX                
                             X&&&&&&.      ;XXXx+xXXXXXXXx  ;xXXXX+:  XXXXXXXXx+++XX                
                         X&&&&&&&&&&&&&&.     XXXx;;;;xx+;  XXXXXXX+  xx+x;;;;++++XX                
                       ;&&&&&&&&&&&&&&&&&&      xXxx++xxx;            +xxx++++++++XX                
                    &&&&&&&&&&&&&&&&&&&&&&&&&+  :+xx++xx;             .xxx+++x++++XX                
                   ;&&&&&&&&&&&&&&&&&&&&&&&&&&    xX+;xxxXxXXXXXXXXXXxXxx+++++++++XX                
                   .&&&&&&&&&&&&&&&&&&&&&&&&&&    xX++++xxXXXXXXXXXXXXxx++++++++++XX                
                    ;$&&&&&&&&&&&&&&&&&&&&&&;   .xxx+++x+xxxxxxxxxxxxxx+++++++++++XX                
                             ;&&&&&&           ;XXx+++++++++++++++++++++++++++++++XX                
                              x&&&$.         .XXXXXx++++++++++++++++++++++++++++++XX                
                              ;$&&;             :+XXxx++++++++++++++++++++++++++++XX                
                      X&&&&&&&&&&&&&&&&&&&&;      .+XX++++++++++++++++++++++++++++XX                
                :&&&&&&$.       &&       ;&&&&&&;   ;X++++++++++++++++++++++++++++XX                
                :&&&&&&&&$+     &&    .x&&&&&&&&;   +X++++++++++++++++++++++++++++XX                
                       x&&&&&&&&&&&&&&&&&&;       :xXX++++++++++++++++++++++++++++XX                
                                &&             ;XXXXx+++++++++++++++++++++++++++++XX                
                                &&           .XXXXXXx+++++++++++++++++++++++++x+++XX                
                                &&           :XX;..:xX+++x+x+x+x+x+x+x+x+x+x++++xxXX.               
                      ;x&&     .&&      &&.   ;:    xX;;+;;;;;;;;;;;;;;;;;;;;+xxXXx;                
                      .x&&x    :&&    .&&&.        :XXxxxxxxxxxxxxxxxxxxxxXXXXXXX;                  
                       .&&&&  :x&&.  .&&&&         .XXXXXXXXXXXXXXXXXXXXXXXXXXX+                    
                .X&&    &&&&&&&&&&&&&&&&&&    &&;   :+;;;;;;;;;;;;;;;;;;;;;;+:                      
                  &&&;  &&&&&&&&&&&&&&&&&&  x&&&                                                    
           ;&&&&xX&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&xx&&&&:                                             
            x&&&&&&$$&&&&&$&$&$&$&$&$&$&&&&&&$&&&&&&&.                                              
                &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&                                                  
                  .;::;:;:;:;:;:;:;:;:;:;:;;::+:                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
}

else if (string.Join('|', input) == string.Join('|', Expendable_Napalm))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                    @@                                                                              
                    @@@@                                                                            
                    @@@@@@                                                                          
                    @@@@@@@@                                                                        
                    #@@@@@@@=                                                                       
                   +@@@@@@@@                *-    -:                                                
                 #@@@@@@@@@@  %#           .@@@%  @@@@@@           :=*@@@@@@@@@#=:                  
               -@@@@@@@@%+@@  @@            @@@@  @@@@@@%-   :=*@@@@@@@@@@@@@@@@@@@@@*+=            
              @@@@@@@@-   @@-=@@=.            @@#*%#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
              @@@@@@@:   -@@@@@@@%            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#          
              @@@@%:     +@@@@@@@@          :#@@  :*@@@@@@##@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+          
              @@@#          =@@@@@*        :@@@@  @@@@@@           =@@@@@@@@@@@@@*                  
              .%@@@@        -@@@            +:    :                                                 
                 +@@@@.  .@@@@-                                                                     
                  =@@@.  :@@%                                                                       
                     :    =:                                                                        
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
         .##################################################################################        
          ##################################################################################        
         .##+++++++++++++++++++++++++++++++++++++++++++++++++++=+=++++++++++=+++++++++===+##        
         .##==============================================================================##        
         .#######################*****#####################+++===+++++*####*+*##############        
          ###################################################*++*########+####++###########*        
                        ::    .:-=----::      ::         .::++*#+*+*##*:  .-#*                      
                                                             -##.           ##                      
                                                           .####=.          ##:                     
                                                          ####             .##                      
                                                        =*##=.              ##:                     
                                                       :####                ##-.                    
                                                                           .##*=                    
                                                                            --                      
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
}

else if (string.Join('|', input) == string.Join('|', Solo_Silo))
{
    Console.WriteLine(@"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                @@@@                                                
                                              @@@@@@@@                                              
                                           .@@@@@@@@@@@@.                                           
                                           .@@@@@@@@@@@@.                                           
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                            @@@@@@@@@@@@                                            
                                       . .  @@@@@@@@@@@@  .                                         
                                      @@#=  @@@@@@@@@@@@  -#@@                                      
                                      @@:   @@@@@@@@@@@@   -@@                                      
                                    @@@@    @@@@@@@@@@@@    @@@@                                    
                                   -@@@@    @@@@@@@@@@@@    @@@@-                                   
                                  @@@@@@    @@@@@@@@@@@@    @@@@@@                                  
                                -%@@@@@@    @@@@@**@@@@@    @@%@@@%-                                
                              =@@@@@@@@@=   @+        +@   =@@@@@@@@@=                              
                    :--.      =@@@@@@@@@:        ..        :@@@@@@@@@=      .--:                    
                .=#######+-       =#*-       :=######=:       -*#=       -+#######=.                
             :=*############*-            =*############*=            -*############*=:             
         :=######*========#######-    =######*========#######=    -#######========*######=:         
      #######+=====+=+=+======*##########+=====+=+=+======+##########*======+=+=+=====+#######      
      ##**=====+============+======++===================+======++==================+======**##      
      =*++=====================++======+===================++======+==================+===*+*=      
      +#+*================================================================================++#+      
      +#+*===+========================================================================+===*+#+      
      +*++================================================================================++*+      
      *###*#****************************************************************************#*###*      
      ########################################################################################      
      ..                                                                                    ..      
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    ");
}

else
{
    Console.WriteLine(@"                
                
 ,--,     ,--,  
 |'. \   / .`|  
 ; \ `\ /' / ;  
 `. \  /  / .'  
  \  \/  / ./   
   \  \.'  /    
    \  ;  ;     
   / \  \  \    
  ;  /\  \  \   
./__;  \  ;  \  
|   : / \  \  ; 
;   |/   \  ' | 
`---'     `--`  
                ");
    Console.WriteLine("Try again.....");
}
Console.ReadLine();