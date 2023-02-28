using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject player;

    public float camAccel = .1f;
    float camTopSpeed;
    public float distanceToSnap = .1f;
    public float followRatio = .5f;

    public float camBoundLeft = 0f;
    public float camBoundRight = 14f;

    float distance;
    Vector2 playerPosition;


    
    void Awake()
    {
         
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        camTopSpeed = player.GetComponent<playerMove>().maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
    }

    void FixedUpdate()
    {
        moveCamera();
    }

    void checkDistance()
    {
        playerPosition = player.transform.position;
        distance = playerPosition.x - transform.position.x;
    }

    void moveCamera()
    {
        if(Mathf.Abs(distance) < distanceToSnap)
        {
            transform.position = new Vector3(playerPosition.x, 0, -1);
        }
        else
        {
            transform.Translate(Vector2.right * distance * followRatio);
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, camBoundLeft, camBoundRight), 0, -1);
    }
}
