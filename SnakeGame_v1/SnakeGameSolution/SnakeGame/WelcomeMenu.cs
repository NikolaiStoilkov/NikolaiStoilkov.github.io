using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMenuOf
{
    class WelcomeMenu
    {
        #region Menu
        public void ShowMenu(out string userAction)
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
 \
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
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(menu2);
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(menu3);
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(menu4);
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(menu5);
            System.Threading.Thread.Sleep(500);



            userAction = Console.ReadLine().ToLower();
        }
        #endregion
    }
}
