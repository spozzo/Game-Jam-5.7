using UnityEngine;

public class WorldYellow : WorldState
{
    public GameObject worldParent;
    
    Color transparentColor = new Color(1, 1, 1, 0.2f);
    Color solidColor = new Color(1, 1, 1, 1);
    
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

