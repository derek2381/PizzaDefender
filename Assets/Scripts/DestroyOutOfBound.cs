using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBound : MonoBehaviour
{
    private int topBound = 30;
    private int lowerBound = -20;
    private SpawnManager spawnManager;
    
    // Start is called before the first frame update
    void Start()
    {
      spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound){
            Destroy(gameObject);
        }else if(transform.position.z < lowerBound){
            // Debug.Log("GameOver!!!");
            spawnManager.isGameOn = false;

            Destroy(gameObject);
        }

    }
}
