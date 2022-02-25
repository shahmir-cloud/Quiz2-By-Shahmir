using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        Instantiate(animalPrefabs, new Vector3(-12.63f, 0.5f, 4), animalPrefabs.transform.rotation);
        Instantiate(animalPrefabs, new Vector3(-12.63f, 0.5f, -3), animalPrefabs.transform.rotation);
        Instantiate(animalPrefabs, new Vector3(12.63f, 0.5f, -3), animalPrefabs.transform.rotation);
        Instantiate(animalPrefabs, new Vector3(12.63f, 0.5f, 4), animalPrefabs.transform.rotation);
    }
}
