namespace TB_RPG_Project
{
    public class GameSettings
    {
        private Language gameLanguage;
        
        public Language GameLanguage
        {
            get => gameLanguage;
            set => gameLanguage = value;
        }

        public GameSettings()
        {
            GameLanguage = Language.English;
        }
    }
}