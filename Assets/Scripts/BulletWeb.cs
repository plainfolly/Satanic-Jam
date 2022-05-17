using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWeb : MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.1f);
        Destroy(gameObject);

        if (collision.gameObject.tag == "Heart")
        {
            GameManager.health += 1;
            Destroy(collision.gameObject);
        }
    }
    
}
