using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StickPin {
    public class RotateRepeat : MonoBehaviour {
        public float speed = -90f;
        public bool isStart = true;


        void Update() {
            if (!isStart) {
                return;
            }
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }

        public bool ISInversion() {
            return speed > 0;
        }

        public void SetInversion(bool inversion) {
            if (inversion) {
                speed = -Mathf.Abs(speed);
            }
            else {
                speed = Mathf.Abs(speed);
            }
        }
    }
}