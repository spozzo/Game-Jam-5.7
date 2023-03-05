using UnityEngine;

public class WorldYellow : WorldState
{
    public GameObject worldParent;
    
    public override void setWorldObject(WorldManager worldManager)
    {
        worldParent = GameObject.Find("Yellow World");
    }
    
    public override void enterWorld(WorldManager worldManager)
    {
        worldParent.SetActive(true);
        
        Debug.Log("enter yellow");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        worldParent.SetActive(false);
        
        Debug.Log("leave yellow");
    }
}
