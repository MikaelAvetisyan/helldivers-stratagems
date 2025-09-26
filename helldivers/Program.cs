using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Net.Mail;

//add status of the hive lord (make better)
//add fighting 
//add when about to die, give option for stim
int Hive_lord = 30000;
int Helldiver = 150;
int stims;
stims = 4;
int grenades;
grenades = 4;


Console.WriteLine(@" 
  _  _     _ _    _ _               ___ _            _                          ___                
 | || |___| | |__| (_)_ _____ _ _  / __| |_ _ _ __ _| |_ __ _ __ _ ___ _ __    / __|__ _ _ __  ___ 
 | __ / -_) | / _` | \ V / -_) '_| \__ \  _| '_/ _` |  _/ _` / _` / -_) '  \  | (_ / _` | '  \/ -_)
 |_||_\___|_|_\__,_|_|\_/\___|_|   |___/\__|_| \__,_|\__\__,_\__, \___|_|_|_|  \___\__,_|_|_|_\___|
                                                             |___/                                 ");
Console.WriteLine("------ Welcome to Helldiver Stratagem Game, press enter to continue ------");
Console.ReadLine();
Console.WriteLine("You are spreading democracy and a big worm drilled up to the surface");
Console.WriteLine("The big worm's name is THE HIVE LORD");
Console.WriteLine("HIVE LORD HP = 30 000");
Console.WriteLine();
while (true)
{
  Console.WriteLine("------------ Stratagems available ------------");
  Console.WriteLine("Railgun => Down - Right - Down - Up - Left - Right");
  Console.WriteLine("Commando Rocket Launcher => Down - Left - Up - Down - Right");
  Console.WriteLine("Quasar Cannon => Down - Down - Up - Left - Right");
  Console.WriteLine("Shield Generator Pack => Down - Up - Left - Right - Left - Right");
  Console.WriteLine("True flag => Down - Up - Right - Right - Down");
  Console.WriteLine("Expendable Napalm => Down - Down - Left - Up - Left");
  Console.WriteLine("Solo Silo => Down - Up - Right - Down - Down");
  Console.WriteLine();
  Console.WriteLine("Orbital Laser => Right - Down - Up - Right - Down");
  Console.WriteLine("Orbital Napalm Barrage => Right - Right - Down - Left - Right - Up");
  Console.WriteLine("Orbital Railcannon Strike => Right - Up - Down - Down - Right");
  Console.WriteLine("500kg Bomb => Up - Right - Down - Down - Down");
  Console.WriteLine();
  Console.WriteLine("Autocannon Sentry => Down - Up - Right - Up - Left - Up");
  Console.WriteLine("Rocket Sentry => Down - Up - Right - Right - Left");
  Console.WriteLine("Emancipator Exosuit => Left - Down - Right - Up - Left - Down - Up");
  Console.WriteLine();
  Console.WriteLine("Portable Hellbomb => Down - Right - Up - Up - Up");
  Console.WriteLine();


  List<ConsoleKey> allowedKeys = [ConsoleKey.UpArrow,ConsoleKey.DownArrow,ConsoleKey.RightArrow, ConsoleKey.LeftArrow, ConsoleKey.A, ConsoleKey.B];

  List<ConsoleKey> input = new List<ConsoleKey>();
  ConsoleKey key;

  while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
  {
    if (allowedKeys.Contains(key))
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

  ConsoleKey[] Secret = { ConsoleKey.UpArrow, ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.A, ConsoleKey.B };

  if (string.Join('|', input) == string.Join('|', Railgun))
  {
    Console.WriteLine
    ("""       
        
                                                                                
                        .=:   :==-.  .-- -========:......          
                        :*%@=@%**#@**@#= #@@@@@@@@@@@@@@@*.        
                            #@%    =@@:   #@@@@@@@@@@@@@@@@%        
                        :@@= =@@@@#.:%@# #@@@@@@@@#++++++:         
                                                                    
                                                                    
                                                                    
                                                                    
                                                                    
                        .========================================.    
                        .========================================.    
                        .=======================:-:==============.    
                        .--====== :==:.:                              
                            :===:                                  
                                                                    
                    """);
    

    Console.WriteLine("You used a Railgun");
    Console.WriteLine();
    Console.WriteLine("Do you.....");
    Console.WriteLine("Fully charge for more damage but has a chance to explode killing you (write: Fully charge)");
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
        Console.WriteLine("You shot the HIVE LORD"); ;
        Console.WriteLine("You dealt 2 000 damage to HIVE LORD");
        Hive_lord -= 2000;
        Console.WriteLine("____________________________");
        Console.WriteLine("Hive lords HP = " + Hive_lord);
      }

      else if (rando == 4)
      {
        Console.WriteLine();
        Console.WriteLine("You charged the railgun and the KABOOOM!!!!!");
        Console.WriteLine("You died because you charged the railcannon to much");
        Helldiver -= 150;
        Console.WriteLine("____________________________");
        Console.WriteLine("Hive lords HP = " + Hive_lord);
      }

    }

    else if (charge == "SAFE CHARGE")
    {
      Console.WriteLine();
      Console.WriteLine("Safe charge");
      Console.WriteLine("You shot the HIVE LORD");
      Console.WriteLine("Damage done = 600");
      Hive_lord -= 600;
      Console.WriteLine("____________________________");
      Console.WriteLine("Hive lords HP = " + Hive_lord);
    }

    else
    {
      Console.WriteLine("Wrong input, Your super destroyer complimented how stupid you are");
    }
  }

  else if (string.Join('|', input) == string.Join('|', Commando))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
          -+                                      
          :@@+                                    
          :%%%#:                                  
          .---------------------------:           
          -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-         
           ..............:@@@@@@@@@@@@@@%         
          -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=         
           ::::::::::::::::::::::::::::           
          :%%%%:                                  
          :@@=                                    
          :+                                      
                                                  
                     .:::::::::::::.              
      :====================================.      
      .====================================.      
      .====================================.      
      .--------===========================:       
              .---=========:-:-==-::=-:.          
                    -=====-  .==:  .=:            
                    .===-:::::=:                  
                     -=.                          
                                                  
                                                  
                                                  ");
    Console.WriteLine("You used a The Commando");
    Console.WriteLine();
    Console.WriteLine("Rocket launcher, has a laser that the rockets follow");
    Console.WriteLine();
    Console.WriteLine("You shot the HIVE LORD");
    Console.WriteLine("You dealt 5 000 damage to the HIVE LORD");
    Hive_lord -= 5000;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
  }

  else if (string.Join('|', input) == string.Join('|', Orbital_laser))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                        %%                        
                        %%                        
                        %%                        
                        %%                        
                        %%                        
                 :+     %%     +:                 
                  *@*   %%   *@*                  
                   :*: +@@+ :*:                   
                     =@@@@@@=                     
              :%%%%= @@@@@@@@ =%%%%:              
                     =@@@@@@+                     
                :: .: .+%%+. :. ::                
             :==. -=-==-  -==-=: .==:             
           :===. -======..======- .===:           
           ...   .......  .......  ....           
        .--:-: :--------  ------:-: :-:--.        
       .==--=. ==--=---=..=--=-=-== .=-===.       
       -====- :=-=======..=======-=: -==-=-       
      .=---=: -=-==-==-=  ==--=-=-=: :=-===.      
      :=====: ==========..========== :=====:      
                                                  
                                                  
                                                  ");
    Console.WriteLine("You used Orbital laser");
    Console.WriteLine();
    Console.WriteLine("Orbital laser will be up for 25 sec");
    Console.WriteLine("Orbital laser does 600 DPS");
    Console.WriteLine("The orbital laser auto aims");
    Console.WriteLine();
    Console.WriteLine("You shot the HIVE LORD");
    Console.WriteLine("Damage done = 15 000");
    Hive_lord -= 15000;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
  }

  else if (string.Join('|', input) == string.Join('|', Orbital_Napalm_Barrage))
  {
    Console.WriteLine(@" 

                      +:                          
                      #@*:                        
                      #@@@*                       
                     .@@@@@+                      
                    #@@@@@@==+                    
           -=     =@@@@@-*@*%@.   =:              
           =@%=   +@@@=  *@@@@*   *@*:            
           +@@@=  =@@-    -@@@%. .%@@@.           
         :%@@@@**. =%@*   *@%=  =@@@@@+*          
         @@@=.@@@*   --   -- . -@@% +@@@:         
         @@    %@#  -==-  ===- :@*   :@@=         
          :=  :=: :-=-==  =--=: .=-  --           
         :::::  ::::::::  ::::::::  :::::         
        ::::.  :::::::::  :::::::::  :::.:        
       -====: :=========  =========: :====-       
      -=-===. -==-==-==-  =-==-==-=- .=-=-=-      
     :=-===- :=-========  ==========. -===-=:     
     -===-=: :=-==-==--=  ==-==-==-=: :=-===-     
     -----=: :----------  ---------=: :=-----     
                                                  
                                                  ");
    Console.WriteLine("You used The Orbital Napalm Barrage");
    Console.WriteLine();
    Console.WriteLine("A Barrage of fire missiles from the sky");
    Console.WriteLine("You used the Napalm on hive lord");
    Console.WriteLine();
    Console.WriteLine("Damage done = 7 500");
    Hive_lord -= 7500;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
  }

  else if (string.Join('|', input) == string.Join('|', Orbital_Railcannon_Strike))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                      @%  %@.                     
                      :#%%#:                      
                      =@**@=                      
                      @*  *@:                     
                      @%  #@.                     
                       %@@%.                      
                      =@**@=                      
                      @*  *@:                     
                      ------.                     
                      @@@@@@-                     
                      @@@@@@:                     
                :: .  @@@@@@: . ::                
             :==. -=. @@@@@@: =: .==:             
           :===. -===: *@@* :===- .===:           
           ...   ..... +@@+ .....  ....           
        .--:-: :------ +@@+ :-:---: :-:--.        
       .==--=. ==----=..%%..-=-=-== .=-===.       
       -====- :=-======:  :======-=: -==-=-       
      .=---=: -=-==-=-==..=-=-=-=-=: :=-===.      
      :=====: ==========..========== :=====:      
                                                  
                                                  
                                                  ");
    Console.WriteLine("You used The Orbital Railcannon Striker");
    Console.WriteLine();
    Console.WriteLine("A big Railcannon on your ship, very good for big enemys with heavy armor");
    Console.WriteLine("The Railcannon auto aims");
    Console.WriteLine();
    Console.WriteLine("Railcannon does = 7 500 damage");
    Hive_lord -= 7500;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
  }

  else if (string.Join('|', input) == string.Join('|', bomb_500kg))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                   -:         --:.                
                  .-=-       :====-:              
                 := ::      :=-====-              
                 #@@=      .====-==-              
                =@@@@=     -=======-              
            =*@@@@@@@:    :=-==-===-              
       :-=- .@@@@@@@@%*#@#  -====-=-              
        .---: =*+==%@@@@@@@* .-====-              
                   #@@@@@@@@@+ .-==-              
                  .@@@@@@@@@@@%:.==-              
               .:-. +@@@@@@@@@@- ==-              
           ::-===-=-. *@@@@@@@@- ==-              
       :=============-  %@@@@@@=.==-              
        -==-===-==-====:....... :===:             
         -========================-==-.           
          :::::::::::::::::::::::======-.         
                                 .-=-==-=:        
                                   .-=====.       
                                     .:--=:       
                                                  
                                                  
                                                  
                                                  ");
    Console.WriteLine("You used 500 kg bomb");
    Console.WriteLine("");
    Console.WriteLine("Very big bomb and with a precise strike you can kill anybody");
    Console.WriteLine("You threw randomy and hoped for the best");
    Console.WriteLine();

    Random hello = new Random();
    int hello1 = hello.Next(1, 4);

    if (hello1 == 1)
    {
      Console.WriteLine("You hit the HIVE LORD directly");
      Console.WriteLine("You did 5 200 damage");
      Hive_lord -= 5200;
      Console.WriteLine("____________________________");
      Console.WriteLine("Hive lords HP = " + Hive_lord);
    }

    else if (hello1 == 2)
    {
      Console.WriteLine("The 500kg bomb landed right beside the HIVE LORD");
      Console.WriteLine("You did 2 400 damage");
      Hive_lord -= 2400;
      Console.WriteLine("____________________________");
      Console.WriteLine("Hive lords HP = " + Hive_lord);
    }

    else if (hello1 == 3)
    {
      Console.WriteLine("You missed, what a shame");
      Console.WriteLine("____________________________");
      Console.WriteLine("Hive lords HP = " + Hive_lord);
    }

  }

  else if (string.Join('|', input) == string.Join('|', Quasar_Cannon))
  {
    Console.WriteLine(@"                                                  
                                                  
                              :=                  
                         .:   +@   .:             
                         :%@: .:  *@+             
                           :.*%%%-.:              
           *****************%@@@@@= ***           
           :::::::::::::::::+@@@@%: :::           
                          :*..+*- -+.             
                         +@=  =%  .%@             
                              +@                  
                                                  
                                                  
       :============.                             
       :============.       .                     
     ==================---=====------::-:::-:     
     ========================================     
     ================================::::::::     
             .:====--: .-==-:::=.                 
                -+-     -=:   .-                  
                .-.    :=.                        
                                                  
 ");
    Console.WriteLine("You used Quasar Cannon");
    Console.WriteLine();
    Console.WriteLine("A laser cannon, needs to be charged up to deal real damage");
    Console.WriteLine();
    Console.WriteLine("Does 2 150 damage");
    Console.WriteLine("You shot the HIVE LORD");
    Hive_lord -= 2150;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
  }

  else if (string.Join('|', input) == string.Join('|', Shield_Generator_Pack))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                      ::::::::::::::::::::        
                      ====================.       
                      -==================-        
                       .================..        
                      =: :::::::::::::: :=.       
                      ===---- :==: :---===.       
             .==:     :-===== :==: -======.       
      =##%@@@@@@@@@@%%#*..===      -======.       
      #@@@@@@@@%*@@@@@@@:.================.       
      #@@@@@@@%.#@@@@@@@:.================.       
      #@@@@@@* -@@@@@@@@:.================.       
      #@@@@@=  =#**@@@@@:.================.       
      #@@@@*===.  #@@@@@:.================.       
      #@@@@@@@% .%@@@@@@:.================.       
      #@@@@@@@--@@@@@@@@:.===============:        
      =@@@@@@%+@@@@@@@@#..=============-          
        :*%@@@@@@@@@#=.                           
           :+%@@@#-                               
              .-                                  
                                                  
");
    Console.WriteLine("You used Shield Generator Pack");
    Console.WriteLine("");
    Console.WriteLine("Shield Generator gives you extra chance on life");
    Console.WriteLine("Shield gives an additional 200 hp to your main hp amount");
    Helldiver += 200;
    Console.WriteLine("_________________________________________");
    Console.WriteLine("You total health and armor =" + Helldiver);
  }

  else if (string.Join('|', input) == string.Join('|', True_flag))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                   #:        :#                   
                   -@#:    :#@-                   
                    =@@+ :*@@=                    
                     :=.*@@#:                     
                      =@@@:.                      
                 :+  @@@- *@@  +:                 
                :%@@+ :    : +@@%:                
                :%@@@@=    =@@@@%:                
               +@@*:=+.    .+=:*@@+               
                =:              :=                
                                                  
     :==========================+======+=++-:     
                               -*+*++*+*:         
                               -*++++++*:         
                               -*++++++*:         
                               -*++++++*:         
                               -*++++++*:         
                               -*++++++*:         
                               -*++++++*:         
                               =********:         
                                                  
                                                  
                                                  ");
    Console.WriteLine("You got the True Flag, a symbol of hope");
    Console.WriteLine("You put the flag down and Salut");
    Console.WriteLine();
    Console.WriteLine("What? you expected something else, its a flag");
  }

  else if (string.Join('|', input) == string.Join('|', Autocannon_Sentry))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                                                  
              ==========-::    :===========:      
                    :========-   -=========:      
      *@@@@@%  *@@@+  =======-=-                  
      %@@@@+ =@@@@@@. -========-=                 
      #@@* :@@@@@@@=  ============                
      :======:  ==-  :=============               
      %@@@@@  %@@@@@  ===========-=               
      %@@@: #@@@@@@@  =============:              
            .        ==============-              
      %@@@@@% .@@@@@  ::::::::::::::              
      %@@@@  @@@@@@@                              
      :++  :*=====-  :==========:                 
                  ----==-==-=--=.                 
                  .            .                  
                                                  
             ========================             
           -==========================-           
                          ");

    Console.WriteLine("You used a Auto-Cannon Sentry");
    Console.WriteLine("");
    Console.WriteLine("Auto cannon is a very strong sentry that can kill anybody");
    Console.WriteLine("You did 100% damage on one of the bile titan and put the other one on half hp");
    Console.WriteLine("");
    Console.WriteLine("You did 16 000 damage to HIVE LORD");
    Hive_lord -= 16000;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);

  }

  //____________________________________________________________________________________________

  else if (string.Join('|', input) == string.Join('|', Rocket_Sentry))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                                                  
              -=========-::    :===========:      
              -====::::::::==-   -=========:      
              -==-  :::::  =--=-                  
              -=  :@@@@@@  ====-=                 
                .@@@@@@@@  =-=====                
           ====@@@@@@@@@:  ========               
         #@@@@@@@@@@@@=  -=======-=               
       *@@@@@@@@@@@@*  :===========:              
      =*+++***@@@@@+ :=============-              
        =#=   @@@@@= :::::::::::::::              
      .@@- == @@@@@                               
          %@: @@@. .============:                 
          :   @:  =--=-==-==---=.                 
                  .          . .                  
                                                  
             ========================             
           -==========================-           
                                                  
  ");

    Console.WriteLine("You used the Rocket sentry");
    Console.WriteLine();
    Console.WriteLine("A rocket sentry that do big hole on anything it desire");
    Console.WriteLine("You used the Rocket sentry on the HIVE LORD");
    Console.WriteLine();
    Console.WriteLine("The Rocket sentry did 21 000 damage");
    Hive_lord -= 21000;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
  }

  else if (string.Join('|', input) == string.Join('|', Emancipator_Exosuit))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
     @@@@@@ @@@@                  @@@@@@ @@@@:    
     @@@  @@@@@@                  @@@@ @@@@@@#    
                                                  
     @@@@@ @@@@@@                 @@@@@ @@@@@@    
     @@@ @@@@@@:                  @@@ #@@@@@@     
                                                  
                                                  
                     .%%%%%%.                     
                :%%%%%%%%%%%%%%%%=                
                +%===*+    -#===%#                
                +%***#=    :%***%#                
                =%+#+%%%@@%%%+%*%+                
                     %* -* +%                     
                *%%* %% =* %% +%%%                
                =%%: :%%%%%%-  %%*                
                %%%%          #%%%                
                 :%%%@      @%%%:                 
                   %+%      %+%                   
                 %@@%@@=  -@@%@@@                 
                                                  
                                                  
                                                  
                                                  ");
    Console.WriteLine("You used the Emancipator exosuit");
    Console.WriteLine();
    Console.WriteLine("Big robot with 2 auto cannons on the side");
    Console.WriteLine("Robot gives you an extra life and does a lot of damage");
    Console.WriteLine("The robot Shields you from danger");
    Console.WriteLine();
    Console.WriteLine("The Emancipator Exosuit did 17 000 damage");
    Hive_lord -= 17000;
    Helldiver += 850;
    Console.WriteLine("___________________________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
    Console.WriteLine("Hellldivers health and armor =" + Helldiver);

  }

  else if (string.Join('|', input) == string.Join('|', Portable_Hellbomb))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                                                  
                      %%%%%%%%%%%%%%%%%%%%        
                      +%%%%%%%%%%%%%%%%%%=        
                        *%%%%%%%%%%%%%%+          
                      %:  .          .  :%        
               .=     %%%***= .++  =***%%%        
            :@@@@@@@.  #%%%%+ -%%: *%%%%%%        
          +@@@@@@@@@@@- +%%%+      *%%%%%%        
          @@@@@@@@@@@@% :%%%%%%%%%%%%%%%%%        
           :::+@@@=:::  %%%%%%%%%%%%%%%%%%        
               @@#      -#%%%%%%%%%%%%%%%%        
         @@%+-:+@-:=+%@@  %%%%%%%%%%%%%%%%        
           -+#%@@@%#+:   +%%%%%%%%%%%%%%%%        
               .@      %%#%%%%%%%%%%%%%%%%        
           :%  :@   @  . :%%%%%%%%%%%%%%%:        
         - :@@+%@**@@  -  #************-          
        -@%+@@@@@@@@@=@@:.                        
       @@@@@@@@@@@@@@@@@@%                        
         :::::::::::::::                          
                                                  
");
    Console.WriteLine("You used the Portable Hellbomb");
    Console.WriteLine("");
    Console.WriteLine("Works like a hellbomb, but its a backpack");
    Console.WriteLine("You strap on the Portable Hellbomb and run into the HIVE LORD");
    Console.WriteLine("");
    Console.WriteLine("You did 15 000 damage to the Hive lord at the cost of your life");
    Hive_lord -= 15000;
    Helldiver -= 150;
    Console.WriteLine("_______________________________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
    Console.WriteLine("Helldiver took a lot of damage => " + Helldiver);

  }

  else if (string.Join('|', input) == string.Join('|', Expendable_Napalm))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
          =                                       
          @@=                                     
          @@@@                                    
        :@@@@@:-      #= %%*      :=*#+-.         
       #@@@+-@*@:     -@*@@@@@@@@@@@@@@@@@@@=     
       %@#   @@@@     =@:@@@@*%@@@@@@@@@@@@@-     
       -@%    @@:     -  --:         :            
         *%  @+                                   
                                                  
                                                  
                                                  
                                                  
                                                  
     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#    
     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    
     +=====+*++*****+++*-::=**%%%#%*-*%-:::-*:    
                              *%.     %           
                             %*       %           
                            +*        %:          
                                                  

");
    Console.WriteLine("You used Expendable Napalm");
    Console.WriteLine("");
    Console.WriteLine("A rocket louncher with a napalm cluster bomb");
    Console.WriteLine("Burns anything in its way");
    Console.WriteLine("You shot the Expendable Napalm on the HIVE LORD");
    Console.WriteLine("");
    Console.WriteLine("You did 2 000 damage on the HIVE LORD");
    Hive_lord -= 2000;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
  }

  else if (string.Join('|', input) == string.Join('|', Solo_Silo))
  {
    Console.WriteLine(@"                                                  
                                                  
                                                  
                                                  
                       %@@%                       
                      @@@@@@                      
                      @@@@@@                      
                      @@@@@@                      
                      @@@@@@                      
                      @@@@@@                      
                      @@@@@@                      
                      @@@@@@                      
                      @@@@@@                      
                      @@@@@@                      
                   %: @@@@@@ :%                   
                  @@. @@@@@@ .@%                  
                 @@@. @@@@@@ .@@@                 
               :@@@@. +    + .@@@@:               
        =*%%*=   =-   =*%%*=   -=   =*%%*=        
    =*#%%%%%%%%#*--*#%%%%%%%%#*--*#%%%%%%%%#*=    
   *%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*   
   *%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*   
   *%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*   
   +#****************************************#+   
                                                  
");
    Console.WriteLine("You used the Solo Silo");
    Console.WriteLine("");
    Console.WriteLine("The Solo Silo get placed on the ground, a Missile come's out");
    Console.WriteLine("With the missle come's out a pistol with laser on it, where every you point the laser on, thats where the missile go");
    Console.WriteLine("You pointed it on the Hive lord");
    Console.WriteLine("");
    Console.WriteLine("The solo silo did 4 500 damage");
    Hive_lord -= 4500;
    Console.WriteLine("____________________________");
    Console.WriteLine("Hive lords HP = " + Hive_lord);
  }

  else if (string.Join('|', input) == string.Join('|', Secret))
  {
    Console.WriteLine(@"                                             
 ********                            ******* 
 ******                                ***** 
 ****                                   **** 
 **  ************ @@@@  @@@@ ************  * 
      ***********@@@@@  @@@@ ***********     
       **********@@@@@@@@@@@ **********      
        *********@@@@@@@@@@@ *********       
         ********@@@@@@@@@@@ *******         
          *******@@@@@@@@@@@ ******          
            @@@@   @@@@@@@@   @@@@           
           @@@@@   @@@@@@@@  @@@@@           
           @@@@@@@@@@@@@@@@@@@@@@@           
           @@@@@@@@@@@@@@@@@@@@@@@           
           @@@@@@@@@@@@@@@@@@@@@@@           
           @@@@@@@@@@@@@@@@@@@@@@@           
                   ********                  
                   ********                  
                    ******                   
                    *****                    
 ***                 ***                 *** 
 *****                                 ***** 
 *******                              ****** 
 ********                            ******* ");


    Console.WriteLine("You called for Resupply");
    Console.WriteLine("");
    Console.WriteLine("Restors ammo, stims and grenades");
    Console.WriteLine("Its vital for combat, gives the user higher chanse of survival in the battlefield");
    Console.WriteLine("This resupply is special, you get extra slots for your stims");
    Console.WriteLine("______________________");
    Console.WriteLine("You got " + (stims + 4) + " stims");
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

  if (Helldiver <= 0)
  {
    LoseTune();
    Console.WriteLine("------------------------------------");
    Console.WriteLine("You lose");
    int ello1 = new Random().Next(1, 5);

    string line1 = ello1 switch
    {
      1 => "Better luck next time but for the time being the terminids have won",
      2 => "Return, refit, and redeploy to purge the stain of this failure with the peroxide of victory.",
      3 => "Defeat is but the catalyst of its own rectification.",
      4 => "Victory was never in doubt.",
    };
    Console.WriteLine(line1);
    Console.ReadLine();
    break;
  }
  else if (Hive_lord <= 0)
  {
    VictoryTune();
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Victory! You defeated the Hive Lord!");

    int ello = new Random().Next(1, 8);

    string line = ello switch
    {
      1 => "That's one more victory for the right side of history!",
      2 => "Managed democracy offers absolute freedom; freedom from the burden of choice",
      3 => "The only good bug is a dead bug",
      4 => "Always good to have another hero onboard",
      5 => "How about a nice cup of LIBER-TEA?",
      6 => "How'd you like the taste of freedom?",
      7 => "We cannot let the enemy any closer to Super Earth",
    };
    Console.WriteLine(line);
    Console.ReadLine();
    break;
  }
}

static void VictoryTune()
{
  Console.Beep(523, 200);
  Console.Beep(659, 200);
  Console.Beep(783, 200);
  Console.Beep(1046, 400);
}

static void LoseTune()
{
  Console.Beep(400, 400);
  Console.Beep(350, 400);
  Console.Beep(300, 600);
}



