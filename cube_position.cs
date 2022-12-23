using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_position : MonoBehaviour
{
    public kuttuki kt_script;
    public int sum_col = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.name == "Cube"){
           if(sum_col == 0){
           kt_script.flag = 0;
           kt_script.spawn = 1;
           }
           sum_col += 1;
           Debug.Log("Hit!!!!!!!!!!!!!");
           Debug.Log(kt_script.spawn);
        }
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
        if(Input.GetKey(KeyCode.Space)){
            transform.position += transform.up * -0.03f;
        }
        if(Input.GetKey(KeyCode.Tab)){
            transform.position += transform.up * 0.03f;
        }
    }
}
