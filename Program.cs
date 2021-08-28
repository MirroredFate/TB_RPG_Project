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
                    Console.Clear();
                    switch (storyManager.DrawSettings())
                    {
                        case 0:
                            Console.Clear();
                            break;
                    }
                    goto Title;
                case 1:
                    Console.Clear();
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