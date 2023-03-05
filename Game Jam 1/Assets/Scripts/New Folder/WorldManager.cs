using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    WorldState currentWorld;

    public WorldBlue worldBlue = new WorldBlue();
    public WorldGreen worldGreen = new WorldGreen();
    public WorldYellow worldYellow = new WorldYellow();
    public WorldRed worldRed = new WorldRed();
    public WorldState[] worldList = new WorldState[4];

    public GameObject player;

    float currentRotation = 0f;
    public int lowerChangeRotation = -90;
    public int higherChangeRotation = 90;
    public int rotationActivationRange = 1;

    public float maxTimer = 15f;
    public float minTimer = 5f;

    float timer; 
    
    void Start()
    {
        worldList[0] = worldBlue;
        worldList[1] = worldRed;
        worldList[2] = worldYellow;
        worldList[3] = worldGreen;

        worldBlue.setWorldObject(this);
        worldGreen.setWorldObject(this);
        worldYellow.setWorldObject(this);
        worldRed.setWorldObject(this);
        
        // starting world
        currentWorld = worldBlue;
        worldRed.leaveWorld(this);
        worldYellow.leaveWorld(this);
        worldGreen.leaveWorld(this);
    }

    void Update()
    {
        checkRotation();
        //Debug.Log(mod((int)(player.transform.eulerAngles.z)/90, 4));
    }

    void checkRotation()
    {
        if(player.transform.eulerAngles.z >= (float)(higherChangeRotation - rotationActivationRange))
        {
            lowerChangeRotation += 90;
            changeWorld(lowerChangeRotation, higherChangeRotation);
            higherChangeRotation += 90;
        }
        else if(player.transform.eulerAngles.z <= (float)(lowerChangeRotation + rotationActivationRange))
        {
            higherChangeRotation -= 90;
            changeWorld(higherChangeRotation, lowerChangeRotation);
            lowerChangeRotation -= 90;
        }
    }

    void changeWorld(int leaveRotation, int enterRotation)
    {
        worldList[mod(leaveRotation / 90, 4)].leaveWorld(this);
        worldList[mod(enterRotation / 90, 4)].enterWorld(this);
    }

    int mod(int a, int n)
    {
        return (a % n + n) % n;
    }

    /*
    IEnumerator WorldTimer()
    {  
        while(true) 
        {
            timer = Random.Range(minTimer, maxTimer);

            Debug.Log($"Next change in {timer} seconds.");

            yield return new WaitForSeconds(timer);

            changeWorld(currentWorld);
            Debug.Log($"Current world changed to {currentWorld}.");
        }
    }
    
    void changeWorld(WorldState oldWorld)
    {
        
        WorldState newWorld = oldWorld.nextWorld(this);
        oldWorld.leaveWorld(this);
        newWorld.enterWorld(this);
        currentWorld = newWorld;
        
        currentWorld.leaveWorld(this);

        if(currentWorld == world1)
        {
            currentWorld = world2;
        }
        else
        {
            currentWorld = world1;
        }

        currentWorld.enterWorld(this);
    }
    */
    
}
