using UnityEngine;

public class PipeSpawner_Script : MonoBehaviour
{
    [SerializeField]
    private GameObject pipe;
    
    private float timer = 0;
    private float spawnRate = 2;
    private float maxSpawnYOffset = 3;
    private float maxSpawnXOffset = 2;


    // object to spawn, position spawner, rotation of spawner
    private void spawnPipe()
    {
        float lowestPoint = transform.position.y - maxSpawnYOffset;
        float highestPoint = transform.position.y + maxSpawnYOffset;

        Instantiate(pipe, new Vector3(transform.position.x + (Random.Range(0, maxSpawnXOffset))
            ,Random.Range(lowestPoint,highestPoint),0), transform.rotation); 
    }


    void Start()
    {
        spawnPipe(); // for faster game start
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

        
    }
}
