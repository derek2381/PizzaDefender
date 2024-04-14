using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    private SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {

      spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();

    }

    // Update is called once per frame
    void Update()
    {
      if(spawnManager.isGameOn)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
