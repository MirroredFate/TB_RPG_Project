using System;
using System.Collections.Generic;

namespace TB_RPG_Project
{
    public class StoryManager
    {
        private List<Story> _stories;

        public StoryManager()
        {
            _stories = new List<Story>();
            
            //Adding all Stories
            
            //Title
            var title = new Story("##################################\n" +
                                  "########   TEXT BASED RPG   #######\n" +
                                  "##################################\n" +
                                  "\n" +
                                  "[1] Start Game\n" +
                                  "[2] Close Game", 0);
            _stories.Add(title);
            
            //1 - Introduction
            var introduction = new Story("#################################. \n" +
                                            "# Welcome to this World.   #\n" +
                                           "# This World will soon be destroyed...  #\n" +
                                           "# That's why you were called into this World.   #\n" +
                                           "# What's your name?         #\n" +
                                            "###################################", 1);
            _stories.Add(introduction);
            
            //2 - Class Selection
        }

        public string GetStoryText(int id)
        {
            foreach (var story in _stories)
            {
                if (story.StoryId == id)
                {
                    return story.StoryText;
                }
            }

            return "";
        }

        public int DrawTitle()
        {
            Console.WriteLine(GetStoryText(0));
            int input;

            if (int.TryParse(Console.ReadLine(), out input))
            {
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        return 1;
                    case 2:
                        Console.Clear();
                        return 2;
                    default:
                        return 0;
                }
            }

            return 0;
        }

        public void DrawIntroduction()
        {
            Console.WriteLine(GetStoryText(1));
            
        }
    }
}