using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{

public AudioSource Gore;

public void PlayGore(){
Gore.Play();
}

void OnTriggerEnter(){
Gore.Play();
}

}
