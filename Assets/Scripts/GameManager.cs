using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject heart1, heart2, heart3, power1, power2, power3, gameOver, usePower, mother, motherHurt, Enemyspawner, Enemy;
    public static int health;
    
    public static int power;
    public static bool invincible;
    private static float countdown;

    public bool isgameover;

    void Start ()
    {
        //DontDestroyOnLoad(this.gameObject);
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);


        power = 0;
        power1.gameObject.SetActive(false);
        power2.gameObject.SetActive(false);
        power3.gameObject.SetActive(false);
        usePower.gameObject.SetActive(false);

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
                if (isgameover == false)
                {
                    heart1.gameObject.SetActive(false);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    gameOver.gameObject.SetActive(true);
                   // Time.timeScale = 0;
                    isgameover = true;
                    Enemy.gameObject.SetActive(false);
                    mother.gameObject.SetActive(false);
                    Invoke("loadMainMenu", 3);
                }
               
                break;
                
        }

        //if (power < 1)
       //     power = 0;
        switch (power)
        {
            case 3:
                power1.gameObject.SetActive(true);
                power2.gameObject.SetActive(true);
                power3.gameObject.SetActive(true);
                usePower.gameObject.SetActive(true);
                
                break;
            case 2:
                power1.gameObject.SetActive(true);
                power2.gameObject.SetActive(true);
                power3.gameObject.SetActive(false);
                break;
            case 1:
                power1.gameObject.SetActive(true);
                power2.gameObject.SetActive(false);
                power3.gameObject.SetActive(false);
                break;

            case 0:
                power1.gameObject.SetActive(false);
                power2.gameObject.SetActive(false);
                power3.gameObject.SetActive(false);
                

                break;

        }

        // Countdown
        if (invincible)
        {
            mother.gameObject.SetActive(false);
            motherHurt.gameObject.SetActive(true);

            if (countdown > 0)
            {
                countdown -= Time.deltaTime;
            }
            if (countdown < 0)
            {
                countdown = 2;
                invincible = false;
                mother.gameObject.SetActive(true);
                motherHurt.gameObject.SetActive(false);



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

    public void SetPower(int value)
    {
        power = value;
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}