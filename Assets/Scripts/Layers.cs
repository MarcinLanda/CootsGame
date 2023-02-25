using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layers : MonoBehaviour
{
    public GameObject ball;
    public GameObject setActive;
    public bool b;
    public Rigidbody2D grav;
    public DragNShot drag;
    public int newGrav;
    public float newMass;
    public float yVel;
    public float xVel;


    void OnTriggerEnter2D(Collider2D c) {
        if (c.tag == "Player") {
            if(setActive != null) {
                setActive.SetActive(b);
            }
            grav.gravityScale = newGrav;
            grav.mass = newMass;
            drag.xSpeed = xVel;
            drag.ySpeed = yVel;
        }
    }
}
