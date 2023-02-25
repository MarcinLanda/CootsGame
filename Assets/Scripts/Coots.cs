using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Coots : MonoBehaviour
{
    public Sprite coot;

    public SpriteRenderer coots;
    
    void OnTriggerEnter2D(Collider2D c) {
        if (c.tag == "Player"){
            coots.sprite = coot;
        }
    }
}
