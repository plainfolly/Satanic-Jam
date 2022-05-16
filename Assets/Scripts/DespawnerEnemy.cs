using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnerEnemy : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Despawner")
        {
            Destroy(collision.gameObject);
        }
    }
}
