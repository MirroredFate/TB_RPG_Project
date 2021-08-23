using System;

namespace TB_RPG_Project
{
    public class Player
    {
        private string _playerName;

        private float _currentPlayerHp;
        private float _maxPlayerHp;

        private float _currentPlayerMana;
        private float _maxPlayerMana;
        
        private float _currentPlayerXp;
        private float _maxPlayerXp;

        private int _playerLevel;
        private float _xpLevelIncreaseValue; //Value how much XP needed to lvl up increases per lvl
        
        private Jobs _playerJob;

        private PlayerStats _playerStats;

        public string PlayerName => _playerName;

        public float CurrentPlayerHp => _currentPlayerHp;

        public float MaxPlayerHp => _maxPlayerHp;

        public float CurrentPlayerMana => _currentPlayerMana;

        public float MaxPlayerMana => _maxPlayerMana;

        public float CurrentPlayerXp => _currentPlayerXp;

        public float MaxPlayerXp => _maxPlayerXp;

        public int PlayerLevel => _playerLevel;

        public float XpLevelIncreaseValue => _xpLevelIncreaseValue;

        public Jobs PlayerJob => _playerJob;

        public PlayerStats PlayerStats => _playerStats;

        public Player(string playerName, Jobs playerJob)
        {
            _playerName = playerName;
            _playerJob = playerJob;

            _playerStats = new PlayerStats();

            _maxPlayerHp = 100;
            _currentPlayerHp = _maxPlayerHp;

            _maxPlayerMana = 250;
            _currentPlayerMana = _maxPlayerMana;

            _currentPlayerXp = 0;
            _maxPlayerXp = 100;

            _playerLevel = 1;
            _xpLevelIncreaseValue = 1.03f;
            
            _playerStats.SetBasePlayerStats(_playerJob);
        }
        
        


        
        
    }
}