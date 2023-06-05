using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAllComponent : MonoBehaviour
{

    void Start()
    {
        Component[] comps= gameObject.GetComponents<Component>();
        foreach(var comp in comps) {
            Debug.Log(comp);
        }
    }

    void Update()
    {
        
    }
}
