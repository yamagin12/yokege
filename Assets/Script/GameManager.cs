using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    //プレイデータ


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        InvokeRepeating("ScoreM", 1, 0.08f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ScoreM()
    {
        if (PlayerController.Gameover == false)
        {
            Score.score += 1;
        }
    }
}