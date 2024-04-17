using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PupuceSpawner : MonoBehaviour
{
    public GameObject[] circlePrefabs;
    public float spawnRate = 0.5f;
    public float fallSpeed = 2f; 
    public float despawnTime = 4f; 

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPupuce();
            timer = 0;
        }
    }

    void SpawnPupuce()
    {
        float randXpos = Random.Range(0f, Screen.width);
        Vector2 spawnPosition = new Vector2(randXpos, Screen.height);

        Vector3 worldSpawnPosition = Camera.main.ScreenToWorldPoint(spawnPosition);
        worldSpawnPosition.z = 0; 

        GameObject chosenPrefab = circlePrefabs[Random.Range(0, circlePrefabs.Length)];

        GameObject newCircle = Instantiate(chosenPrefab, worldSpawnPosition, Quaternion.identity);

        Rigidbody2D rb = newCircle.GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            rb = newCircle.AddComponent<Rigidbody2D>();
        }

        rb.velocity = Vector2.down * fallSpeed;

        Destroy(newCircle, despawnTime);
    }
}
