using UnityEngine;

public class World1 : WorldState
{
    public override WorldState nextWorld(WorldManager worldManager)
    { 
        return new World2();
    }
    
    public override void enterWorld(WorldManager worldManager)
    {
        
        
        Debug.Log("enter 1");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        Debug.Log("leave 1");
    }
}
