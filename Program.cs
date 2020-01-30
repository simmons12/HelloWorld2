using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Do you like One Piece? Who's your favorite character?");

            string OnePiece = "Zoro";

            Console.WriteLine(OnePiece);

            if (OnePiece == "Zoro")
            {
                Console.WriteLine("Ah you like the swordsman! Pretty cool man.");
            }
            else if (OnePiece == "Luffy")
            {
                Console.WriteLine("Ah you're a fan of the captain, nice!");
            }
            else if (OnePiece == "Sanji")
            {
                Console.WriteLine("The cook is your favorite, huh? Interesting.");
            }
            else
            {
                Console.WriteLine("That's a weird choice. Just kidding!");
            }
        }
    }
}
