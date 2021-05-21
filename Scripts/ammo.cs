using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bullet = 20f;
    

    // Start is called before the first frame update
    private void FixedUpdate()
    {
   
            rb.velocity = transform.right * bullet;
        }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

