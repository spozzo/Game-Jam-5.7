using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour{

    public static double lastTime;
    
    public static int maxLevelBeat = 0;

    public static int levelCount;
    
    public static int curLevel = 0;

    public Button[] levelButtons;

    public static double[] bestTime = {1e5, 1e5, 1e5, 1e5};
    
    // Start is called before the first frame update
    void Start(){
        Debug.Log(maxLevelBeat);
        levelCount = levelButtons.Length;
        
        for (int i = 0; i < levelButtons.Length; i++){
            if (i <= maxLevelBeat){
                Debug.Log(i);
                levelButtons[i].interactable = true;
            } else{
                levelButtons[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update(){
        
    }

    public static void levelBeat(double time){
        Debug.Log(curLevel);
        maxLevelBeat = Math.Max(maxLevelBeat, curLevel);
        bestTime[curLevel - 1] = Math.Min(bestTime[curLevel-1], time);
        lastTime = time;
    }
}
