using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Circular : MonoBehaviour
{

    public float speed = Mathf.PI/10;
    private float radius = 4.0f;
    private float a = 0;
    private float x = 3.0f;
    private float z = 3.0f;




    // Update is called once per frame
    void Update()
    {

        a += speed * Time.deltaTime;
        
        x = radius * Mathf.Sin(a) ;
        z = radius * Mathf.Cos(a)  ;

        transform.position = new Vector3(x, 0.5f, z);

    }
}
