using UnityEngine;
using System;
using System.Collections;
using System.Security.Permissions;
using System.Runtime.InteropServices;


public class DragNShot : MonoBehaviour {
    public float power = 10f; //power of launch
    public float ySpeed;
    public float xSpeed;

    public GameObject ball;
    public GameObject paused;

    public Vector2 minPower; //Set the minimum launch power
    public Vector2 maxPower; //Set the maximum launch power

    public Trajectory trajectory;
    public Trajectory trajectory2;

    public Camera cam;

    private Vector2 force;
    private Vector2 ballPos;
    private Vector2 startPoint;
    private Vector2 cp;
    private Vector2 cpp;
    private bool pause;

    private GameObject shot;

    void Start() {
        shot = GameObject.FindGameObjectWithTag("Shot");
        if (shot != null) {
            DontDestroyOnLoad(shot.gameObject);
        }
    }
    private void Update() {
        //Debug.Log(ball.gameObject.GetComponent<Rigidbody2D>().velocity.x);
        if (!paused.activeSelf) {
            if (pause) {
                StartCoroutine(clock(.1f));
            } else {
                if (Input.GetMouseButtonDown(0)) {
                    startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                }
                //StartCoroutine(clock(1, true));
                if (Math.Abs(ball.gameObject.GetComponent<Rigidbody2D>().linearVelocity.y) <= ySpeed && Math.Abs(ball.gameObject.GetComponent<Rigidbody2D>().linearVelocity.x) <= xSpeed) {
                    ballPos = ball.transform.position;
                    if (Input.GetMouseButton(0)) {
                        holdingDown();
                    }
                    if (Input.GetMouseButtonUp(0)) {
                        letGo();
                        if (shot != null) {
                            shot.GetComponent<AudioSource>().Play();
                        }
                    }
                } else if (trajectory != null) {
                    trajectory.EndLine();
                    trajectory2.EndLine();
                }
            }
        } else {
            pause = true;
            trajectory.EndLine();
            trajectory2.EndLine();
        }
    }
    void holdingDown() {

        Vector2 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        cp = ballPos + startPoint - currentPoint;
        float distance = Vector2.Distance(startPoint, currentPoint);
        float radius = 25.0f;
        if (distance > radius) {
            cpp = ballPos + (startPoint - currentPoint).normalized * radius;
        } else {
            cpp = ballPos + (startPoint - currentPoint);
        }
        if (trajectory != null) {
            trajectory.RenderLine(ballPos, cpp);
            trajectory2.RenderLine(ballPos, cpp);
        }
    }
    void letGo() {
        force = new Vector2(Mathf.Clamp(cpp.x - ballPos.x, minPower.x, maxPower.x), Mathf.Clamp(cpp.y - ballPos.y, minPower.y, maxPower.y));
        ball.gameObject.GetComponent<Rigidbody2D>().AddForce(force * power, ForceMode2D.Impulse);
        if (trajectory != null) {
            trajectory.EndLine(); //Deletes the line from the screen
            trajectory2.EndLine();
        }
    }
    IEnumerator clock(float n) {
        yield return new WaitForSeconds(n);
        pause = false;
    }
}
