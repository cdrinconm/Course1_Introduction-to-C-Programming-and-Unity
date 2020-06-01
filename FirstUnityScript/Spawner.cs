using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    GameObject PersonajePrefab;

    [SerializeField]
    Sprite Personaje;
    [SerializeField]
    Sprite Buscadores;
    [SerializeField]
    Sprite Enanos;

    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 2;

    Timer spawnTimer;

    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    // Start is called before the first frame update
    void Start()
    {
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer.Finished)
        {
            SpawnBear();

            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }
    }

    void SpawnBear()
    {
        Vector3 location = new Vector3(Random.Range(minSpawnX,maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject pers = Instantiate(PersonajePrefab) as GameObject;
        pers.transform.position = worldLocation;

        SpriteRenderer spriteRenderer = pers.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0,3);
        spriteNumber = 0;
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = Personaje;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = Buscadores;
        }
        else
        {
            spriteRenderer.sprite = Enanos;
        }
    }
}
