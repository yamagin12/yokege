using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    public Sprite spritered;
    public Sprite spriteblue;
    bool red;
    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (red == true)
            {
                MainSpriteRenderer.sprite = spritered;
                red = false;
            }
            else
            {
                MainSpriteRenderer.sprite = spriteblue;
                red = true;
            }

        }
    }
}
