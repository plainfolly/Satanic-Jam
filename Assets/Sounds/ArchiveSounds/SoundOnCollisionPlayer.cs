using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollisionPlayer : MonoBehaviour
{
    public AudioSource playSound;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            playSound.Play();
            GameManager.health -= 1;
            Destroy(gameObject);
        }

    }
}