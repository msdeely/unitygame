using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerrespawn : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            manage.lvl.Respawn();
        }
        if (collision.gameObject.CompareTag("End"))
        {
            Debug.Log("GAME OVER");
        }


    void Restart ()
        {
            SceneManager.LoadScene("Scene2");
        }

      
    }




}
