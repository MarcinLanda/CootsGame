using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Save : MonoBehaviour
{
    public int level;
    public int mode;

    public Toggle gametips;
    public bool bgametips;

    public Toggle cheats;
    public bool bcheats;
    private GameObject click;

    void Start() {
        click = GameObject.FindGameObjectWithTag("Click");
        if (click != null) {
            DontDestroyOnLoad(click.gameObject);
        }
    }
    public void SaveGame() {
        bgametips = gametips.getBool();
        PlayerPrefs.SetString("gameTips", bgametips.ToString());
        bcheats = cheats.getBool();
        PlayerPrefs.SetString("cheats", bcheats.ToString());
        PlayerPrefs.Save();
        if(mode == 1) {
            if (click != null) {
                click.GetComponent<AudioSource>().Play();
            }
            SceneManager.LoadScene(level, LoadSceneMode.Single);
        } else {
            if (click != null) {
                click.GetComponent<AudioSource>().Play();
            }
            SceneManager.LoadScene(level, LoadSceneMode.Additive);
        }
        
    }
}
