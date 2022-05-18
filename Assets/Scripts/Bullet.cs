using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject score;
    public int EnemyScore = 10;
    public int FireflyScore = 20;


    void Start()
    {
        score = GameObject.FindWithTag("Score");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
       

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            score.GetComponent<Score>().increaseScore(EnemyScore);
           
        }

        if (collision.gameObject.tag == "Firefly")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            score.GetComponent<Score>().increaseScore(FireflyScore);
        }

        if (collision.gameObject.tag == "Fly")
        {
            GameManager.health += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    
}
