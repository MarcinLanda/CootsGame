using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Butt : MonoBehaviour
{
    public int level;
    public int mode;
    public GameObject restart;
    public GameObject button;
    public GameObject bubl;
    private GameObject click;
    void Start() {
        click = GameObject.FindGameObjectWithTag("Click");
        if (click != null) {
            DontDestroyOnLoad(click.gameObject);
        }
        
    }
    void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "Player") {
            if (mode == 1) {
                SceneManager.LoadScene(level, LoadSceneMode.Single);
            } else {
                SceneManager.LoadScene(level, LoadSceneMode.Additive);
            }
        }
    }

    public void NewGameButton() {
        if(click != null) {
            click.GetComponent<AudioSource>().Play();
        }
        if(button.tag == "Quit") {
            Application.Quit();
        }

        GameObject ball = GameObject.Find("Ball");
        if (mode == 1) {
            SceneManager.LoadScene(level, LoadSceneMode.Single);
        } else {
            if (button.name == "Start") {
                button.SetActive(false);
                restart.SetActive(true);
                bubl.SetActive(true);
                SceneManager.LoadScene(level, LoadSceneMode.Additive);
            } else if (button.name == "Retry") {
                Destroy(ball);
                SceneManager.LoadScene(level, LoadSceneMode.Additive);
                button.SetActive(true);
            }
        }
    }
    public void setLevel(int lvl) {
        level = lvl;
    }
}
