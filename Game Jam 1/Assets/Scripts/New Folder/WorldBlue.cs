using UnityEngine;

public class WorldBlue : WorldState
{ 
    public GameObject worldParent;
    
    public override void setWorldObject(WorldManager worldManager)
    {
        worldParent = GameObject.Find("Blue World");
    }
    
    public override void enterWorld(WorldManager worldManager)
    {
        worldParent.SetActive(true);
        
        Debug.Log("enter Blue");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        worldParent.SetActive(false);
        
        Debug.Log("leave Blue");
    }
}
