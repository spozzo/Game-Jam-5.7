using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour{

    public Button btn;
    
    // Start is called before the first frame update
    void Start()
    {
        if (LevelManager.curLevel == LevelManager.levelCount){
            btn.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLevel(){
        LevelManager.curLevel++;
        SceneManager.LoadScene("Level " + (LevelManager.curLevel));
    }
}
