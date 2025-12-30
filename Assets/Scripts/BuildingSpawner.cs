using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    [SerializeField] float maxYPos;
    [SerializeField] float spawnTime;
    [SerializeField] float time;
    public GameObject building;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartSpawningBuilding();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSpawningBuilding()
    {
        InvokeRepeating("SpawnBuilding", time, spawnTime);
    }

    public void StopSpawningBuilding()
    {
        InvokeRepeating("SpawnBuilding", time, spawnTime);
    }

    void SpawnBuilding()
    {
        Instantiate(
            building, 

            // it will generate building with Random up or down position.
            // Vector3(xPosition, yPosition, zPosition)
            new Vector3(transform.position.x, Random.Range(-maxYPos, maxYPos), 0), 

            // to rotate the building a little
            Quaternion.identity
        );
    }
}
