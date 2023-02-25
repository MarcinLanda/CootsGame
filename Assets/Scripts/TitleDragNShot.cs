using UnityEngine;
using System;
using System.Collections;
using System.Diagnostics;

public class TitleDragNShot : MonoBehaviour {
    public float power = 10f; //power of launch
    public GameObject ball;
    public Vector2 minPower; //Set the minimum launch power
    public Vector2 maxPower; //Set the maximum launch power
    public Camera cam;
    private Vector2 force;
    private Vector2 ballPos;
    private Vector2 startPoint;
    private Vector2 cp;
    private Vector2 cpp;

    private GameObject shot;

    void Start() {
        shot = GameObject.FindGameObjectWithTag("Shot");
        if (shot != null) {
            shot.GetComponent<AudioSource>().timeSamples = shot.GetComponent<AudioSource>().clip.samples - 1;
            DontDestroyOnLoad(shot);
        }
    }

    private void Update() {
        ballPos = ball.transform.position;
        if (Input.GetMouseButtonDown(0)) {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0)) {
            holdingDown();
        }

        if (Input.GetMouseButtonUp(0)) {
            letGo();
        }
    }
    void holdingDown() {
        Vector2 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        cp = ballPos + startPoint - currentPoint;
        float distance = Vector2.Distance(startPoint, currentPoint);
        float radius = 3.0f;
        if (distance > radius) {
            cpp = ballPos + (startPoint - currentPoint).normalized * radius;
        } else {
            cpp = ballPos + (startPoint - currentPoint);
        }
    }
    void letGo() {
        if (shot != null) {
            shot.GetComponent<AudioSource>().Play();
        }
        force = new Vector2(Mathf.Clamp((cp.x - ballPos.x), minPower.x, maxPower.x), Mathf.Clamp((cp.y - ballPos.y), minPower.y, maxPower.y));
        ball.gameObject.GetComponent<Rigidbody2D>().AddForce(force * power, ForceMode2D.Impulse);
        
    }
}

