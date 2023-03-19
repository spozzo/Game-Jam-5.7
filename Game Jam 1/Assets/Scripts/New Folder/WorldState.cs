using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WorldState
{
    public abstract void setWorldObject(WorldManager worldManager);
    
    public abstract void enterWorld(WorldManager worldManager);

    public abstract void leaveWorld(WorldManager worldManager);

    /*
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
        Debug.Log("enter blue");
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
        Debug.Log("leave blue");
    }
    */
}
