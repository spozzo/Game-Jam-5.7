using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRespawn : MonoBehaviour
{
    public Vector2 spawnPoint = new Vector2(-5.5f, -2f);

    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10)
        {
            respawn();
        }
    }

    public void respawn()
    {
        transform.position = spawnPoint;
        transform.eulerAngles = Vector3.zero;
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
    }
}
