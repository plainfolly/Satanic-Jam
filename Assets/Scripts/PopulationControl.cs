using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationControl : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fly")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Firefly")
        {
            Destroy(gameObject);
        }
    }
}
