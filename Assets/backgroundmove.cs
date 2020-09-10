using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundmove : MonoBehaviour
{
    public float movespeed;
    public float DestroyTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
        GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movespeed * Time.deltaTime, 0, 0);
    }
}
