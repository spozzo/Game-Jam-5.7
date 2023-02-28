using UnityEngine;

public class World2 : WorldState
{ 
    public GameObject worldParent;
    
    public override void worldObject(WorldManager worldManager)
    {
        worldParent = GameObject.Find("World 2");
    }
    
    public override WorldState nextWorld(WorldManager worldManager)
    { 
        return new World1();
    }
    
    public override void enterWorld(WorldManager worldManager)
    {
        
        worldParent.SetActive(true);
        
        Debug.Log("enter 2");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        
        worldParent.SetActive(false);
        
        Debug.Log("leave 2");
    }
}
