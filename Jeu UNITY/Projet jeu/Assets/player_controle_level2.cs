using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controle_level2 : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;

    private bool isJumping;
    private float move;
    private Rigidbody2D rb;
    private Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if(move < 0) transform.eulerAngles = new Vector3(0, 180, 0);
        else if(move > 0) transform.eulerAngles = new Vector3 (0,0,0);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJumping = true;
        }
        RunAnimation();
    }

    private void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.CompareTag("Ground")) 
        {
          isJumping = false;
        }
        
    }

    void RunAnimation()
    {
        Debug.Log("running");
        anim.SetFloat("Movement", Mathf.Abs(move));
        anim.SetBool("Jumping", isJumping);
    }
}
