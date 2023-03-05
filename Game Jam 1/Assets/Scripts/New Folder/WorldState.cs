using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WorldState
{
    public abstract void setWorldObject(WorldManager worldManager);
    
    public abstract void enterWorld(WorldManager worldManager);

    public abstract void leaveWorld(WorldManager worldManager);
}
