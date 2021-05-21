using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class manage : MonoBehaviour
{
    public static manage lvl;

    public Transform respawn;
    public GameObject player;

    public float death = -10f;
    public CinemachineVirtualCameraBase b;


    [Header("Coin")]
    public int coin = 0;
    public Text coinUI;

    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.position = respawn.position;

        }

    
    }


    private void Awake()
    {

        lvl = this;
   
    }


    public void Respawn() {
        GameObject p = Instantiate(player, respawn.position, Quaternion.identity);
        b.Follow = p.transform;
        coin = 0;
        coinUI.text = "Points:" + coin;


    }


    public void add(int amt)
    {
        coin += amt;
        coinUI.text = "Points:" + coin;
    }
    
}
