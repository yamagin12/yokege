using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makestage : MonoBehaviour
{
    public GameObject Block;
    public float interval = 2.0f;
    public float starttime;


    void Start()
    {
        InvokeRepeating("CreateWalls",starttime, interval);
    }

    void CreateWalls()
    {
        if(PlayerController.Gameover == false)
        {
            Instantiate(Block, transform.position, transform.rotation);
        }
    }
        
}
