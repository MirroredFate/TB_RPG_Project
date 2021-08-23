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

        public Player(string playerName, Jobs playerJob)
        {
            _playerName = playerName;
            _playerJob = playerJob;

            _maxPlayerHp = 100;
            _currentPlayerHp = _maxPlayerHp;

            _maxPlayerMana = 250;
            _currentPlayerMana = _maxPlayerMana;

            _currentPlayerXp = 0;
            _maxPlayerXp = 100;

            _playerLevel = 1;
            _xpLevelIncreaseValue = 1.03f;
        }
        
        
    }
}