using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincollision : MonoBehaviour
{
    public int coinvalue = 10;




    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            Destroy(gameObject);
            
            manage.lvl.add(coinvalue);
        }
    }
}
