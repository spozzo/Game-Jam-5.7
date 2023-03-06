using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreIncrement : MonoBehaviour{

    private int score;
    
    private TMP_Text textObj;
    
    // Start is called before the first frame update
    void Start(){
        score = 0;

        textObj = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void incrementScore(int scoreChange){
        score += scoreChange;
        textObj.text = "Score: " + score;
    }
}
