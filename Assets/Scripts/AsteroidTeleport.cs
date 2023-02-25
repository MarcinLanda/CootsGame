using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidTeleport : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Asteroid") {
            Vector2 pos = collision.gameObject.transform.position;
            float newX = -70f;
            //set the object's Y to the new calculated Y
            collision.gameObject.transform.position = new Vector2(newX, pos.y);
        }
    }
}
