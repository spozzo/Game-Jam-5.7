using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour{
    
    [SerializeField] private GameObject scoreObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            // get coin
            Destroy(this.gameObject);
            Debug.Log("coin");
            scoreObject.GetComponent<ScoreIncrement>().incrementScore(10);
        }
        
    }
}
