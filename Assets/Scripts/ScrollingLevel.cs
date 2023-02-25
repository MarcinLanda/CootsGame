using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingLevel : MonoBehaviour
{
    public float speed = 5f;
    public GameObject end;
    public GameObject block;
    void Update() {
        block.transform.Translate(new Vector2(0f, (speed * Time.deltaTime)));
        if (end != null && block.transform.position.y >= end.transform.position.y) {
            block.transform.position = new Vector2(-100, block.transform.position.y);
        }
    }
}
