using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ComponentModel;

//add While loop
//add stratagem type
//add status of the hive lord
Console.WriteLine(@" 
  _  _     _ _    _ _               ___ _            _                          ___                
 | || |___| | |__| (_)_ _____ _ _  / __| |_ _ _ __ _| |_ __ _ __ _ ___ _ __    / __|__ _ _ __  ___ 
 | __ / -_) | / _` | \ V / -_) '_| \__ \  _| '_/ _` |  _/ _` / _` / -_) '  \  | (_ / _` | '  \/ -_)
 |_||_\___|_|_\__,_|_|\_/\___|_|   |___/\__|_| \__,_|\__\__,_\__, \___|_|_|_|  \___\__,_|_|_|_\___|
                                                             |___/                                 ");
Console.WriteLine("------ Welcome to Helldiver Stratagem Game, press enter to continue ------");
Console.ReadLine();
Console.WriteLine("Your spreding democracy and a big worm drilled up to the surface");
Console.WriteLine("The big worms name is THE HIVE LORD");
Console.WriteLine("HIVE LORD HP = 30 000");
Console.WriteLine();
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

int Hive_lord = 30000;
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
                                                  
                     
                                                  
       .=:   :==-.  .-- -========:......          
       :*%@=@%**#@**@#= #@@@@@@@@@@@@@@@*.        
          #@%    =@@:   #@@@@@@@@@@@@@@@@%        
       :@@= =@@@@#.:%@# #@@@@@@@@#++++++:         
                                                  
                                                  
                                                  
                                                  
                                                  
    .========================================.    
    .========================================.    
    .=======================:-:==============.    
    .--====== :==:.:                              
           :===:                                  
                                                  
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
      Console.WriteLine("You shot the HIVE LORD"); ;
      Hive_lord -= 2000;
      Console.WriteLine("You delt 2 000 damage to HIVE LORD");
    }

    else if (rando == 4)
    {
      Console.WriteLine();
      Console.WriteLine("You charged the railgun and the KABOOOM!!!!!");
      Console.WriteLine("You died because you charged the railcannon to much");
      Helldiver -= 150;
    }

  }

  else if (charge == "SAFE CHARGE")
  {
    Console.WriteLine();
    Console.WriteLine("Safe charge");
    Console.WriteLine("You shot the HIVE LORD");
    Hive_lord -= 600;
    Console.WriteLine("Damage done = 600");
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
  Console.WriteLine("You delt 5 000 damage to the HIVE LORD");
  Hive_lord -= 5000;
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

  Random hello = new Random();
  int hello1 = hello.Next(1, 4);

  if (hello1 == 1)
  {
    Console.WriteLine("You hit the HIVE LORD diractly");
    Console.WriteLine("You did 5 200 damage");
    Hive_lord -= 5200;
  }

  else if (hello1 == 2)
  {
    Console.WriteLine("The 500kg bomb landed right beside the HIVE LORD");
    Console.WriteLine("You did 2 400 damage");
    Hive_lord -= 2400;
  }

  else if (hello1 == 3)
  {
    Console.WriteLine("You missed, what a shame");
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
  Console.WriteLine("Shield Generator gives you extra chanse on life");
  Console.WriteLine("Shield gives an additional 200 hp to your main hp amount");
  Helldiver += 200;
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
  Console.WriteLine();
  Console.WriteLine("The Emancipator Exosuit did 17 000 damage");
  Hive_lord -= 17000;
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
  Console.WriteLine("");
  Console.WriteLine("");
  Console.WriteLine("");
  Console.WriteLine("");
  Console.WriteLine("");
  Console.WriteLine("");
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
  Console.WriteLine("");
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