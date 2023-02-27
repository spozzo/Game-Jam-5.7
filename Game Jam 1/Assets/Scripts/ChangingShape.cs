using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingShape : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    public Sprite Circle;
    public Sprite Triangle;
    public Sprite Square;
    public bool worldHasChanged;
    public WorldChanger worldChanger;
    public int timer;
    void Start()
    {
        int world = GameObject.Find("Triangle").GetComponent<WorldChanger>().world;
        StartCoroutine("WorldChanges");
    }
    void ChangeSprite_0()
    {
        spriteRenderer.sprite = Square;
    }
    void ChangeSprite_1()
    {
        spriteRenderer.sprite = Circle;
    }
    void ChangeSprite_2()
    {
        spriteRenderer.sprite = Triangle;
    }
    // Update is called once per frame
    void Update()
    {
       
    }  
    // Checks the current world every 2 seconds, changes sprite accordingly
    IEnumerator WorldChanges()
    {  
        for(;;) 
        {
            int world = GameObject.Find("Triangle").GetComponent<WorldChanger>().world;
            if(world == 0)
            {
                ChangeSprite_0();
            }
            if(world == 1)
            {
                ChangeSprite_1();
            }
            if(world == 2)
            {
                ChangeSprite_2();
            }
            timer = 2;
        
            yield return new WaitForSeconds(timer);
        }
    }  
}