using UnityEngine;

// This script detects collisions with objects tagged "Enemy"
namespace Runtime.Player
{
    [RequireComponent(typeof(Rigidbody), typeof(Collider))]
    public class PlayerCollision : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            // Check if the other object has tag "Enemy"
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Player has collided with Enemy!");
            }
        }
    }
}
