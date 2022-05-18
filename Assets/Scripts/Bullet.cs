using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public AudioSource squashSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);


        if (collision.gameObject.tag == "Despawner")
        {
            
            Destroy(collision.gameObject);
               
         
        }

        if (collision.gameObject.tag == "Fly")
        {
            GameManager.health += 1;
            Destroy(collision.gameObject);
            
        }
    }
    
}
