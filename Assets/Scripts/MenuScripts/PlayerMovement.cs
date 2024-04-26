using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public Animator anim;
    public float moveSpeed;
    public float x, y;
    public bool isWalking;
    private Vector2 moveDir;
    public FixedJoystick joystick;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //x = Input.GetAxisRaw("Horizontal");
        //y = Input.GetAxisRaw("Vertical");

        float x = joystick.Horizontal;
        float y = joystick.Vertical;
        
        if (x != 0 || y != 0)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);

            if (!isWalking)
            {
                isWalking = true;
                anim.SetBool("IsMoving", isWalking);
                
            }
        }
        else
        {
            if (isWalking)
            {
                isWalking = false;
                anim.SetBool("IsMoving", isWalking);
                StopMoving();
            }
        }

        moveDir = new Vector3(x, y).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity =  moveSpeed * Time.deltaTime * moveDir;
    }

    public void StopMoving()
    {
        rb.velocity = Vector2.zero;
    }
    
}
