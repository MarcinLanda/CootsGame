using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {
    // Start is called before the first frame update
    public Toggle gametips;
    public Toggle cheats;
    void Start() {
        if (PlayerPrefs.HasKey("gameTips")) {
            //Debug.Log(PlayerPrefs.GetString("cheats"));
            if (PlayerPrefs.GetString("gameTips").Equals("True")) {
                gametips.setBool(true);
                gametips.refresh();
            } else {
                gametips.setBool(false);
                gametips.refresh();
            }

            if (PlayerPrefs.GetString("cheats").Equals("True")) {
                cheats.setBool(true);
                cheats.refresh();
            } else {
                cheats.setBool(false);
                cheats.refresh();
            }
        }
    }
}
