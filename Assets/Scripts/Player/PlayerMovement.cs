using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed, jumpForce;

    Vector2 movement;

    Rigidbody2D playerRB;
    Animator playerAnim;
    SpriteRenderer playerSR;

    bool grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!PlayerController.isDead)
        {
            //if (Mathf.Abs(movement.x) > 0f)
            //{
            //    movement.y = 0;
            //}
            playerRB.velocity = new Vector2(movement.x * speed, playerRB.velocity.y);
        }
        else
        {
            playerRB.velocity = Vector2.zero;
        }
        if(grounded && Input.GetKey(KeyCode.W))
        {
            grounded = false;
            playerRB.AddForce(new Vector2(0f, jumpForce));
        }
    }

    private void Update()
    {
        SetAnim();
        if (!PlayerController.isDead)
        {
            SetDirection(); 
        }
        
    }

    void SetAnim()
    {
        if (!PlayerController.isDead)
        {
            if (playerRB.velocity != Vector2.zero)
            {
                playerAnim.SetBool("IsRun", true);
            }
            else
            {
                playerAnim.SetBool("IsRun", false);
            }
        }
        else
        {
            playerAnim.SetBool("IsDead", PlayerController.isDead);
        }
    }

    void SetDirection()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            playerSR.flipX = true;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            playerSR.flipX = false;
        }
    }

    void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
}
/*
Vector2.right = 1 , 0
Vector2.left = -1 , 0
Vector2.up = 0 , 1
Vector2.down = 0 , -1
Vector2.one = 1 , 1
Vector2.zero = 0 , 0
 */