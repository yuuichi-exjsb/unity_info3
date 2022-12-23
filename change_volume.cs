using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class change_volume : MonoBehaviour
{
    GameObject cube_pos;
    GameObject sphere_pos;
    public int  bgm_vol;
    AudioSource audioSource;
    public float dis;

    /*
    public float pos_x_abs;
    public float pos_z_abs;
    */

    // Start is called before the first frame update
    void Start()
    {
        cube_pos = GameObject.Find("cube");  
        sphere_pos = GameObject.Find("Sphere");
        audioSource = GetComponent<AudioSource>();
        //audioClip = this.AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        Transform cube_Transform  = cube_pos.transform;
        Transform sphere_Transform = sphere_pos.transform;

        Vector3 pos_cube = cube_Transform.position;
        Vector3 pos_sphe = sphere_Transform.position;

        dis = Math.Abs(Vector3.Distance(pos_cube,pos_sphe));

        /*
        pos_x_abs = Math.Abs(pos_cube.x-pos_sphe.x);
        pos_z_abs = Math.Abs(pos_cube.z-pos_sphe.z);
        */

        
        

        if(dis < 5.0f){
           //Debug.Log("get_Space");
            audioSource.volume = 1.0f;
            audioSource.pitch = 2.0f;
        }else{
            audioSource.volume = 0.5f;
            audioSource.pitch = 1.0f;
        }
    }
}
