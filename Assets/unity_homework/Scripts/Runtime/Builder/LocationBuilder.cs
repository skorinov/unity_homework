using Runtime.Player;
using UnityEngine;

namespace Runtime.Builder
{
    public class LocationBuilder : MonoBehaviour
    {
        [Header("Materials")]
        public Material playerMaterial;
        public Material enemyMaterial;
        private void Start()
        {
            CreatePlayer();
            CreateEnemy();
        }

        private void CreatePlayer()
        {
            // Create a Capsule primitive
            GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            player.name = "ScriptPlayer";
            // Apply player material
            var playerRend = player.GetComponent<Renderer>();
            if (playerMaterial != null)
                playerRend.material = playerMaterial;
            else
                Debug.LogWarning("PlayerMaterial not assigned in LocationBuilder!");
            Rigidbody rb = player.AddComponent<Rigidbody>();
            // Freeze X and Z rotation so capsule stays upright
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            player.AddComponent<PlayerCollision>();
            player.tag = "Player";
            // Position it slightly above the floor
            player.transform.position = new Vector3(0f, 2f, 0f);
        }

        private void CreateEnemy()
        {
            // Create a Capsule primitive
            GameObject enemy = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            enemy.name = "ScriptEnemy";
            // Apply enemy material
            var enemyRend = enemy.GetComponent<Renderer>();
            if (enemyMaterial != null)
            {
                enemyRend.material = enemyMaterial;
            }
            else
            {
                Debug.LogWarning("EnemyMaterial not assigned in LocationBuilder!"); 
            }
            
            Rigidbody rb = enemy.AddComponent<Rigidbody>();
            rb.useGravity = true;
            rb.linearDamping = 5f;
            enemy.tag = "Enemy";

            // Position high above the floor so we can see the slow fall
            enemy.transform.position = new Vector3(2f, 10f, 0f);
        }
    }
}