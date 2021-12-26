using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_level1 : MonoBehaviour
{
     private Animator anime;
     public float speed;

    void Start()
    {
        
        anime = GetComponent<Animator>();
    }

    void Update()
    {
        
        if(Input.GetKey(KeyCode.D) )
        {
           GetComponent<SpriteRenderer>().flipX = false;
           transform.Translate(speed,0,0);
        }
        if(Input.GetKey(KeyCode.Q) )
        {
             GetComponent<SpriteRenderer>().flipX = true;
             transform.Translate(-speed,0,0);
        }
        if(Input.GetKey(KeyCode.Z) )
        {
            transform.Translate(0,speed,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,-speed,0);
        }
    }

}
