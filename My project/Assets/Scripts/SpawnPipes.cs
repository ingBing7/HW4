using Unity.VisualScripting;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public float pipeSpawnRate = 10f;
    public GameObject pipePrefab;
    
    void Update()
    {
        pipeSpawnRate =- Time.deltaTime;

        Vector2 spawnLocation = new Vector2(4f, Random.Range(1, 2));

        if(pipeSpawnRate <= 0)
        {
            Instantiate(pipePrefab, spawnLocation, Quaternion.identity);
            pipeSpawnRate = 10f;
        }
    }
}
