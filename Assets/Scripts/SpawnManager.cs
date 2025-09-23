using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // variables 
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 13.0f;
    private float posZ = -1.2f;
    private float posY = 8.7f;
    private float startDelay = 2;
    [SerializeField] private float spawnInterval = 1.5f;

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
        Vector3 spawnPosX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), posY, posZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosX, animalPrefabs[animalIndex].transform.rotation);
    }
}
