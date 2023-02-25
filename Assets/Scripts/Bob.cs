using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    //adjust this to change speed
    public float speed = 5f;
    //adjust this to change how high it goes
    public float height = 1f;
    public float displacement = 0f;
    public GameObject arrow;
    void Update() {
        //get the objects current position and put it in a variable so we can access it later with less code
        Vector2 pos = arrow.transform.position;
        //calculate what the new Y position will be
        float newX = Mathf.Sin(Time.time * speed) * displacement + pos.x;
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        //set the object's Y to the new calculated Y
        arrow.transform.position = new Vector2(newX, newY) ;
    }
}
