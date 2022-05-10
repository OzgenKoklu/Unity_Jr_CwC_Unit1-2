using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float TopSpawnRangeX = 10;
    private float TopSpawnPosZ = 20;
    private float[] HorizontalSpawnPosX = { 20.5f , -20.5f };

    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 0.5f, 2);
        InvokeRepeating("HorizontalLeftSpawnRandomAnimal", 1.5f, Random.Range(2, 4));
        InvokeRepeating("HorizontalRightSpawnRandomAnimal", 2.5f, Random.Range(2, 4));
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-TopSpawnRangeX, TopSpawnRangeX), 0, TopSpawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    
    void HorizontalLeftSpawnRandomAnimal()
    {
        Vector3 horzontalSpawnPos = new Vector3(HorizontalSpawnPosX[1], 0, Random.Range(2.5f, 15f));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        var Example = Instantiate(animalPrefabs[animalIndex], horzontalSpawnPos, Quaternion.Euler(0, 90, 0));
        Example.tag = "Aggressive";
       

    }

    void HorizontalRightSpawnRandomAnimal()
    {
        Vector3 horzontalSpawnPos = new Vector3(HorizontalSpawnPosX[0], 0, Random.Range(2.5f, 15f));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        var Example = Instantiate(animalPrefabs[animalIndex], horzontalSpawnPos, Quaternion.Euler(0, -90, 0));
        Example.tag = "Aggressive";
     

    }
}
