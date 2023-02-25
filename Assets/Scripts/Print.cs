using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("gameTips")) {
            Debug.Log(PlayerPrefs.GetString("gameTips"));
        } else {
            PlayerPrefs.SetString("gameTips", "True");
            Debug.Log(PlayerPrefs.GetString("gameTips" + " uh oh"));
        }
    }

    
}
