using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEffect : MonoBehaviour
   
{   
    public ParticleSystem collisionParticleSystem;
    public bool once = true;

    private void OnTriggerEnter2D(Collider2D health)
    {
        if (health.gameObject.CompareTag("Health") && once)
        {
            collisionParticleSystem.Play();
           
        }
    }
   
       
  
    
}
