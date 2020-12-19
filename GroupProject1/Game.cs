using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject1
{
    public  class Game
    {
        static string itemSelection_Input;
        static int itemSelection;
        static string locationSelection_Input;
        static int locationSelection;
        static List<string> Inventory = new List<string>();

        static List<string> Treasure = new List<string>();

        static TreasurePickups[] TreasurePieces = TreasureArray();


        static Location[] locations = LocationArray();
        static ItemPickups[] items = ItemArray();
        static Player player1 = NewPlayer();
        static Player ronald = NewNPC();

        NPC Fred = new NPC();
        NPC Jim = new NPC() { Name = "Jim", Age = 15, Money = 100 };

        static Random random = new Random();
        static int number;


        public static void Play()
        {
            
            Console.WriteLine("Welcome to Limbo, time to find your way out\nThe game will end when you have collected 5 items or you perish");
            Console.WriteLine("You will have a few opportunities to pick up items, choose wisely");
            Console.ReadKey();
            Console.Clear();

            while (player1.health > 0 || Treasure.Count <= 5)
            {
                PickupItem();
                EnterLocation();
            }

            EndGame();

            
        }

        private static Location[] LocationArray()
        {
            Location[] locations = new Location[10];
            locations[0] = new Location
            {
                name = "Cave",
                hazard = "Extreme darkness hinders your vision",
                survivaltool = "Flashlight",
            };
            locations[1] = new Location
            {
                name = "Arakkis",
                hazard = "The arid landscape saps your water",
                survivaltool = "Stillsuit",
            };
            locations[2] = new Location
            {
                name = "Atlantis",
                hazard = "The aquatic landscape drowns you",
                survivaltool = "Scuba Gear",
            };
            locations[3] = new Location
            {
                name = "Insect Land",
                hazard = "Hordes of man-eating bugs swarm over you",
                survivaltool = "Bug Spray",
            };
            locations[4] = new Location
            {
                name = "Forest",
                hazard = "Vast trees block your path",
                survivaltool = "Axe",
            };
            locations[5] = new Location
            {
                name = "Excavation Site",
                hazard = "Digging by hand is difficult in the sweltering heat",
                survivaltool = "Shovel",
            };
            return locations;
        }


        private static TreasurePickups[] TreasureArray()
        {

            TreasurePickups[] TreasurePieces = new TreasurePickups[10];
            TreasurePieces[0] = new TreasurePickups
            {
                piece = "Idol head",
                treasureDescription = "The head of an ancient idol, power courses through your hand as you hold it."
            };
            TreasurePieces[1] = new TreasurePickups
            {
                piece = "Idol torso",
                treasureDescription = "The torso of an ancient idol, power courses through your hand as you hold it."
            };
            TreasurePieces[2] = new TreasurePickups
            {
                piece = "Idol left arm",
                treasureDescription = "The left arm of an ancient idol, power courses through your hand as you hold it."
            };
            TreasurePieces[3] = new TreasurePickups
            {
                piece = "Idol right arm",
                treasureDescription = "The right arm of an ancient idol, power courses through your hand as you hold it."
            };
            TreasurePieces[4] = new TreasurePickups
            {
                piece = "Idol left leg",
                treasureDescription = "The left leg of an ancient idol, power courses through your hand as you hold it."
            };
            TreasurePieces[5] = new TreasurePickups
            {
                piece = "Idol right leg",
                treasureDescription = "The right leg of an ancient idol, power courses through your hand as you hold it."
            };
            return TreasurePieces;
        }







        private static ItemPickups[] ItemArray()
        {
            ItemPickups[] items = new ItemPickups[10];
            items[0] = new ItemPickups
            {
                name = "Flashlight",
                description = "A Flashlight"
            };
            items[1] = new ItemPickups
            {
                name = "Stillsuit",
                description = "A suit to preserve the body's moisture"
            };
            items[2] = new ItemPickups
            {
                name = "Scuba Gear",
                description = "Equipment allowing for aquatic travel"
            };
            items[3] = new ItemPickups
            {
                name = "Bug Spray",
                description = "All-purpose bug repellent"
            };
            items[4] = new ItemPickups
            {
                name = "Axe",
                description = "Useful for tree chopping"
            };
            items[5] = new ItemPickups
            {
                name = "Shovel",
                description = "Useful for digging"
            };
            return items;
        }

        private static Player NewNPC()
        {
            Player ronald = new Player();
            ronald.health = 4;
            ronald.name = "Ronald";
            return ronald;
        }

        private static Player NewPlayer()
        {
            Console.WriteLine("Welcome to the game!\nWhat is your name?");
            Player player1 = new Player();
            player1.health = 4;
            player1.name = Console.ReadLine();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();
            Console.Clear();
            return player1;
        }

        public static void PickupItem()
        {
            Console.WriteLine($"Congratulations {player1.name}, you are currently alive!\nWhich item would you like to pick up?");
            Console.WriteLine("You can select one of the following items, please select your item by inputing the desired item number.\n1. Flashlight, 2. Stillsuit, 3. Scuba Gear, 4. Bug Spray, 5. Axe, 6. Shovel, 7. Check Inventory, 8. Check Treasure");
            itemSelection_Input = Console.ReadLine();
            itemSelection = int.Parse(itemSelection_Input);
            Console.Clear();
            if (itemSelection == 1 && !Inventory.Contains(items[0].name))
            {
                Inventory.Add(items[0].name);
                Console.WriteLine(items[0].description);
                return;
            }
            if (itemSelection == 2 && !Inventory.Contains(items[1].name))
            {
                Inventory.Add(items[1].name);
                Console.WriteLine(items[1].description);
                return;
            }
            if (itemSelection == 3 && !Inventory.Contains(items[2].name))
            {
                Inventory.Add(items[2].name);
                Console.WriteLine(items[2].description);
                return;
            }
            if (itemSelection == 4 && !Inventory.Contains(items[3].name))
            {
                Inventory.Add(items[3].name);
                Console.WriteLine(items[3].description);
                return;
            }
            if (itemSelection == 5 && !Inventory.Contains(items[4].name))
            {
                Inventory.Add(items[4].name);
                Console.WriteLine(items[4].description);
                return;
            }
            if (itemSelection == 6 && !Inventory.Contains(items[5].name))
            {
                Inventory.Add(items[5].name);
                Console.WriteLine(items[5].description);
                return;
            }
            if (itemSelection == 7)
            {
                foreach (string items in Inventory)
                {
                    Console.WriteLine(items);
                }
                return;
            }
            if (itemSelection == 8)
            {
                foreach (string TreasurePieces in Treasure)
                {
                    Console.WriteLine(TreasurePieces);
                }
                return;
            }
            if (itemSelection <= 0)
            {
                Console.WriteLine($"Hello my name is {ronald.name}, gimme your money");
                
                Console.ReadKey();
                Console.WriteLine("You have lost all your items");
                Console.ReadKey();
                Console.Clear();
                number = random.Next(5);
                Inventory.Remove(items[number].name);
                return;
            }
            else
            {
                Console.ReadKey();
                Inventory.Add("Useless Item");
                Console.WriteLine("You have selected a useless item");
                Console.ReadKey();
                Console.Clear();
                
            }
            
        }

        public static void EnterLocation()
        {
            Console.WriteLine("Congratulations, you have the opportunity to teleport to a new location");
            Console.WriteLine("Where would you like to go?\n1. Cave, 2. Arakkis, 3. Atlantis, 4. Insect Land, 5. Forest, 6. Excavation Site");
            locationSelection_Input = Console.ReadLine();
           // try
            //{
                
                locationSelection = int.Parse(locationSelection_Input);
                Console.Clear();
            //}
           // catch (System.FormatException)
            //{
             //   Console.WriteLine("Please type a number");
              //  Console.ReadKey();
             //   Console.Clear();
        //    }

            

            if (locationSelection == 1)
            {
                if (Inventory.Contains(items[0].name))
                {
                    Console.WriteLine("Description of location");

                    Console.WriteLine("Congratulations, You survived this new location");
                    if (!Treasure.Contains(TreasurePieces[0].piece))
                        {
                        Treasure.Add(TreasurePieces[0].piece);
                        Console.WriteLine("You've obtained treasure: Head of the idol");
                        }
                }
                else
                {
                    Console.WriteLine(locations[0].hazard);
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health --;
                    
                }
            }
            if (locationSelection == 2)
            {
                if (Inventory.Contains(items[1].name))
                {
                    Console.WriteLine("Congratulations, You survived this new location");
                    if (!Treasure.Contains(TreasurePieces[1].piece))
                    {
                        Treasure.Add(TreasurePieces[1].piece);
                        Console.WriteLine("You've obtained treasure: Torso of the idol");
                    }
                }
                else
                {
                    Console.WriteLine(locations[1].hazard);
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health--;
                    
                }
            }
            if (locationSelection == 3)
            {
                if (Inventory.Contains(items[2].name))
                {
                    Console.WriteLine("Congratulations, You survived this new location");
                    if (!Treasure.Contains(TreasurePieces[2].piece))
                    {
                        Treasure.Add(TreasurePieces[2].piece);
                        Console.WriteLine("You've obtained treasure: Left arm of the idol");
                    }
                }
                else
                {
                    Console.WriteLine(locations[2].hazard);
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health--;
                    
                }
            }
            if (locationSelection == 4)
            {
                if (Inventory.Contains(items[3].name))
                {
                    Console.WriteLine("Congratulations, You survived this new location");
                    if (!Treasure.Contains(TreasurePieces[3].piece))
                    {
                        Treasure.Add(TreasurePieces[3].piece);
                        Console.WriteLine("You've obtained treasure: Right arm of the idol");
                    }
                }
                else
                {
                    Console.WriteLine(locations[3].hazard);
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health--;
                    
                }
            }
            if (locationSelection == 5)
            {
                if (Inventory.Contains(items[4].name))
                {
                    Console.WriteLine("Congratulations, You survived this new location");
                    if (!Treasure.Contains(TreasurePieces[4].piece))
                    {
                        Treasure.Add(TreasurePieces[4].piece);
                        Console.WriteLine("You've obtained treasure: Left leg of the idol");
                    }
                }
                else
                {
                    Console.WriteLine(locations[4].hazard);
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health--;

                }
            }
            if (locationSelection == 6)
            {
                if (Inventory.Contains(items[5].name))
                {
                    Console.WriteLine("Congratulations, You survived this new location");
                    if (!Treasure.Contains(TreasurePieces[5].piece))
                    {
                        Treasure.Add(TreasurePieces[5].piece);
                        Console.WriteLine("You've obtained treasure: Right leg of the idol");
                    }
                }
                else
                {
                    Console.WriteLine(locations[5].hazard);
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health--;

                }
            }



            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You have {player1.health} health points remaining");
            Console.ReadKey();
            Console.Clear();
            
        }

        public static void EndGame()
        {
            Console.WriteLine("End Game");
            Console.WriteLine($"Congratulations {player1.name} you completed the game");
            if (player1.health == 0)
            {
                Console.WriteLine("Unfortunately you perished on your journey and must try again");
            }
            else
            {
                Console.WriteLine("Congratulations, you have repaired the mysterious idol. You win!");
                foreach (string TreasurePieces in Treasure)
                {
                    Console.WriteLine(TreasurePieces);
                }
            }

         
        }
    }
}
