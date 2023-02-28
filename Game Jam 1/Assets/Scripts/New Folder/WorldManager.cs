using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    WorldState currentWorld;

    public World1 world1 = new World1();
    public World2 world2 = new World2();

    public float maxTimer = 15f;
    public float minTimer = 5f;

    float timer; 
    
    void Start()
    {
        // starting world
        currentWorld = world1;

        currentWorld.enterWorld(this);

        StartCoroutine("WorldTimer");
    }

    void Update()
    {
        
    }

    IEnumerator WorldTimer()
    {  
        while(true) 
        {
            timer = Random.Range(minTimer, maxTimer);

            yield return new WaitForSeconds(timer);

            changeWorld(currentWorld);
            Debug.Log("Current world changed to " + currentWorld);
        }
    }

    void changeWorld(WorldState oldWorld)
    {
        WorldState newWorld = oldWorld.nextWorld(this);
        oldWorld.leaveWorld(this);
        newWorld.enterWorld(this);
        currentWorld = newWorld;
    }
}
