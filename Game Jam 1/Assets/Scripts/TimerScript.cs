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

        if (seconds < 10){
            textObj.text = minutes + ":0" + seconds;
        } else{
            textObj.text = minutes + ":" + seconds;
        }
    }
}
