using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource fireSound;

    public float fireSpeed = 0.2f;
    float timer;
    public float bulletForce = 20f;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireSpeed)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                GetComponent<AudioSource>().Play();
                timer = 0;
            }
            
        }
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
