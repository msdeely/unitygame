using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfire : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject bulletPrefab;
    public bool y = false;

    float time2;
    PlayerMovement pm;
    // Start is called before the first frame update

    AudioSource audiosource;

        private void Start()
    {
        pm = gameObject.GetComponent<PlayerMovement>();
        audiosource = GetComponent<AudioSource>();


    }


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && time2 < Time.time)
        {
            audiosource.Play();

            Shoot();
            time2 = Time.time + fireRate;

        }
      
    }

  
        void Shoot()
        {
            
            float curve = pm.isFacingRight ? 0f : 180f;
            Instantiate(bulletPrefab, firingPoint.position, Quaternion.Euler(new Vector3(0f,0f,  curve)));
      
        }
    
}
