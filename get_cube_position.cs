using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_cube_position : MonoBehaviour
{
    GameObject cubePos;
    public int  flag = 0;
    // Start is called before the first frame update
    void Start()
    {
        cubePos = GameObject.Find("cube");  
    }

   void OnCollisionEnter(Collision col) {
        if(col.gameObject.name == "cube"){
           flag = 1;
        }
   }
    // Update is called once per frame
    void Update()
    {
        
        if(flag == 1){
        Transform myTransform  = cubePos.transform;

        Transform spherepos = this.transform;
        Vector3 pos = myTransform.position;
        Vector3 pos_sphe = spherepos.position;
        
        //Debug.Log($"(x,y,z) = ({pos.x},{pos.y},{pos.z}");  
        transform.position = new Vector3(pos.x+1.0f,pos.y,pos.z);
        }

        
        if(Input.GetKey(KeyCode.Space)){
            if(flag == 1){
                flag = 0;
            }
        }
        

    }
   
}
