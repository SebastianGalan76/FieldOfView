using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Player {
    public class Rotation : MonoBehaviour {
        [SerializeField] private new Camera camera;

        private void Update() {
            Vector3 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
            Vector3 playerPosition = transform.position;

            transform.rotation = Quaternion.LookRotation(
                Vector3.forward,
                mousePosition - playerPosition
            );
        }
    }
}
