using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public Text ScoreText;
    
    void Start()
    {
        ScoreText = GetComponent<Text>();

        ScoreText.text = "Score " + Score.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
