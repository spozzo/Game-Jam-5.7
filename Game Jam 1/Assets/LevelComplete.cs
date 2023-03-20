using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelComplete : MonoBehaviour{

    public TMP_Text text;
    
    // Start is called before the first frame update
    void Start(){
        text.text = "Level " + LevelManager.curLevel + " Complete!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
