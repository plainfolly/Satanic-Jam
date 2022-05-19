using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPower : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public Transform firePoint5;
    public Transform firePoint6;
    public Transform firePoint7;
    public Transform firePoint8;
    public Transform firePoint9;
    public Transform firePoint10;
    public Transform firePoint11;
    public Transform firePoint12;
    public Transform firePoint13;
    public Transform firePoint14;
    public Transform firePoint15;

    public GameObject bulletPrefab;

    public GameManager manager;

    public float bulletForce = 20f;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Shoot();
            Shoot1();
            Shoot2();
            Shoot3();
            Shoot4();
            Shoot5();
            Shoot6();
            Shoot7();
            Shoot8();
            Shoot9();
            Shoot10();
            Shoot11();
            Shoot12();
            Shoot13();
            Shoot14();
            Shoot15();

            GameManager.power = 0;
            gameObject.SetActive(false);
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot1()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint1.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot2()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
    }
   
    void Shoot3()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint3.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot4()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint4.position, firePoint4.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint4.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot5()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint5.position, firePoint5.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint5.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot6()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint6.position, firePoint6.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint6.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot7()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint7.position, firePoint7.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint7.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot8()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint8.position, firePoint8.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint8.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot9()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint9.position, firePoint9.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint9.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot10()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint10.position, firePoint10.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint10.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot11()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint11.position, firePoint11.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint11.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot12()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint12.position, firePoint12.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint12.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot13()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint13.position, firePoint13.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint13.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot14()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint14.position, firePoint14.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint14.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot15()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint15.position, firePoint15.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint15.up * bulletForce, ForceMode2D.Impulse);
    }
}
