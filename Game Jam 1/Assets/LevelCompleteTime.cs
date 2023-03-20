using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelCompleteTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        double time = LevelManager.lastTime;
        
        int minutes = (int) (time / 60);
        int seconds = (int)time % 60;
        int milliseconds = (int)((time - (int)time) * 100);

        string minutesStr = minutes.ToString();
        string secondsStr = seconds.ToString();
        if (secondsStr.Length == 1) secondsStr = "0" + secondsStr;
        string millisecondsStr = milliseconds.ToString();
        if (millisecondsStr.Length == 1) millisecondsStr = "0" + millisecondsStr;

        GetComponent<TMP_Text>().text = "Time: " + minutesStr + ":" + secondsStr + "." + millisecondsStr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
