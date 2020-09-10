using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject OptionObj;
    private bool firstPush = false;

    public void PressStart()
    {
        
        if (!firstPush)
        {
            firstPush = true;
            OptionObj.SetActive(true);
        }
    }
}
