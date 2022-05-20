using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffectEnemy;
    public GameObject hitEffectFly;
    public GameObject hitEffectFirefly;
    public GameObject score;
    public int EnemyScore = 10;
    public int FireflyScore = 20;
    

    void Start()
    {
        score = GameObject.FindWithTag("Score");

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GetComponent<AudioSource>().Play();
      
        //Destroy(gameObject);
       

        if (collision.gameObject.tag == "Enemy")
        {
            GameObject effect = Instantiate(hitEffectEnemy, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);

            Destroy(collision.gameObject);
            Destroy(gameObject);
            score.GetComponent<Score>().increaseScore(EnemyScore);
           
        }

        if (collision.gameObject.tag == "Firefly")
        {
            GameObject effect = Instantiate(hitEffectFirefly, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);

            GameManager.power += 1; 
            Destroy(collision.gameObject);
            Destroy(gameObject);
            score.GetComponent<Score>().increaseScore(FireflyScore);
           
        }

        if (collision.gameObject.tag == "Fly")
        {
            GameObject effect = Instantiate(hitEffectFly, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);

            GameManager.health += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
    
}
