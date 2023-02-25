using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    private GameObject pop;
    void Start() {
        pop = GameObject.FindGameObjectWithTag("Death");
        if (pop != null) {
            DontDestroyOnLoad(pop);
        }
    }
    void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "Player") {
            if (pop != null) {
                pop.GetComponent<AudioSource>().Play();
            }
        }
    }
}
