using UnityEngine;

namespace Models
{
    public class Dragon : Person
    {
        public Dragon(string name, int health) : base(name, health) { }

        // Override of TakeDamage method
        public override void TakeDamage(int damageValue)
        {
            // Reduce health but not below 0
            int newHealth = Mathf.Max(0, Health - damageValue);
            Health = newHealth;

            Debug.Log($"I, the mighty dragon, have lost: {damageValue} hitpoints from a hunter's shot");
        }
    }

}