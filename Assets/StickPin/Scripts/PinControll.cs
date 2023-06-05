using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StickPin {
    public class PinControll : MonoBehaviour {
        public float speed = 20.0f;
        private Rigidbody2D rigidbody2d;

        private bool isGameover = false;

        public Vector3 targetPosition;
        public float Dis;

        private void Awake() {
            rigidbody2d = GetComponent<Rigidbody2D>();
        }


        void Start() {
            rigidbody2d.velocity = Vector2.up * speed;
        }

        private void FixedUpdate() {
            //var distance = Vector3.Distance(targetPosition, gameObject.transform.position);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if (collision.tag == "Finish") {
                LinkPin(collision.gameObject);

            }
            if (collision.tag == "Player") {
                GameManager.instace.GameOver();
            }
        }

        private void LinkPin(GameObject go) {
            rigidbody2d.velocity = Vector2.zero;
            transform.parent = go.transform;
            GameManager.instace.LinkSuccess();
            //go.SendMessage("AddScore");
            //if (Random.Range(0.0f, 1f) > 0.5f) {
            //    go.GetComponent<RotatorModel>().speed *= -1;
            //}
        }

    }
}
