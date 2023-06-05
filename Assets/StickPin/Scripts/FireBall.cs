using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject pinPrefab;
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Debug.Log("Touch Down");
            SpawnPin();
            
        }
    }

    void SpawnPin() {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
