using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObj : MonoBehaviour
{
    public GameObject gameObject;
 
    void OnCollisionEnter(Collision col) {
        if(col.gameObject.name == "cube"){
            transform.SetParent(gameObject.transform);
        }
    }
}
