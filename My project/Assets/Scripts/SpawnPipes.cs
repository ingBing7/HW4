using Unity.VisualScripting;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public float pipeSpawnRate = 0f;

    public GameObject pipePrefab;

    private bool canSpawnPipe = true;

    private void Start()
    {
        Locator.Instance.Player.BirdDied += StopSpawningPipes;
    }

    void Update()
    {
        if(canSpawnPipe == true)
        {
            pipeSpawnRate -= Time.deltaTime;

            Vector2 spawnLocation = new Vector2(4f, Random.Range(-3f, -1f));

            if (pipeSpawnRate <= 0)
            {
                Instantiate(pipePrefab, spawnLocation, Quaternion.identity);
                pipeSpawnRate = 4.5f;
            }
        }
    }

    public void StopSpawningPipes()
    {
        canSpawnPipe = false;
    }
}
