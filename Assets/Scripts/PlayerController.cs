using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;

    public float xRange = 10.0f;
    public GameObject projectilePrefab;
    private SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
      spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();

    }

    // Update is called once per frame
    void Update()
    {
      if(spawnManager.isGameOn){


          if(transform.position.x < -xRange){
              transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
          }else if(transform.position.x > xRange){
              transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
          }
          horizontalInput = Input.GetAxis("Horizontal");
          transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

          if(Input.GetKeyDown(KeyCode.Space)){
              // Launch the projectile when space bar is pressed
              Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
          }
      }
    }
}
