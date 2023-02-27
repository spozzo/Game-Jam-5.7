using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldChanger : MonoBehaviour
{   public int world;
    public int timer;
    public bool worldHasChanged;
    // Start is called before the first frame update
    void Start()
    {
        world = 0;
        
        StartCoroutine("WorldTimer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WorldTimer()
    {  
        for(;;) {

        
        timer = Random.Range(2,6);
        world = Random.Range(0,3);
        Debug.Log("Current world changed to " + world);
        worldHasChanged = true;
        yield return new WaitForSeconds(timer);
        }
    }
}
