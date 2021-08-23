using System;

namespace TB_RPG_Project
{
    public class PlayerStats
    {
        private bool _areStatsInitialized = false;
        
        private int _baseStrength;
        private int _baseStamina;
        private int _baseWisdom;
        private int _baseDexterity;
        private int _baseIntelligence;
        
        private int _strength;
        private int _stamina;
        private int _wisdom;
        private int _dexterity;
        private int _intelligence;

        public int BaseStrength => _baseStrength;

        public int BaseStamina => _baseStamina;

        public int BaseWisdom => _baseWisdom;

        public int BaseDexterity => _baseDexterity;

        public int BaseIntelligence => _baseIntelligence;


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


        public void SetBasePlayerStats(Jobs playerJob)
        {
            switch (playerJob)
            {
                case Jobs.Warrior:
                    _baseStrength = 3;
                    _baseStamina = 2;
                    _baseWisdom = 0;
                    _baseDexterity = 1;
                    _baseIntelligence = 0;
                    break;
                case Jobs.Paladin:
                    _baseStrength = 2;
                    _baseStamina = 2;
                    _baseWisdom = 1;
                    _baseDexterity = 1;
                    _baseIntelligence = 0;
                    break;
                case Jobs.Ninja:
                    _baseStrength = 1;
                    _baseStamina = 2;
                    _baseWisdom = 0;
                    _baseDexterity = 3;
                    _baseIntelligence = 0;
                    break;
                case Jobs.Archer:
                    _baseStrength = 0;
                    _baseStamina = 1;
                    _baseWisdom = 0;
                    _baseDexterity = 5;
                    _baseIntelligence = 0;
                    break;
                case Jobs.Mage:
                    _baseStrength = 0;
                    _baseStamina = 1;
                    _baseWisdom = 2;
                    _baseDexterity = 0;
                    _baseIntelligence = 3;
                    break;
                case Jobs.Druid:
                    _baseStrength = 0;
                    _baseStamina = 2;
                    _baseWisdom = 2;
                    _baseDexterity = 0;
                    _baseIntelligence = 2;
                    break;
                case Jobs.Priest:
                    _baseStrength = 0;
                    _baseStamina = 2;
                    _baseWisdom = 3;
                    _baseDexterity = 0;
                    _baseIntelligence = 1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(playerJob), playerJob, null);
            }

            if (!_areStatsInitialized)
            {
                Strength = _baseStrength;
                Stamina = _baseStamina;
                Wisdom = _baseWisdom;
                Dexterity = _baseDexterity;
                Intelligence = _baseIntelligence;
                
                _areStatsInitialized = true;
            }
        }
    }
}