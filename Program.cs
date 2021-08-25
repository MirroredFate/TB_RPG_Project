using System;

namespace TB_RPG_Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StoryManager storyManager = new StoryManager();
            
            Title:
            switch (storyManager.DrawTitle())
            {
                case 0:
                    Console.WriteLine("Wrong Input. Please enter 1 or 2.\n" +
                                      "Press any Key to return");
                    Console.ReadKey();
                    Console.Clear();
                    goto Title;
                case 1:
                    storyManager.DrawIntroduction();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            

            Console.ReadKey();
        }

        
    }
}