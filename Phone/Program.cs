using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "Sprint", "A sound that can only be described as a lemur with its tail caught in a blender.");
            Nokia brick = new Nokia("Brick", 9001, "no one knows, it carries itself.", "beep. beep. beep. beep. beeeeeeeeeeeeeeeee...");

            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Console.WriteLine("");

            brick.DisplayInfo();
            Console.WriteLine(brick.Ring());
            Console.WriteLine(brick.Unlock());
            Console.WriteLine("");
        }
    }
}
