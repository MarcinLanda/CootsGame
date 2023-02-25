using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLoad : MonoBehaviour
{
    public Butt button;
    // Start is called before the first frame update
    void Start() {
        if (PlayerPrefs.HasKey("gameTips")) {
            if (PlayerPrefs.GetString("gameTips").Equals("False")) {
                button.setLevel(7);
            }
        } else {
            PlayerPrefs.SetString("gameTips", "True");
            PlayerPrefs.SetString("cheats", "False");
        }
    }
}
