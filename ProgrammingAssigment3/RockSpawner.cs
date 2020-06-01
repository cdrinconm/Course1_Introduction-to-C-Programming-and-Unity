using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField]
    GameObject prefabRock;

    //sprites
    [SerializeField]
    Sprite greenrock;
    [SerializeField]
    Sprite magentarock;
    [SerializeField]
    Sprite whiterock;

    // spawn control
    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 1;
    Timer spawnTimer;

    // spawn location support
    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    //Number of rocks
    int rocks;

    // Start is called before the first frame update
    void Start()
    {
        // save spawn boundaries for efficiency
        //minSpawnX = SpawnBorderSize;
        //maxSpawnX = Screen.width - SpawnBorderSize;
        //minSpawnY = SpawnBorderSize;
        //maxSpawnY = Screen.height - SpawnBorderSize;

        minSpawnX = Screen.width / 2;
        maxSpawnX = Screen.width / 2;
        minSpawnY = Screen.height / 2;
        maxSpawnY = Screen.height / 2;

        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        //Count rocks
        rocks = GameObject.FindGameObjectsWithTag("RockTag").Length;
        //print(rocks);
        if (spawnTimer.Finished && rocks < 3)
        {
            SpawnRock();

            // change spawn timer duration and restart
            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }
    }

    void SpawnRock()
    {
        // generate random location and create new teddy bear
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = worldLocation;

        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = greenrock;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = magentarock;
        }
        else
        {
            spriteRenderer.sprite = whiterock;
        }
    }
}
