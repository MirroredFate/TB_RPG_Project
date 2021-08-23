using System.Collections.Generic;

namespace TB_RPG_Project
{
    public class StoryManager
    {
        private List<Story> _stories;

        public StoryManager()
        {
            _stories = new List<Story>();
            
            //1 - Introduction
            Story introduction = new Story("Welcome to this World. \n" +
                                           "This World will soon be destroyed...\n" +
                                           "That's why you were called into this World.\n" +
                                           "What's your name?", 1);
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
    }
}