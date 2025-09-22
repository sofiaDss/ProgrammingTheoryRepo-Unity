using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // variables 
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 13.0f;
    private float posZ = -1.2f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    { 
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, posZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosX, animalPrefabs[animalIndex].transform.rotation);
    }
}
