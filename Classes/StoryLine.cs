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
            Console.Clear();
            //ASCII ART
            Console.WriteLine("\n\n\nIn the Milky Way galaxy, there has been a war going for a very long time.\n" +
            "The Space Force is trying to bring peace and tranquility, however, a Rebellion was formed to counter Space Force.\n" +
            "For years, lives have been lost and put through misery. That's why I'm joining the Space Force I am on my way to Space\n" +
            " Force Headquarters.This is where our journey begins.\n");
            Actions.Pause();
        }
        public void ChapterOnePartOne()
        {
            Console.Clear();
            //ASCII ART
            Console.WriteLine("\n\n\nFrom now on you will be refered to as \"Cadet\" The Cadet arrives at the Space HQ to start their training as a recruit. \n" + 
                              "The user gets his first mission, it is to go on Mars and retrieve an ore, it is said to have magical powers which would be beneficial to the Space Force. \n");
            Actions.Pause();
        }
        public void FirstMissionBrief()
        {
            Console.Clear();
            //ASCII ART
            Console.WriteLine(
                "\n\n\nYour first mission with Space Force is to go to planet Mars " +
                "and retrieve an ore which is said to have magic powers,\n" +
                "This ore can help us dearly with our battle! We are counting on you!\n" +
                "This mission can be done by either bargaining with the Alien inhabitents or \n" +
                "by taking it by force. The product you have to bargain with is food. The choice to bargain or not is yours.\n");
            Actions.Pause();
        }
        public void ChapterOnePartTwo()
        {
            Console.Clear();
            //ASCII ART
            Console.WriteLine("\n\n\nThe Cadet enters Mars in search of the Ore, the user sees a dark abandoned castle.\n" +
                "  He walks down a dark hall and he sees an Ogre, guard the Ore. \n" +
                "With the weapon of choice, the user fights the Ogre and defeats it. \n" +
                " The user grabs the Ore and returns to Space Force and shows it to the Captain. ");
            Actions.Pause();
        }
        public void ChapterTwoPartOne()
        {
            Console.Clear();
            //ASCII ART
            Console.WriteLine("\n\n\nNext Mission.  The next mission is on Saturn, you have gotten the next item is a sword.\n" +
                              "  The user replenishes his defenses and prepares for Saturn.\n" +
                              " Saturn is said to be a friendly planet. There's only one way to find out.\n");
            Actions.Pause();
        }
        public void ChapterTwoPartTwo()
        {
          
            Console.WriteLine("\n\n\nNext Mission.  The next mission is on Saturn, you have gotten the next item is a sword.\n" +
                              "  The user replenishes his defenses and prepares for Saturn.\n" +
                              " Saturn is said to be a friendly planet. There's only one way to find out.\n");
        }
        public void ChapterTwoPartThree()
        {
           
        }
        public void VerbalExchangeWithCaptain()
        {
            Console.WriteLine("\n\n\nThe cadet makes his way back to Space Force HQ, new magical item in hand to give to his Captain. \n" +
                              " The Merchant asks his Captain “Sir, what are all these items for? he Captain looks at his cadet with an irritated look.\n" +
                              "The Captain says, “It’s so we can restore peace and order to the galaxy, of course.\n" +
                              "The cadet looks at him and says “Yes, Sir.” \n" +
                              "The cadet receives his mission objective.\n");
        }
        public void ChapterThree()
        {

        }
        public void ChapterFour()
        {

        }
        public void FinalChapter()
        {
            //TODO
        }

        public void GameOver()
        {

        }
    }
}
