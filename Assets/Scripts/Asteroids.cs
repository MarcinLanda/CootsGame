using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour {
    private void Start() {
        GameObject asteroid = GameObject.FindGameObjectWithTag("Asteroid");
        Physics2D.IgnoreCollision(asteroid.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
}
