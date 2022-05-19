using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score;
    public Text textScore;


    void Awake() 
    {
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        textScore.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increaseScore (int value)
    {
        textScore.enabled = true;
        score = score + value;
        textScore.text = "Score: " + score.ToString();
    }
}
