using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(LineRenderer))]
public class Trajectory : MonoBehaviour {
    public LineRenderer lr; //Launch Arrow
    public GameObject ball;
    public GameObject cheatball;
    public GameObject cam;
    public GameObject cheatcam;
    public GameObject ball2;
    public GameObject cheatball2;
    public GameObject cam2;
    public GameObject cheatcam2;
    void Start () {
        if (PlayerPrefs.GetString("cheats").Equals("True")) {
            if (PlayerPrefs.GetString("checkpoint").Equals("True")) {
                cheatball2.SetActive(true);
                cheatcam2.SetActive(true);
            } else {
                cheatball.SetActive(true);
                cheatcam.SetActive(true);
            }
            
        } else {
            if (PlayerPrefs.GetString("checkpoint").Equals("True")) {
                ball2.SetActive(true);
                cam2.SetActive(true);
            } else {
                ball.SetActive(true);
                cam.SetActive(true);
            }
        }
    }
    private void Awake() {
        lr = GetComponent<LineRenderer>();
    }

    public void RenderLine(Vector3 startPoint, Vector3 endPoint) {
        lr.positionCount = 2;
        Vector3[] points = new Vector3[2];
        points[0] = startPoint;
        points[1] = endPoint;
        lr.SetPositions(points);
    }

    public void EndLine() {
        lr.positionCount = 0; //Deletes the line from the screen
    }
}
