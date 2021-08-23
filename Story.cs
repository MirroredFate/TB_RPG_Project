namespace TB_RPG_Project
{
    public struct Story
    {
        private readonly string _storyText;
        private int _storyId;
        
        public Story(string storyText, int storyId)
        {
            _storyText = storyText;
            _storyId = storyId;
        }

        public string StoryText => _storyText;

        public int StoryId => _storyId;
    }
}