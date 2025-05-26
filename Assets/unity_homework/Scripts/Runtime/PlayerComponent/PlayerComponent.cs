using UnityEngine;
using Models;

namespace Runtime.PlayerComponent
{
    public class PlayerComponent : MonoBehaviour
    {
        private void Start()
        {
            Player player = new Player("Arthur", 90, 500);
            player.Health = 500;
            player.ShowStat();
            player.TakeDamage(25);
        }
    }
}
