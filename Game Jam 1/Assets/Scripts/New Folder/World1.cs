using UnityEngine;

public class World1 : WorldState
{
    public GameObject worldParent;
    
    public override void worldObject(WorldManager worldManager)
    {
        worldParent = GameObject.Find("World 1");
    }
    
    public override WorldState nextWorld(WorldManager worldManager)
    { 
        return new World2();
    }
    
    public override void enterWorld(WorldManager worldManager)
    {
        
        worldParent.SetActive(true);
        
        Debug.Log("enter 1");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        
        worldParent.SetActive(false);
        
        Debug.Log("leave 1");
    }
}
