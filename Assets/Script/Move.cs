using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveXDirection = -3f;
    public float speedUP;
    public bool blue;
    public bool red;
    
    public Sprite bluesprite;
    public Sprite redsprite;
    GameObject Chara;
    PlayerController playC;
    Collider2D col2D;
    SpriteRenderer MainSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Destroy(gameObject, 10.0f);
        Chara = GameObject.Find("chara");
        playC = Chara.GetComponent<PlayerController>();
        col2D = GetComponent<BoxCollider2D>();
        if (red == false & blue ==false)
        {
            int i = Random.Range(1, 3);
            if (i == 1)
            {
                red = true;
                MainSpriteRenderer.sprite = redsprite;
            }
            if (i == 2)
            {
                MainSpriteRenderer.sprite = bluesprite;
                blue = true;
            }
        }
        if (pattern.level >= 5) moveXDirection += speedUP;
        
    }

    // Update is called once per frame
    void Update()
    {
        bool Blue = playC.blue;
        col2D.isTrigger = true;
        if(blue)
        {
            if (Blue)
            {
                col2D.isTrigger = false;
            }
        }
        if (red)
        {
            if (Blue == false)
            {
                col2D.isTrigger = false;
            }
        }
        transform.Translate(moveXDirection * Time.deltaTime, 0, 0);
    }
}
