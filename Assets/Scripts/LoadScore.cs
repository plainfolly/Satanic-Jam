using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{

    GameObject score;
    public Text hiscoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindWithTag("Score");
        hiscoreText.text = "HIGHSCORE: " + score.GetComponent<Score>().score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
