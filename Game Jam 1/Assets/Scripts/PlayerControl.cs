using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 5f;
    public float jumpForce = 5f;
    public Rigidbody2D rb;
    public float jumpMinMax = 0.5f;
    public float maxVelocity;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void runForward()
    {
        // the equation here is accounting for the current speed.
        // (force becomes lower as velocity is higher, making a seemingly constant speed)
        rb.AddForce(Vector2.right * speed * (1/(1 + Mathf.Abs(rb.velocity.x))), ForceMode2D.Impulse);
    }
    void runBackward()
    {
        rb.AddForce(Vector2.left * speed * (1/(1 + Mathf.Abs(rb.velocity.x))), ForceMode2D.Impulse);
    }
    void jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
       
       if(Input.GetKey(KeyCode.RightArrow) & (Mathf.Abs(rb.velocity.x) < maxVelocity))
       {
              runForward();
       }
       if(Input.GetKey(KeyCode.LeftArrow) & (Mathf.Abs(rb.velocity.x) < maxVelocity))
       {
              runBackward();
       }
       if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) & ((rb.velocity.y > -jumpMinMax ) & rb.velocity.y < jumpMinMax))
       {
           jump();
       }
    }
}
