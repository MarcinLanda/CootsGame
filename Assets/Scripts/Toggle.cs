using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{

    public Sprite imgOff;
    public Sprite imgOn;

    public Image img;
    private bool b;

    private GameObject click;
    void Start() {
        if (b) {
            img.sprite = imgOn;
        } else {
            img.sprite = imgOff;
        }
        click = GameObject.FindGameObjectWithTag("Click");
        if (click != null) {
            DontDestroyOnLoad(click.gameObject);
        }
    }
    void Update() {
        //Debug.Log(b);
        refresh();
    }
    public void toggle() {
        if (click != null) {
            click.GetComponent<AudioSource>().Play();
        }
        if (b) {
            b = !b;
            img.sprite = imgOff;
        } else {
            b = !b;
            img.sprite = imgOn;
        }
    }

    public bool getBool() {
        return b;
    }
    public void setBool(bool bol) {
        b = bol;
    }
    public void refresh() {
        if (b) {
            img.sprite = imgOn;
        } else {
            img.sprite = imgOff;
        }
    }
}
