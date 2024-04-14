using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;

    private float spawnDelay = 3;
    private float spawnTimer = 1.5f;
    public bool isGameOn;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;


    // Start is called before the first frame update
    void Start()
    {
      StartGame();
    }

    // Update is called once per frame
    void Update()
    {


    }

     void  SpawnRandomPosition(){
       if(isGameOn){
          int animalIndex = Random.Range(0, animalPrefab.Length);
          Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
          Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
      }else{
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
      }

    }

    public void RestartGame(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void StartGame(){
      isGameOn = true;
      InvokeRepeating("SpawnRandomPosition", spawnDelay, spawnTimer);
    }
}
