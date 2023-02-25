using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Music : MonoBehaviour {
    public AudioSource audioSource;
    private GameObject[] other;
    private bool NotFirst = false;
    private void Awake() {
        other = GameObject.FindGameObjectsWithTag("Music");
        foreach (GameObject oneOther in other) {
            if (oneOther.scene.buildIndex == -1) {
                NotFirst = true;
            }
        }
        if (NotFirst == true) {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
    }
    public void PlayMusic() {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }
    public void StopMusic() {
        audioSource.Stop();
    }
}