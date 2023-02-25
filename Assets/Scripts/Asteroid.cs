using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 5f;
    public GameObject teleport;
    // Update is called once per frame
    public GameObject asteroid;
    void Update() {
        asteroid.transform.Translate(new Vector2((speed * Time.deltaTime), 0f));
        if (teleport != null && asteroid.transform.position.x >= teleport.transform.position.x) {
            asteroid.transform.position = new Vector2(-100, asteroid.transform.position.y);
        }
    }
}
