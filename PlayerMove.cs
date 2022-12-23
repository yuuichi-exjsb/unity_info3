using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.03f;
        }
 
        if(Input.GetKey("down"))
        {
            transform.position += transform.forward * -0.03f;
        }
        if(Input.GetKey("right"))
        {
            transform.position += transform.right * 0.03f;
        }
 
        if(Input.GetKey("left"))
        {
            transform.position += transform.right * -0.03f;
        }
    }
}
