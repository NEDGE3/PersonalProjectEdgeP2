using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{    
    float lowerBound = -20;

    // Start is called before the first frame update
    void Start()
    {
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (transform.position.z < lowerBound)
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
