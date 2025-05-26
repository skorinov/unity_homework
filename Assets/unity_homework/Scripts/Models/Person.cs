using UnityEngine;

namespace Models
{
    public abstract class Person
    {
        private string _name;
        private int _health;

        protected Person(string name, int health)
        {
            _name = name;
            Health = health;
        }

        public string Name => _name;

        public int Health
        {
            get => _health;
            set
            {
                if (value < 0 || value > 100)
                {
                    Debug.Log("Health must be between 0 and 100.");
                }
                else
                {
                    _health = value;
                }
            }
        }
        
        public virtual void ShowStat()
        {
            Debug.Log("Name: " + _name);
        }

        // Abstract method for taking damage
        public abstract void TakeDamage(int damageValue);
    }
}