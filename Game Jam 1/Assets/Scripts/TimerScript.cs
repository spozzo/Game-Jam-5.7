using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour{
    
    private double curTime;

    private TMP_Text textObj;

    // Start is called before the first frame update
    void Start(){
        curTime = 0;

        textObj = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update(){
        curTime += Time.deltaTime;

        int minutes = (int) (curTime / 60);
        int seconds = (int)curTime % 60;
        int milliseconds = (int)((curTime - (int)curTime) * 100);

        string minutesStr = minutes.ToString();
        string secondsStr = seconds.ToString();
        if (secondsStr.Length == 1) secondsStr = "0" + secondsStr;
        string millisecondsStr = milliseconds.ToString();
        if (millisecondsStr.Length == 1) millisecondsStr = "0" + millisecondsStr;

        textObj.text = "Time: " + minutesStr + ":" + secondsStr + "." + millisecondsStr;
    }

    public double getTime(){
        return curTime;
    }
}
