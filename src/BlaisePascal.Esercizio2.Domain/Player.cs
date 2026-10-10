namespace BlaisePascal.Esercizio2.Domain
{
    public class Player
    {
        private string _name;
        private int _level;
        private int _expirience;
        private int _health;
        private int _maxHealt;
        private bool _isAlive;
        private int _gold;

        public string Name
        {
            get { return _name; }
            set
            {
                require(!(value.IsWhiteSpace()));
                _name = value;
            }
        }

        public int Level
        {
            get { return _level; }
            private set
            {
                require(value >= 0);
                _level = value;
            }
        }

        public int Expirience
        {
            get { return _expirience; }
            private set
            {
                require(value >= 0);
                _expirience = value;
            }
        }

        public int Health
        {
            get { return _health; }
            private set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > _maxHealt)
                {
                    _health = _maxHealt;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public int MaxHealth
        {
            get { return _maxHealt; }
            private set
            {
                require(value >= 0);
                _maxHealt = value;
            }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
            private set
            {
                _isAlive = value;
            }
        }

        public int Gold
        {
            get { return _gold; }
            private set
            {
                require(value >= 0);
                _gold = value;
            }
        }

        public Player(string name)
        {
            Name = name;
            Level = 1;
            Expirience = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }

        public void AddExpirience(int amout)
        {
            require(amout >= 0);
            Expirience += amout;
            if (Expirience > 100)
            {
                Level++;
                Expirience -= 100;
            }
        }

        public void ResetExpirience()
        {
            Expirience = 0;
        }

        public void TakeDamage(int amout)
        {
            require(amout >= 0);
            Health -= amout; ;
            if (Health == 0) { IsAlive = false; }
        }

        public void Heal(int amout)
        {
            require(amout >= 0);
            Health += amout;
        }

        public void AddGold(int amout)
        {
            require(amout >= 0);
            Gold += amout;
        }

        public void ResetHealth()
        {
            Health = MaxHealth;
            IsAlive = true;
        }

        private void require(bool value)
        {
            if (!value)
            {
                throw new ArgumentException();
            }
        }
    }
}
