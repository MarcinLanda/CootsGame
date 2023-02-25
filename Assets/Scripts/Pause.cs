using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    public GameObject hideItems;
    public GameObject openMenu;
    private GameObject click;

    void Start() {
        click = GameObject.FindGameObjectWithTag("Click");
        if (click != null) {
            DontDestroyOnLoad(click.gameObject);
        }
    }
    public void pause() {
        if (click != null) {
            click.GetComponent<AudioSource>().Play();
        }
        hideItems.SetActive(false);
        openMenu.SetActive(true);
    }
}
