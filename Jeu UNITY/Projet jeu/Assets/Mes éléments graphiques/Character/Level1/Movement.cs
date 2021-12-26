using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position.x;
     
        if(Input.GetKey(KeyCode.D) )
        {
           transform.Translate(0.01f,0,0);
        }

        if(Input.GetKey(KeyCode.Q) )
        {
             //transform.Rotate(0,180,0);
             transform.Translate(-0.01f,0,0);
             
        }    

        if(Input.GetKey(KeyCode.Z) )
        {
            transform.Translate(0,0.01f,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,-0.01f,0);
        }
        if((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.Q)) || (Input.GetKey(KeyCode.Z)) || (Input.GetKey(KeyCode.S)))
        {
            anim.SetBool("IsRunning",true);
        }else {anim.SetBool("IsRunning",false);}
        
    }
}
