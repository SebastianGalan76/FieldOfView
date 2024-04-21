using UnityEngine;

namespace Player {
    public class Movement : MonoBehaviour {
        [SerializeField] private float speed = 3.5f;

        private Rigidbody2D rb;

        private void Awake() {
            rb = GetComponent<Rigidbody2D>();
        }
        private void Update() {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);

            rb.velocity = movement * speed;
        }
    }

}