using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuttuki : MonoBehaviour
{
    GameObject centerPos;
    public int  flag = 1;
    public int  spawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        centerPos = GameObject.Find("Sphere-center");
    }


    // Update is called once per frame
    void Update()
    {
        Transform myTransform  = centerPos.transform;
        Vector3 pos = myTransform.position;

        if(flag == 1){
        transform.position = new Vector3(pos.x+2.0f,pos.y,pos.z);
        }
        if(spawn == 1){
            Rigidbody rb = this.GetComponent<Rigidbody>();
            Vector3 force = new Vector3(10.0f,5.0f,0.0f);
            rb.AddForce(force);
            Debug.Log("this is here");
            spawn = 0;
        }
    }

    void Define_force(){
        
    }
}
