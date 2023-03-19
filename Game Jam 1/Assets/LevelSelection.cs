using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour{

    public int level = 1;
    public TMP_Text label;
    
    // Start is called before the first frame update
    void Start(){
        label.text = level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadLevel(){
        SceneManager.LoadScene("Level " + level);
    }
}
