namespace TB_RPG_Project
{
    public class PlayerStats
    {
        public int Strength
        {
            get => _strength;
            set => _strength = value;
        }

        public int Stamina
        {
            get => _stamina;
            set => _stamina = value;
        }

        public int Wisdom
        {
            get => _wisdom;
            set => _wisdom = value;
        }

        public int Dexterity
        {
            get => _dexterity;
            set => _dexterity = value;
        }

        public int Intelligence
        {
            get => _intelligence;
            set => _intelligence = value;
        }

        private int _strength;
        private int _stamina;
        private int _wisdom;
        private int _dexterity;
        private int _intelligence;
    }
}