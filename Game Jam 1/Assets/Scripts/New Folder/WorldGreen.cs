using UnityEngine;

public class WorldGreen : WorldState
{
    public GameObject worldParent;
    
    Color transparentColor = new Color(1, 1, 1, 0.2f);
    Color solidColor = new Color(1, 1, 1, 1);
    
    public override void setWorldObject(WorldManager worldManager)
    {
        worldParent = GameObject.Find("Green World");
    }
    
    public override void enterWorld(WorldManager worldManager)
    {
        //make transparent
        SpriteRenderer[] sprites = worldParent.GetComponentsInChildren<SpriteRenderer>();
        foreach(SpriteRenderer sprite in sprites)
        {
            sprite.color = solidColor;
        }

        //make intangible
        BoxCollider2D[] colliders = worldParent.GetComponentsInChildren<BoxCollider2D>();
        foreach(BoxCollider2D collider in colliders)
        {
            collider.enabled = true;
        }
        Debug.Log("enter green");
    }

    public override void leaveWorld(WorldManager worldManager)
    {
        //make opaque
        SpriteRenderer[] sprites = worldParent.GetComponentsInChildren<SpriteRenderer>();
        foreach(SpriteRenderer sprite in sprites)
        {
            sprite.color = transparentColor;
        }
        
        //make tangible
        BoxCollider2D[] colliders = worldParent.GetComponentsInChildren<BoxCollider2D>();
        foreach(BoxCollider2D collider in colliders)
        {
            collider.enabled = false;
        }
        Debug.Log("leave green");
    }

}
