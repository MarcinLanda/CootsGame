using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D c) {
        if(c.gameObject.tag == "Player") {
            PlayerPrefs.SetString("checkpoint", "True");
        }
    }

    public void checkpoint() {
        PlayerPrefs.SetString("checkpoint", "False");
    }
}
