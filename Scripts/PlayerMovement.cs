using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public LayerMask groundLayers;
    public float movementSpeed;
    public float jumpForce = 20f;
    bool isGrounded;
    public Transform feet;
    float direction;
    [HideInInspector] public bool isFacingRight = true;
 
    private void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded()){
            Jump();
        }
    
       
        if(direction > 0f){
            transform.localScale = new Vector3(1f, 1f, 1f);
            isFacingRight = true;
        }else if(direction < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            isFacingRight = false;
        }

    }
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(direction * movementSpeed, rb.velocity.y);
        rb.velocity = movement;

      

    }


    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement; 
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);
        if(groundCheck != null)
        {
            return true;
        }
        return false; 
    }

 

    // Update is called once per frame

}
