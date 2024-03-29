using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible : MonoBehaviour{

    public GameObject timerObj;
    private TimerScript timerScript;
    
    // Start is called before the first frame update
    void Start(){
        timerScript = timerObj.GetComponent<TimerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")) {
            Debug.Log("level complete");
            LevelManager.levelBeat(timerScript.getTime());
            SceneManager.LoadScene("Level Complete");
        }
    }
}
