using UnityEngine;

public class WorldRed : WorldState
{
    public GameObject worldParent;
    
    public override void setWorldObject(WorldManager worldManager)
    {
        worldParent = GameObject.Find("Red World");
    }

    public override void enterWorld(WorldManager worldManager)
    {
        worldParent.SetActive(true);
        
        Debug.Log("enter red");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        worldParent.SetActive(false);
        
        Debug.Log("leave red");
    }
}
