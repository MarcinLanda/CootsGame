using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    public AudioSource a;
    void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "Player") { 
            a.Play();
        }
    }
}
