using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollisionEnemy : MonoBehaviour
{
    [SerializeField]
    AudioSource playSound;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Despawner")
        {
            playSound.Play();
            GameManager.health -= 1;
            Destroy(gameObject);
            Debug.Log("Collider");
        }

    }
}