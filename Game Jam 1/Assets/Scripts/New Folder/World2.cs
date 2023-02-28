using UnityEngine;

public class World2 : WorldState
{
    public override WorldState nextWorld(WorldManager worldManager)
    { 
        return new World1();
    }
    
    public override void enterWorld(WorldManager worldManager)
    {
        Debug.Log("enter 2");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        Debug.Log("leave 2");
    }
}
