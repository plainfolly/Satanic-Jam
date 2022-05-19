using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsLoad : MonoBehaviour
{
    public void LoadScene(string Credits)
    {
        SceneManager.LoadScene(Credits);
    }

}
