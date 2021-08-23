using System;
using System.Threading;

namespace TB_RPG_Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StoryManager storyManager = new StoryManager();
            
            
             Console.WriteLine(storyManager.GetStoryText(1));



             Console.ReadKey();
        }

    }
}