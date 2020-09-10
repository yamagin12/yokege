using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pattern : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    private int rundumLv;
    private int downLv;
    public static int level;
    public float interval = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Event", 5, interval);
        InvokeRepeating("LevelUp", 1, 12);
    }

    // Update is called once per frame
    void Event()
    {
        if (PlayerController.Gameover == false)
        {
            if (level == 1) rundumLv = 7;
            if (level == 2) rundumLv = 9;
            if (level == 3) interval = 3.5f;
            if (level == 4) rundumLv = 12;
            if (level == 5) downLv = 4;rundumLv = 15;
            //if (level == 5) movespeed
            int pattern = Random.Range(downLv, rundumLv);
            Debug.Log("patan" + pattern);
            //p1
            if (pattern <= 4)
            {
                Instantiate(p1, transform.position = new Vector2(16, Random.Range(0, 6)), transform.rotation);
            }
            //p2
            if (pattern == 5 || pattern == 6)
            {
                Instantiate(p2, transform.position = new Vector2(16, Random.Range(5f, 6f)), transform.rotation);
                Instantiate(p2, transform.position = new Vector2(17, Random.Range(2f, 4f)), transform.rotation);
                Instantiate(p2, transform.position = new Vector2(18, Random.Range(1f, -1f)), transform.rotation);
                Instantiate(p2, transform.position = new Vector2(19, Random.Range(5f, 6f)), transform.rotation);
                Instantiate(p2, transform.position = new Vector2(20, Random.Range(2f, 4f)), transform.rotation);
                Instantiate(p2, transform.position = new Vector2(21, Random.Range(1f, -1f)), transform.rotation);

            }
            //p3
            if (pattern == 7 || pattern == 8)
            {
                Instantiate(p3, transform.position = new Vector2(15, 3), transform.rotation);
                Instantiate(p3, transform.position = new Vector2(19, 3), transform.rotation);
                Instantiate(p3, transform.position = new Vector2(23, 3), transform.rotation);
            }
            if (pattern == 9 || pattern == 10 || pattern == 11)
            {
                Instantiate(p4, transform.position = new Vector2(15, Random.Range(0f, 4f)), transform.rotation);
                Instantiate(p4, transform.position = new Vector2(20, Random.Range(0f, 6f)), transform.rotation);
                Instantiate(p4, transform.position = new Vector2(25, Random.Range(2f, 6f)), transform.rotation);
            }
            if (pattern >= 12 & pattern <= 14)
            {
                Instantiate(p4, transform.position = new Vector2(16, Random.Range(0f, 6f)), transform.rotation);
                Instantiate(p1, transform.position = new Vector2(17, Random.Range(0f, 6f)), transform.rotation);
                Instantiate(p1, transform.position = new Vector2(18, Random.Range(0f, 6f)), transform.rotation);

            }
        }
    }
    void LevelUp()
    {
        Debug.Log("levelUp");
        level++;
        Debug.Log(level);
    }
}