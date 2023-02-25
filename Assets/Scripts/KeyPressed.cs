using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeyPressed : MonoBehaviour{
    public bool openSettings;
    public bool closeSettings;
    public bool pause;
    public bool resume;
    public bool restart;

    public GameObject setActive;
    public GameObject hide;

    public Save s;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (openSettings){
                SceneManager.LoadScene(5, LoadSceneMode.Single);
            } else if (closeSettings){
                s.SaveGame();
                SceneManager.LoadScene(0, LoadSceneMode.Single); //SAVE BEFORE
            } else if (pause){
                setActive.SetActive(true);
                hide.SetActive(false);
            } else if (resume){
                setActive.SetActive(true);
                hide.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            if (restart) {
                SceneManager.LoadScene(4, LoadSceneMode.Single);
            }
        }
    }
}
