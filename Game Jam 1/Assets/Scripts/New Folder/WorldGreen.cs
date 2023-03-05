using UnityEngine;

public class WorldGreen : WorldState
{
    public GameObject worldParent;
    
    public override void setWorldObject(WorldManager worldManager)
    {
        worldParent = GameObject.Find("Green World");
    }
    
    public override void enterWorld(WorldManager worldManager)
    {
        worldParent.SetActive(true);
        
        Debug.Log("enter green");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        worldParent.SetActive(false);
        
        Debug.Log("leave green");
    }
}
