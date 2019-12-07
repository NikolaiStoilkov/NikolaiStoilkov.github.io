using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vars
            int[] xPosition = new int[50];
            xPosition[0] = 35; // 14:06

            int[] yPosition = new int[50];
            yPosition[0] = 20;
            int appleXDim = 10;
            int appleYDim = 10;
            int applesEaten = 0;

            string userAction = string.Empty;

            decimal gameSpeed = 150m;

            bool isGameOn = true;
            bool isWallHit = false;
            bool isAppleEaten = false;
            bool isStayInMenu = true;

            Random random = new Random();

            Console.CursorVisible = false;
            #endregion

            // Build Welcome screen
            ShowMenu(out userAction);

            switch (userAction)
            {
                // Give Player option to read directions.
                #region Case Directions
                case "1":
                case "d":
                case "directions":
                    Console.Clear();
                    BuildWall();
                    Console.SetCursorPosition(5,5);
                    Console.WriteLine("1) Resize the console window so you can see all");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("     4 sides of playing field boarder.");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("2) Use the arrow keys to move the snake around the field.");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("3) The snake will die if it runs into the wall.");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("4) You gain points by eating apples.");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("     but your snake will also go faster and get longer");
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("Press enter to return to main menu.");
                    Console.ReadLine();
                    Console.Clear();
                    ShowMenu(out userAction);
                    break;
#endregion

                #region Case Play
                case "2":
                case "p":
                case "play":
                    Console.Clear();
                    #region Game Setup
                    // Get the snake to appear on screen

                    PaintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);
                    //Console.SetCursorPosition(xPosition[0], yPosition[0]);
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    //Console.WriteLine((char)214);

                    // Set apple on screen
                    SetApplePositionOnScreen(random, out appleXDim, out appleYDim);
                    PaintApple(appleXDim, appleYDim);


                    // Build boundary
                    BuildWall();


                    ConsoleKey command = Console.ReadKey().Key;

                    #endregion

                    do
                    {
                        #region Change Directions

                        switch (command)
                        {
                            case ConsoleKey.LeftArrow:
                                Console.SetCursorPosition(xPosition[0], yPosition[0]);
                                Console.Write(" ");
                                xPosition[0]--;
                                break;

                            case ConsoleKey.UpArrow:
                                Console.SetCursorPosition(xPosition[0], yPosition[0]);
                                Console.Write(" ");
                                yPosition[0]--;
                                break;

                            case ConsoleKey.RightArrow:
                                Console.SetCursorPosition(xPosition[0], yPosition[0]);
                                Console.Write(" ");
                                xPosition[0]++;
                                break;

                            case ConsoleKey.DownArrow:
                                Console.SetCursorPosition(xPosition[0], yPosition[0]);
                                Console.Write(" ");
                                yPosition[0]++;
                                break; ;

                        }

                        #endregion

                        #region Playing game
                        //Paint the snake
                        PaintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);



                        isWallHit = DidSnakeHitWall(xPosition[0], yPosition[0]);
                        if (isWallHit)
                        {
                            isGameOn = false;
                            Console.SetCursorPosition(28, 20);
                            Console.WriteLine("The snake hot the wall and died!");

                            // show score
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(15, 21);
                            Console.Write("Your score is " + applesEaten * 100 + "!");
                            Console.SetCursorPosition(15, 22);
                            Console.WriteLine("Press Enter To Continue.");
                            applesEaten = 0;
                            Console.ReadLine();
                            Console.Clear();


                            // give player to replay the game 
                            ShowMenu(out userAction);
                        }

                        // Detect when apple was eaten
                        isAppleEaten = DetermineIfAppleWasEaten(xPosition[0], yPosition[0], appleXDim, appleYDim);

                        // place apple on board (random)
                        if (isAppleEaten)
                        {
                            SetApplePositionOnScreen(random, out appleXDim, out appleYDim);
                            PaintApple(appleXDim, appleYDim);

                            // keep track of how many apples eaten.

                            // make snake longer
                            applesEaten++;

                            // make snake faster
                            gameSpeed *= .925m;
                        }

                        if (Console.KeyAvailable)
                        {
                            command = Console.ReadKey().Key;
                        }

                        // Slow the game down
                        System.Threading.Thread.Sleep(Convert.ToInt32(gameSpeed));

                        #endregion

                    } while (isGameOn);
                    break;
                #endregion

                case "3":
                case "e":
                case "exit":
                    bool menu = isStayInMenu;
                    menu = false;
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Your input was not understood,please press enter and try again.");
                    Console.ReadLine();
                    Console.Clear();
                    ShowMenu(out userAction);
                    break;
            }
            
        }



        #region Methods

        #region Menu
        private static void ShowMenu(out string userAction)
        {
            string menu1 = "1) Directions\n 2)Play\n 3)Exit \n\n\n" + @"


























       ---_ ......._-_--.
      (|\ /      / /| \  \
      /  /     .'  -=-'   `.
     /  /    .'             )
   _/  /   .'        _.)   /
  / o   o        _.-' /  .'
  \          _.-'    / .'*|
   \______.-'//    .'.' \*|
    \|  \ | //   .'.' _ |*|
     `   \|//  .'.'_ _ _|*|
      .  .// .'.' | _ _ \*|
      \`-|\_/ /    \ _ _ \*\
       `/'\__/      \ _ _ \*\
      /^|            \ _ _ \*
     '  `             \ _ _ \     
                       \_



";
            string menu2 = "1) Directions\n 2)Play\n 3)Exit \n\n\n" + @"




















       ---_ ......._-_--.
      (|\ /      / /| \  \
      /  /     .'  -=-'   `.
     /  /    .'             )
   _/  /   .'        _.)   /
  / o   o        _.-' /  .'
  \          _.-'    / .'*|
   \______.-'//    .'.' \*|
    \|  \ | //   .'.' _ |*|
     `   \|//  .'.'_ _ _|*|
      .  .// .'.' | _ _ \*|
      \`-|\_/ /    \ _ _ \*\
       `/'\__/      \ _ _ \*\
      /^|            \ _ _ \*
     '  `             \ _ _ \     
                       \_

";
            string menu3 = "1) Directions\n 2)Play\n 3)Exit \n\n\n" + @"















       ---_ ......._-_--.
      (|\ /      / /| \  \
      /  /     .'  -=-'   `.
     /  /    .'             )
   _/  /   .'        _.)   /
  / o   o        _.-' /  .'
  \          _.-'    / .'*|
   \______.-'//    .'.' \*|
    \|  \ | //   .'.' _ |*|
     `   \|//  .'.'_ _ _|*|
      .  .// .'.' | _ _ \*|
      \`-|\_/ /    \ _ _ \*\
       `/'\__/      \ _ _ \*\
      /^|            \ _ _ \*
     '  `             \ _ _ \     
                       \_

";
            string menu4 = "1) Directions\n 2)Play\n 3)Exit \n\n\n" + @"










       ---_ ......._-_--.
      (|\ /      / /| \  \
      /  /     .'  -=-'   `.
     /  /    .'             )
   _/  /   .'        _.)   /
  / o   o        _.-' /  .'
  \          _.-'    / .'*|
   \______.-'//    .'.' \*|
    \|  \ | //   .'.' _ |*|
     `   \|//  .'.'_ _ _|*|
      .  .// .'.' | _ _ \*|
      \`-|\_/ /    \ _ _ \*\
       `/'\__/      \ _ _ \*\
      /^|            \ _ _ \*
     '  `             \ _ _ \     
                       \_

";
            string menu5 = "1) Directions\n 2)Play\n 3)Exit \n\n\n" + @"





       ---_ ......._-_--.
      (|\ /      / /| \  \
      /  /     .'  -=-'   `.
     /  /    .'             )
   _/  /   .'        _.)   /
  / o   o        _.-' /  .'
  \          _.-'    / .'*|
   \______.-'//    .'.' \*|
    \|  \ | //   .'.' _ |*|
     `   \|//  .'.'_ _ _|*|
      .  .// .'.' | _ _ \*|
      \`-|\_/ /    \ _ _ \*\
       `/'\__/      \ _ _ \*\
      /^|            \ _ _ \*
     '  `             \ _ _ \     
                       \_

";


            Console.WriteLine(menu1);
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(menu2);
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(menu3);
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(menu4);
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(menu5);
            System.Threading.Thread.Sleep(100);



            userAction = Console.ReadLine().ToLower();
        }
        #endregion
        private static void PaintSnake(int applesEaten, int[] xPositionIn, int[] yPositionIn, out int[] xPositionOut, out int[] yPositionOut)
        {
            // Paint the head
            Console.SetCursorPosition(xPositionIn[0], yPositionIn[0]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)214);


            // Paint the body
            for (int i = 1; i < applesEaten + 1; i++)
            {
                Console.SetCursorPosition(xPositionIn[i], yPositionIn[i]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("o");
            }

            // Erase last part of snake
            Console.SetCursorPosition(xPositionIn[applesEaten + 1], yPositionIn[applesEaten + 1]);
            Console.WriteLine(" ");


            // Record location of each body part
            for (int i = applesEaten + 1; i > 0; i--)
            {
                xPositionIn[i] = xPositionIn[i - 1];
                yPositionIn[i] = yPositionIn[i - 1];
            }

            // Return new array

            xPositionOut = xPositionIn;
            yPositionOut = yPositionIn;
        }


        private static bool DetermineIfAppleWasEaten(int xPosition, int yPosition, int appleXDim, int appleYDim)
        {
            if (xPosition == appleXDim && yPosition == appleYDim)
            {
                return true;
            }

            return false;
        }

        private static void PaintApple(int appleXDim, int appleYDim)
        {
            Console.SetCursorPosition(appleXDim, appleYDim);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write((char)64);
        }

        private static void SetApplePositionOnScreen(Random random, out int appleXDim, out int appleYDim)
        {
            appleXDim = random.Next(0 + 2, 70 - 2);
            appleYDim = random.Next(0 + 2, 40 - 2);
        }

        private static bool DidSnakeHitWall(int xPosition, int yPosition)
        {
            if (xPosition == 1 || xPosition == 70 || yPosition == 1 || yPosition == 40)
            {
                return true;
            }

            return false;
        }

        private static void BuildWall()
        {
            for (int i = 1; i < 41; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, i);
                Console.Write("#");
                Console.SetCursorPosition(70, i);
                Console.Write("#");
            }

            for (int i = 0; i < 71; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, 1);
                Console.Write("#");
                Console.SetCursorPosition(i, 40);
                Console.Write("#");
            }
        }
        #endregion
    }
}
