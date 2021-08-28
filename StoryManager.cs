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
            
            //0 - Title
            var title = new Story("##################################\n" +
                                  "########   TEXT BASED RPG   #######\n" +
                                  "##################################\n" +
                                  "\n" +
                                  "[0] Settings\n" +
                                  "[1] Start Game\n" +
                                  "[2] Close Game", 0);
            _stories.Add(title);
            //-----------------------------------------------------------------
            //1 - Settings
            var settings = new Story("#########################################\n" +
                                     "###########  SETTINGS ################\n" +
                                     "######################################\n" +
                                     "\n" +
                                     "[0] Language", 1);
            _stories.Add(settings);
            //-----------------------------------------------------------------
            //2- Language Selection
            var languageSelection = new Story("########################################\n" +
                                              "############## LANGUAGE ###############\n" +
                                              "#######################################\n" +
                                              "\n" +
                                              "[0] English\n" +
                                              "[1] Deutsch", 2);
            _stories.Add(languageSelection);
            //-----------------------------------------------------------------
            //3 - Introduction
            var introduction = new Story("#################################. \n" +
                                            "# Welcome to this World.   #\n" +
                                           "# This World will soon be destroyed...  #\n" +
                                           "# That's why you were called into this World.   #\n" +
                                           "# What's your name?         #\n" +
                                            "###################################", 3);
            _stories.Add(introduction);
            //-------------------------------------------------------------------
            //4 - Class Selection
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

        public int DrawSettings()
        {
            Console.WriteLine(GetStoryText(1));
            int input;

            if (int.TryParse(Console.ReadLine(), out input))
            {
                switch (input)
                {
                    case 0:
                        return 0;
                    default:
                        return 10;
                }
            }

            return 10;
        }

        public void DrawIntroduction()
        {
            Console.WriteLine(GetStoryText(1));
            
        }
    }
}