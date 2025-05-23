using UnityEngine;

// This script allows the player to move in 4 directions using the keyboard
namespace Runtime.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        // Movement speed in units per second
        [SerializeField] private float moveSpeed = 5f;
        // Reference to the Rigidbody component
        private Rigidbody _rb;

        private void Awake()
        {
            // Cache the Rigidbody component
            _rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            // Read input axes for horizontal (A/D) and vertical (W/S)
            float horizontal = Input.GetKey(KeyCode.A) ? -1f : Input.GetKey(KeyCode.D) ? 1f : 0f;
            float vertical = Input.GetKey(KeyCode.W) ?  1f : Input.GetKey(KeyCode.S) ? -1f : 0f;

            // Create movement vector
            Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized * moveSpeed;

            // Move the Rigidbody to the new position
            _rb.MovePosition(_rb.position + movement * Time.fixedDeltaTime);
        }
    }
}
