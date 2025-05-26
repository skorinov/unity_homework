using UnityEngine;

namespace Models
{
    public class Player : Person
    {
        private int _experience;

        public Player(string name, int health, int experience) : base(name, health)
        {
            _experience = experience;
        }

        public int Experience => _experience;

        public override void ShowStat()
        {
            Debug.Log("Name: " + Name + ", Experience: " + Experience);
        }

        // Override of TakeDamage method
        public override void TakeDamage(int damageValue)
        {
            // Reduce health but not below 0
            int newHealth = Mathf.Max(0, Health - damageValue);
            Health = newHealth;

            Debug.Log($"My name is {Name}: After hitting with force: {damageValue} I have: health {Health}");
        }
    }

}