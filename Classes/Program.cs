using System;
using System.Dynamic;
using System.Threading.Channels;


namespace SpaceGameTest
{

    public class Program
    {
        static void Main(string[] args)
        {
            StoryLine Story = new StoryLine();
            MainCharacter Cadet = new MainCharacter();
            {
                Cadet.Name = "Cadet";
                Cadet.Health = 100;
                Cadet.Loot = 0;
                Cadet.Product = Characters.ProductTypes.Food;
                Cadet.CharacterType = Characters.CharacterTypes.Hero;
            }
            Story.Start();
            
            Story.ChapterOnePartOne();
           
            Story.FirstMissionBrief();
           

            Console.WriteLine("Before you go, pick a weapon.\n");
            Console.WriteLine("These will be your weapon options, choose one to carry with you :\n");
            for (Characters.WeaponTypes w = Characters.WeaponTypes.Musket; w <= Characters.WeaponTypes.Dukes; w++)
            {
                Console.WriteLine($"Option {(int)w} is {w}");
            }

            //Need input validation to make sure user only selects options 1-4//
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Cadet.Weapon = Characters.WeaponTypes.Musket;
                    Console.WriteLine($"\nNice choice! A {Cadet.Weapon}");
                    Console.WriteLine(@",  /\  .  
                                       //`-||-'\\ 
                                      (| -=||=- |)
                                       \\,-||-.// 
                                        `  ||  '  
                                           ||     
                                           ||     
                                           ||     
                                           ||     
                                           ||     
                                           ()");
                    break;
                case 2:
                    Cadet.Weapon = Characters.WeaponTypes.Sword;
                    Console.WriteLine($"\nNice choice! A {Cadet.Weapon}");
                    Console.WriteLine(@"       |______________
                                        [======|______________>
                                               |
                                               '");
                    break;
                case 3:
                    Cadet.Weapon = Characters.WeaponTypes.Blunderbuss;
                    Console.WriteLine($"\nNice choice! A {Cadet.Weapon}");
                    Console.WriteLine(@"  (
                                            \
                                             )
                                       ##-------->        
                                             )
                                            /
                                           (");
                    break;
                case 4:
                    Cadet.Weapon = Characters.WeaponTypes.Dukes;
                    Console.WriteLine($"\nNice choice! Your {Cadet.Weapon}");
                    Console.WriteLine(@"   /\
                                          //\\
                                         //  \\
                                     ^   \\  //   ^
                                    / \   )  (   / \
                                    ) (   )  (   ) (
                                    \  \_/ /\ \_/  /
                                     \__  _)(_  __/
                                       \ \  / /
                                        ) \/ (
                                        | /\ |
                                        | )( |
                                        | )( |
                                        | \/ |
                                        )____(
                                       /      \
                                       \______/ ");
                    break;
            }
            Alien saturnAlien = new Alien();
            Actions a = new Actions();
            a.Fight(Cadet, saturnAlien);
        }
    }
}

