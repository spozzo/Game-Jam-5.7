using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreIncrement : MonoBehaviour{

    private TMP_Text textObj;
    
    // Start is called before the first frame update
    void Start(){
        textObj = GetComponent<TMP_Text>();
        double best = LevelManager.bestTime[LevelManager.curLevel - 1];
        Debug.Log(best);
        if (best >= 1e5){
            textObj.text = "Best: -:--.--";
        } else{
            int minutes = (int) (best / 60);
            int seconds = (int)best % 60;
            int milliseconds = (int)((best - (int)best) * 100);

            string minutesStr = minutes.ToString();
            string secondsStr = seconds.ToString();
            if (secondsStr.Length == 1) secondsStr = "0" + secondsStr;
            string millisecondsStr = milliseconds.ToString();
            if (millisecondsStr.Length == 1) millisecondsStr = "0" + millisecondsStr;

            textObj.text = "Best: " + minutesStr + ":" + secondsStr + "." + millisecondsStr;
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
