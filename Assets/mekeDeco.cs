using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mekeDeco : MonoBehaviour
{
    public GameObject Block;
    public float interval = 2.0f;
    public float starttime;
    public float random;

    void Start()
    {
        random = Random.Range(6f, 10f);
        InvokeRepeating("CreateWalls", starttime, random);
    }

    void CreateWalls()
    {
        if (PlayerController.Gameover == false)
        {
            random = Random.Range(6f, 10f);
            Instantiate(Block, transform.position, transform.rotation);
        }
    }
}
