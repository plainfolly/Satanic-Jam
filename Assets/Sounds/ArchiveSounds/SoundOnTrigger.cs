using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnTrigger : MonoBehaviour
{
    public AudioSource Gore;
    void OnTriggerEnter(Collider other)
    {

        void OnTriggerEnter()
        {
        Gore.Play();
        }

    }
}