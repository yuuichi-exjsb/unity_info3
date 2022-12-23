using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    AudioSource audio;
    float force  = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Break(){
        foreach(Transform part in GetComponentInChildren<Transform>()){
            ExplodePart(part,force);
        }
        Destroy(gameObject,10f);
    }

    private void ExplodePart(Transform part, float force){
        part.transform.parent = null;
        Rigidbody rb = part.gameObject.AddComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.useGravity = true;
        rb.AddExplosionForce(force,Vector3.zero,0f);
        //Destroy(part.gameObject,10f);
    }

    private void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "floor"){
            audio.Play();
            Break();
        }
    }
}
