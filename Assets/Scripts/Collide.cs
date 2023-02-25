using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    private GameObject ground;
    void Start() {
        ground = GameObject.FindGameObjectWithTag("Ground");
        if (ground != null) {
            DontDestroyOnLoad(ground);
        }
    }
    void OnCollisionEnter2D(Collision2D collision) {
        //Debug.Log(collision.collider.tag);
        if (ground != null) {
            if (collision.collider.tag == "Collider" || collision.collider.tag == "Asteroid") {
                if (!ground.GetComponent<AudioSource>().isPlaying) {
                    ground.GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
