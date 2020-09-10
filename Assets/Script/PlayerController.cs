using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    AudioSource audioSource;
    Rigidbody2D rigid2D;
    public bool blue = false;
    bool aaaa = false;
    public static bool Gameover = false;
    public GameObject gameOverObj;
    public GameObject MenuUIobj;
    public float trun = 50.0f;
    public float maxspeed = 50.0f;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip gameoveraudio;
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        Gameover = false;
        rigid2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (!hit2d || hit2d.transform.gameObject.tag != "UIObject")
            {
                if (blue == false)
                {
                    anim.SetBool("blue", true);
                    audioSource.PlayOneShot(audio1);
                    blue = true;
                }
                else
                {
                    anim.SetBool("blue", false);
                    audioSource.PlayOneShot(audio2);
                    blue = false;
                }
            }
            
        }
        if (Input.GetMouseButton(0))
        {
            rigid2D.velocity = Vector2.zero;
        }
    }
    private void FixedUpdate()
    {
        if(blue == true)
        {
            Vector2 myGravity = new Vector2(0, 10f * 2);
            rigid2D.AddForce(myGravity);
        }
        else
        {
            
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Gameover")
        {
            audioSource.PlayOneShot(gameoveraudio);
            Debug.Log("GAMEOVER");
            gameOverObj.SetActive(true);
            MenuUIobj.SetActive(false);
            Gameover = true;
        }
    }
}
