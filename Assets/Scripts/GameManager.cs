using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject heart1, heart2, heart3, gameOver;
    public static int health;
    public static bool invincible;
    private static float countdown;

    void Start ()
    {
        DontDestroyOnLoad(this.gameObject);
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);

        countdown = 2;
    }

    void Update()

    {
        if (health > 3)
            health = 3;
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;

            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
                
        }

        // Countdown
        if (invincible)
        {
            if (countdown > 0)
            {
                countdown -= Time.deltaTime;
            }
            if (countdown < 0)
            {
                countdown = 2;
                invincible = false;
            }
        } 
    }

    public static void TakeDamage()
    {
        if (!invincible)
        {
            health -= 1;
            // TODO: Animation Mother_1 bis _3
        }
    }

    public static void MakeInvincible()
    {
        invincible = true;
    }
}