using System;


namespace SpaceGameTest
{
    class StoryLine
    {
        public void Start()
        {
            //Title = "Space Game!";
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string prompt = @"                                                                               
                                                                                
                                      ((##*                                     
                        ..          ((((((##            .                    .  
                                   ((((((((###    .                             
               *                             ...                                
                                              ...                               
                                               ...                              
                                    (,(((((((   ...                             
                                  #/*,  ,,**,((  ...                            
         .  .   .                (#*,,********#(  ..             . .            *
                                 ((********,**(*  ...                           
                                  ((#*******#(,   ...                           
                           (         ((((#(/.     ...(                          
                          ##                      ...##                         
                         ##(           ((#        ...(##                        *
                        ##/(.         .((#          (((/#                       
                *       #////..       ,((#      ..  /(((/                       
                       ##((((         .((#       ..,((((##                      
                       ##(((((         ((#      ...(((((##                      
                       ##((((((        ((#     ...((((((##                      
                        #(((((( #((((((((#((((((, ((((((#                       
                  .     .#((     *,... (#, ...**     ((#           .            
            .                    *,,   . . ...,*                                
                                **...       ...*,                               
                                **...      ....*,                               
                                 **....   ....**                                
                                  **,.......,**                                 
                                   ***,...,***   .         *                 .   
                                     ,******                               .    
                                        ,                                       
                                                                                

                  _____                         _____                      
                 / ____|                       / ____|                     
                | (___  _ __   __ _  ___ ___  | |  __  __ _ _ __ ___   ___ 
                 \___ \| '_ \ / _` |/ __/ _ \ | | |_ |/ _` | '_ ` _ \ / _ \
                   __) | |_) | (_| | (_|  __/ | |__| | (_| | | | | | |  __/
                |_____/| .__/ \__,_|\___\___|  \_____|\__,_|_| |_| |_|\___|
                       | |                                                 
                       |_|                                                 


            Welcome to the Space Game!";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Prologue();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }
        //The cases of selectedIndex
        private void ExitGame()
        {
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
        private void DisplayAboutInfo()
        {
            
            Console.WriteLine("This game was created by Jorge Sanchez, Bryan Landaverde, Jasmine Meade and Milton Silver");
            Console.WriteLine("Game Title from http://patorjk.com/software/taag/#p=testall&f=Bloody&t=Space%20Game.");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey(true);
            RunMainMenu();

        }
        public void Prologue()
        {
            //image added
            Console.Clear();
            Console.WriteLine(@"
.    _     *       \|/   .       .      -*-              +
    .' \\`.     +    -*-     *   .         '       .   *
 .  |__''_|  .       /|\ +         .    +       .           |
    |     | .                                        .     -*-
    |     |           `  .    '             . *   .    +    '
  _.'-----'-._     *                  .
/          apc\__.__.--._______________");
            Console.WriteLine("\n\n\nIn the Milky Way galaxy, there has been a war going for a very long time.\n" +
            "The Space Force is trying to bring peace and tranquility, however, a Rebellion was formed to counter Space Force.\n" +
            "For years, lives have been lost and put through misery. That's why I'm joining the Space Force I am on my way to Space\n" +
            " Force Headquarters.This is where our journey begins.\n");
            Actions.Pause();
        }
        public void ChapterOnePartOne()
        {
            //Image added
            Console.Clear();
            Console.WriteLine(@"          |>>>
                   _                      _                |
    ____________ .' '.    _____/----/-\ .' './========\   / \
   //// ////// /V_.-._\  |.-.-.|===| _ |-----| u    u |  /___\
  // /// // ///==\ u |.  || | ||===||||| |T| |   ||   | .| u |_ _ _ _ _ _
 ///////-\////====\==|:::::::::::::::::::::::::::::::::::|u u| U U U U U
 |----/\u |--|++++|..|'''''''''''::::::::::::::''''''''''|+++|+-+-+-+-+-+
 |u u|u | |u ||||||..|              '::::::::'           |===|>=== _ _ ==
 |===|  |u|==|++++|==|              .::::::::.           | T |....| V |..
 |u u|u | |u ||HH||         \|/    .::::::::::.
 |===|_.|u|_.|+HH+|_              .::::::::::::.              _
                __(_)___         .::::::::::::::.         ___(_)__
---------------/  / \  /|       .:::::;;;:::;;:::.       |\  / \  \-------
______________/_______/ |      .::::::;;:::::;;:::.      | \_______\________
|       |     [===  =] /|     .:::::;;;::::::;;;:::.     |\ [==  = ]   |
|_______|_____[ = == ]/ |    .:::::;;;:::::::;;;::::.    | \[ ===  ]___|____
     |       |[  === ] /|   .:::::;;;::::::::;;;:::::.   |\ [=  ===] |
_____|_______|[== = =]/ |  .:::::;;;::::::::::;;;:::::.  | \[ ==  =]_|______
 |       |    [ == = ] /| .::::::;;:::::::::::;;;::::::. |\ [== == ]      |
_|_______|____[=  == ]/ |.::::::;;:::::::::::::;;;::::::.| \[  === ]______|_
   |       |  [ === =] /.::::::;;::::::::::::::;;;:::::::.\ [===  =]   |
___|_______|__[ == ==]/.::::::;;;:::::::::::::::;;;:::::::.\[=  == ]___|_____");
            Console.WriteLine("\n\n\nFrom now on you will be refered to as \"Cadet\" The Cadet arrives at the Space HQ to start their training as a recruit. \n" + 
                              "The user gets his first mission, it is to go on Mars and retrieve an ore, it is said to have magical powers which would be beneficial to the Space Force. \n");
            Actions.Pause();
        }
        public void FirstMissionBrief()
        {
            Console.Clear();
            
            Console.WriteLine(
                "\n\n\nYour first mission with Space Force is to go to planet Mars " +
                "and retrieve an ore which is said to have magic powers,\n" +
                "This ore can help us dearly with our battle! We are counting on you!\n" +
                "This mission can be done by defeating the evil aliens the protect these magical items\n");
            Actions.Pause();
        }
        public void ChapterOnePartTwo()
        {
            Console.Clear();
            Console.WriteLine(@"             .                                            .
     *   .                  .              .        .   *          .
  .         .                     .       .           .      .        .
        o                             .                   .
         .              .                  .           .
               .
                 .          .                 ,                ,    ,
 .                  .                         .
      .         ,
   .               .                 .                   .            .
     .                         ,             .                .
               ####      .                              .        .
             #  #O#####                .                        .
   .        #*#   ######                       .                     ,
        .   ##*#   #####               .                     .
      .      ##*#  #o###         .                             ,       .
          .     *#  ##     .                    .             .          ,
                                .                         .
____^/\___^--____/\__________________/\/\---/\___________---______________
   /\^   ^  ^    ^                  ^^ ^  '\ ^          ^       ---
         --           -            --  -      -         ---  __       ^
   --  __                      ___--  ^  ^                         --  __

 __          __  _                            _          __  __                
 \ \        / / | |                          | |        |  \/  |               
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   | \  / | __ _ _ __ ___ 
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | |\/| |/ _` | '__/ __|
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |  | | (_| | |  \__ \
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  |_|  |_|\__,_|_|  |___/
                                                                               
                                                                               
");
            Console.WriteLine("\n\n\nThe Cadet enters Mars in search of the Ore, It is said to be guarded by an devil\n" +
                " The cadet explores the surrounds, new and unknown. It is said the devil lives in an abondoned castle \n" +
                "On his adventure the cadet sees a gpysy, she has a stand of items for travels to buy\n" +
                "The gpysy sees the cadet, smiles and welcomes the traveler.  The cadet approaches the woman and ask if she knows where the Orge's castle is located\n " + 
                "The gypsy tells the cadet that finding the devil is a dangerous quest, why would you be looking for the beast?\n" + 
                "I'm on my first mission with the Space Force, my orders are to retrieve the ore the ogre is gaurding.\n " + 
                "The gypsy gives a shocked look to the cadet, suite yourself dearie, but I warn you the beast is powerful, why don't you purchase some supplies to prepare? \n" + 
                "The Cadet buys his supplies and the gypsy tells him beyond the hills is where he will find the orge.\n" + 
                "The Cadet reaches the castle, intimadated but determined he enters. The orge appears from the castle gates, guarding the ore which is located behind him.\n" + 
                "The Cadet draws his weapon of choice, and battles the the beast");
            //Battle starts, cadet beats devil and retrieves Ore and heads to back to Space Force HQ
            Actions.Pause();
        }
        public void ChapterTwoPartOne()
        {
            Console.Clear();
            Console.WriteLine(@"              .                                            .
     *   .                  .              .        .   *          .
  .         .                     .       .           .      .        .
                   *                  .                   .
         .              .                  .           .
               .
                 .          .      ,MMM8&&&.       *
                               _...MMMMM88&&&&..._
                           .::'''MMMMM88&&&&&&'''::.
     *                   ::     MMMMM88&&&&&&     ::        *
                          '::....MMMMM88&&&&&&....::'
                             `''''MMMMM88&&&&''''`
   jgs                             'MMM8&&&'           ,         ,    ,
 .                    .                         .
      .         ,
   .               .                 .                   .            .
     .                          ,             .                .
                    .                              .        .
                            .                        .
   .             *                .                     ,
        .                 .                     .
      .              .                             ,       .
          .      .                    .             .          ,
                                .                         .
____^/\___^--____/\____O______________/\/\---/\___________---______________
   /\^   ^  ^    ^                  ^^ ^  '\ ^          ^       ---
         --           -            --  -      -         ---  __       ^
   --  __                      ___--  ^  ^                         --  __

 __          __  _                            _           _____       _                    
 \ \        / / | |                          | |         / ____|     | |                   
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   | (___   __ _| |_ _   _ _ __ _ __  
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \   \___ \ / _` | __| | | | '__| '_ \ 
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) |  ____) | (_| | |_| |_| | |  | | | |
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  |_____/ \__,_|\__|\__,_|_|  |_| |_|
                                                                                           
                                                                                           
");
            Console.WriteLine("\n\n\nNext Mission.  The next mission is on Saturn, to retrieve the magical item, a sword by any means necessary.\n" +
                              "The user replenishes his defenses and prepares for Saturn.\n" +
                              "Saturn is said to be a friendly planet. There's only one way to find out.\n" + 
                              "The cadet arrives to the planet, learning from his previous battle with the orge to always stay alert\n " + 
                              "The centaur is said to be on the highest mountain on the planet of Saturn.\n" + 
                              "The cadet beings his climb up the mountain, the higher he travels the steeper it gets, air thinning,  making it difficult to breath \n" + 
                              "When the cadet reaches the top of the summit, he see a battle platfom and the centaur looking in the distance with the sword to the far right of the monster\n" + 
                              "Without making a sound, the cadet tries to be stealthy, steal the sword and avoid battle\n" + 
                              "While the cadet tries to stay quiet, he trips in a hole on the battle feild, the centaur reacts to the unfamliar sound. Turning around and seeing the cadet\n" + 
                              "They make eye contact, the cadet draws his weapon of choice. Saying to himself in disappoint....so much for being stealthy.");
                               // Cadet battles centaur, defeats monster, gets item, and returns to Space Force
            Actions.Pause();
        }
        public void ChapterTwoPartTwo()
        {
          Console.WriteLine(@" ` : | | | |:  ||  :     `  :  |  |+|: | : : :|   .        `              .
      ` : | :|  ||  |:  :    `  |  | :| : | : |:   |  .                    :
         .' ':  ||  |:  |  '       ` || | : | |: : |   .  `           .   :.
                `'  ||  |  ' |   *    ` : | | :| |*|  :   :               :|
        *    *       `  |  : :  |  .      ` ' :| | :| . : :         *   :.||
             .`            | |  |  : .:|       ` | || | : |: |          | ||
      '          .         + `  |  :  .: .         '| | : :| :    .   |:| ||
         .                 .    ` *|  || :       `    | | :| | :      |:| |
 .                .          .        || |.: *          | || : :     :|||
        .            .   . *    .   .  ` |||.  +        + '| |||  .  ||`
     .             *              .     +:`|!             . ||||  :.||`
 +                      .                ..!|*          . | :`||+ |||`
     .                         +      : |||`        .| :| | | |.| ||`     .
       *     +   '               +  :|| |`     :.+. || || | |:`|| `
                            .      .||` .    ..|| | |: '` `| | |`  +
  .       +++                      ||        !|!: `       :| |
              +         .      .    | .      `|||.:      .||    .      .    `
          '                           `|.   .  `:|||   + ||'     `
  __    +      *                         `'       `'|.    `:
 ____^/\___^--____/\____O______________/\/\---/\___________---______________
   /\^   ^  ^    ^                  ^^ ^  '\ ^          ^       ---
         --           -            --  -      -         ---  __       ^
   --  __                      ___--  ^  ^                         --  __

 __          __  _                            _               _             _ _            
 \ \        / / | |                          | |             | |           (_) |           
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___        | |_   _ _ __  _| |_ ___ _ __ 
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \   _   | | | | | '_ \| | __/ _ \ '__|
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |__| | |_| | |_) | | ||  __/ |   
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \____/ \__,_| .__/|_|\__\___|_|   
                                                                     | |                   
                                                                     |_|                   
");
            Console.WriteLine("\n\n\nNext Mission. The next mission is on Jupiter, you have to get next item is a gauntlet, guarded by a cyclops in the wheeping forest.\n" +
                              "The cadet arrives on Jupiter his missions are going well and he feels like he's earned a good reputation with the chain of command\n" + 
                              "As the cadet makes his way to the forest he sees the gypsy again. He appraoches her and he says you again? How did you even get here?\n" + 
                              "Ignoring his question, the gypsy smiles bright as she sees her favorite and only customer. Hello dearie, come to by more for my shop\n?" + 
                              "The cadet says sure, I'll need it for my battle with the cyclops. The gypsy looks and she ask him, do you believe what you're doing for the Space Force is right?\n" + 
                              "The cadet looks at her, upset and says of course I know it's right! This is for peace and order for the galaxy!\n" + 
                              "The gypsy looks at the cadet with weary eyes. After a moment of silence the gypsy tells the cadet that the wheeping forest is just ahead, there you will find the cyclops.\n" + 
                              "As the cadet walks off he hears the gypsy yell to him, soon you will know the true about the Space Force, the cadet looks back but doesn't respond.\n" + 
                              "The cadet enter the forest, as he travels further he sees the cyclops, sitting by a lake in the middle of the forest.\n" + 
                              "Irritated with what the gypsy said the cadet draws his weapon of choice and rushes to attack the cyclops\n");
        }                     // Gold and supply exchange. Cadet battles gaint, defeats giant and retrieves gauntlet
        public void ChapterTwoPartThree()
        {
           
        }
        public void VerbalExchangeWithCaptain()
        {
            Console.Clear();
            Console.WriteLine("\n\n\nThe cadet makes his way back to Space Force HQ, new magical item in hand to give to his Captain. \n" +
                              " The Merchant asks his Captain “Sir, what are all these items for? he Captain looks at his cadet with an irritated look.\n" +
                              "The Captain says, “It’s so we can restore peace and order to the galaxy, of course.\n" +
                              "The cadet looks at him and says “Yes, Sir.” \n" +
                              "The cadet receives his mission objective.\n");
        }
        public void ChapterThree()
        { 
            Console.WriteLine(@".         _  .          .          .    +     .          .          .      .
        .(_)          .            .            .            .       :
        .   .      .    .     .     .    .      .   .      . .  .  -+-        .
          .           .   .        .           .          /         :  .
    . .        .  .      /.   .      .     _..._     
                                         .:::::::.    /     *     *      /
            /      .            .       :::::::::::    /   .            .
               /           ,            `:::::::::'  
      `                           ,        ':::''    .     .     .  / .      . ' .
        .  +       .    /     .          .          .   /      .
       .            .  /         .            .        *   .         .     .
      .   .      .    *     .     .    .      .   .       .  .
          .           .           .           .           .         +  .
  . .        .  .       .   .      .    .     .     .    .      .   .

 .   +      .          ___/\_._/~~\_...__/\__.._._/~\        .         .   .
       .          _.--'                              `--./\          .   .
           /~~\/~\                                         `-/~\_            .
 .      .-'                                                      `-/\_
  _/\.-'                                                          __/~\/\-.__
.'                                                                           `.

 __          __  _                            _         __      __                  
 \ \        / / | |                          | |        \ \    / /                  
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___    \ \  / /__ _ __  _   _ ___ 
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \    \ \/ / _ \ '_ \| | | / __|
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) |    \  /  __/ | | | |_| \__ \
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/      \/ \___|_| |_|\__,_|___/
                                                                                    
                                                                                    
");
            Console.Clear();
            Console.WriteLine("\n\n\nNext Mission.  The next mission is on Venus, to retrieve the magical item, a powerful sapphire from a gyphon.\n" +
                              "The user replenishes his defenses and prepares for Venus.\n" +
                              "Upon entering the planet the cadet is told that the gyphon stays in a dark cave, following his map he heads to the cave.\n" + 
                              "Walking to his destination, the cadet sees his follow cadets in the distance and behind them, there's dark smoke and fire.\n " + 
                              "The peers meet and the cadet asks what happened to the village they were walking from.  His peers told the cadet that they just fininshed a mission assgined to them.\n" + 
                              "They go there seperate ways but the cadet takes a detour to the burning village, when he arrives, the villge is burned down, bodies scatter and dispair filled the air. \n" + 
                              "Leaving the village, the cadet thinks to himself, is this what the gypsy was talking about? This can't be the reason I joined the Space Force!\n" + 
                              "The cadet finally arrives at the cave, the gyphon steps out, the cadet draws his weapon of choice.  Angry about what he witnessed in the village, he charges at the beast\n" );
        }                      //Cadet defeats gyphon, obtains sapphire and returns to Space Force
        public void ChapterFour()
        {
            Console.WriteLine(@" .             *        .     .       .
       .     _     .     .            .       .
.    .   _  / |      .        .  *         _  .     .
        | \_| |                           | | __
      _ |     |                   _       | |/  |
     | \      |      ____        | |     /  |    \
     |  |     \    +/_\/_\+      | |    /   |     \
jro_/____\--...\___ \_||_/ ___...|__\-..|____\____/__
      .     .      |_|__|_|         .       .
   .    . .       _/ /__\ \_ .          .
      .       .    .           .         .

 __          __  _                            _          _____  _       _        
 \ \        / / | |                          | |        |  __ \| |     | |       
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   | |__) | |_   _| |_ ___  
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  |  ___/| | | | | __/ _ \ 
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |    | | |_| | || (_) |
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  |_|    |_|\__,_|\__\___/ 
                                                                                 
                                                                                 
");
            Console.Clear();
            Console.WriteLine("\n\n\nNext Mission.  The next mission is on Pluto, the final mission before the Space Force has all the magical items\n" +
                              "The last item is a ruby and it's with one of the most powerful enemies in the galaxy, the dragon who lives in the dungeon\n" +
                              "The cadet arrives on Pluto, it's said very few people live here becuase for the frosty temperture\n" + 
                              "The cadet makes his way to the dragon's lair ready for the final battle, to retrieve the ruby, and help bring peace and order to the galaxy....Or so he thought.\n " + 
                              "The cadet makes it to the dungeon, cild, dark and theres remains of people who have dared enter the lair, the work of the dragon\n" + 
                              "After looking around the cadet feels like he's being watched and he was right.  The cadet turns arouond and he see two eyes glowing in the dark\n" + 
                              "Seeing the giant monster the cadet freezes, the dragon preparing to breath fire at the cadet, he dodges and when he looks at the dragon he sees the ruby in his chest.\n" + 
                              "The cadet draws his weapon of choice and the final battle for the magical item begins.......\n" );
        }                      //Cadet beats dragons, retrieves rudy and heads back to Space Force


        public void VerbalExhangewithGeneral()
        {
           Console.Clear();
           Console.WriteLine("\n\n\nThe Captain enter the General's quaters. He tells the Commanding Officers that the last peice to the magical item is on it's way to the Space Force as we speak \n" + 
               "The General say's good, everything is going according to plan and soon the galaxy will bow to the power of the Space Force!\n " + 
               "The Captain agrees and says the cadet seems to be questions the motives we have Sir. The General says, no matter by the time he figures it out it will be too late.....\n");
        
        
        
        
        }
        public void FinalChapter()
        {
            Console.Clear();
            Console.WriteLine(@"
______ _             _      
|  ___(_)           | |     
| |_   _ _ __   __ _| | ___ 
|  _| | | '_ \ / _` | |/ _ \
| |   | | | | | (_| | |  __/
\_|   |_|_| |_|\__,_|_|\___|
                            
                            
");         Console.WriteLine("\n\n\nThe cadet makes it to the Space Force HQ, ruby in hand the last magical item.\n" + 
                                  "Following his gut, he decided to hold on to the ruby until he know the truth and the mission of the Space Force.\n" + 
                                  "the cadet starts to walk around HQ and he makes his way to the General's quaters, where he hears the General and Captian talking....\n" + 
                                  "He over hears their plan, to take over the galaxy by force with the magical items.  The cadet gets angry and the general looks back and sees the cadet\n" + 
                                  "The cadet steps into the quaters and tells the commanding officer he'll never let him take over the galaxy.  The General tells the cadet to give him the ruby.\n" + 
                                  "The cadet refuses. The General smiles and says very well, I'll take it from you by force.  The General equips the magical items he has and prepares for battle\n" + 
                                  "Only having the rudy, the cadet equips the magical item to his weapon of choice.  From there the final battle for the galaxy begins!");
                                   // cadet and general fight, cadet wins, galaxy is saved
        }

       public void GameOver()
        {
            Console.WriteLine(@"
  /$$$$$$                                                     /$$               /$$             /$$     /$$                                                                
 /$$__  $$                                                   | $$              | $$            | $$    |__/                                                                
| $$  \__/  /$$$$$$  /$$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$  /$$$$$$   /$$   /$$| $$  /$$$$$$  /$$$$$$   /$$  /$$$$$$  /$$$$$$$   /$$$$$$$                                  
| $$       /$$__  $$| $$__  $$ /$$__  $$ /$$__  $$|____  $$|_  $$_/  | $$  | $$| $$ |____  $$|_  $$_/  | $$ /$$__  $$| $$__  $$ /$$_____/                                  
| $$      | $$  \ $$| $$  \ $$| $$  \ $$| $$  \__/ /$$$$$$$  | $$    | $$  | $$| $$  /$$$$$$$  | $$    | $$| $$  \ $$| $$  \ $$|  $$$$$$                                   
| $$    $$| $$  | $$| $$  | $$| $$  | $$| $$      /$$__  $$  | $$ /$$| $$  | $$| $$ /$$__  $$  | $$ /$$| $$| $$  | $$| $$  | $$ \____  $$                                  
|  $$$$$$/|  $$$$$$/| $$  | $$|  $$$$$$$| $$     |  $$$$$$$  |  $$$$/|  $$$$$$/| $$|  $$$$$$$  |  $$$$/| $$|  $$$$$$/| $$  | $$ /$$$$$$$//$$                               
 \______/  \______/ |__/  |__/ \____  $$|__/      \_______/   \___/   \______/ |__/ \_______/   \___/  |__/ \______/ |__/  |__/|_______/| $/                               
                               /$$  \ $$                                                                                                |_/                                
                              |  $$$$$$/                                                                                                                                   
                               \______/                                                                                                                                    
 /$$     /$$                        /$$                             /$$             /$$     /$$                                                                   /$$      
|  $$   /$$/                       | $$                            | $$            | $$    | $$                                                                  | $$      
 \  $$ /$$//$$$$$$  /$$   /$$      | $$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$         /$$$$$$  | $$$$$$$   /$$$$$$         /$$$$$$   /$$$$$$  /$$$$$$/$$$$   /$$$$$$ | $$      
  \  $$$$//$$__  $$| $$  | $$      | $$__  $$ /$$__  $$ |____  $$|_  $$_/        |_  $$_/  | $$__  $$ /$$__  $$       /$$__  $$ |____  $$| $$_  $$_  $$ /$$__  $$| $$      
   \  $$/| $$  \ $$| $$  | $$      | $$  \ $$| $$$$$$$$  /$$$$$$$  | $$            | $$    | $$  \ $$| $$$$$$$$      | $$  \ $$  /$$$$$$$| $$ \ $$ \ $$| $$$$$$$$|__/      
    | $$ | $$  | $$| $$  | $$      | $$  | $$| $$_____/ /$$__  $$  | $$ /$$        | $$ /$$| $$  | $$| $$_____/      | $$  | $$ /$$__  $$| $$ | $$ | $$| $$_____/          
    | $$ |  $$$$$$/|  $$$$$$/      | $$$$$$$/|  $$$$$$$|  $$$$$$$  |  $$$$/        |  $$$$/| $$  | $$|  $$$$$$$      |  $$$$$$$|  $$$$$$$| $$ | $$ | $$|  $$$$$$$ /$$      
    |__/  \______/  \______/       |_______/  \_______/ \_______/   \___/           \___/  |__/  |__/ \_______/       \____  $$ \_______/|__/ |__/ |__/ \_______/|__/      
                                                                                                                      /$$  \ $$                                            
                                                                                                                     |  $$$$$$/                                            
                                                                                                                      \______/                                             
");
        }
    }
}
