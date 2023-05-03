using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    float spawnPosZ = 50;
    float startDelay = 2;
    float spawnInterval = 2f;
    int spawnPosX = 12;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCarPosition", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomCarPosition()
    {
        //spawn top
        SpawnRandomCar(new Vector3(-Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ), Quaternion.Euler(0, 180, 0));
    }
    void SpawnRandomCar(Vector3 spawnPos, Quaternion rotation)
    {
        Instantiate(carPrefabs[Random.Range(0, carPrefabs.Length)], spawnPos, rotation);
    }

}
