using Models;
using UnityEngine;

public class DragonComponent : MonoBehaviour
{
    private void Start()
    {
        Dragon dragon = new Dragon("Smaug", 100);
        dragon.ShowStat();
        dragon.TakeDamage(40);
    }
}
