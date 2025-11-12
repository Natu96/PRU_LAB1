using UnityEngine;

public class MeteoriteMultiSpawner : MonoBehaviour
{
    [Header("Meteorite Variants (Assign 3)")]
    public GameObject[] meteoritePrefabs;
    [Header("Spawn Settings")]
    public float spawnInterval = 2f;
    private float timer;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnRandomMeteorite();
            timer = spawnInterval;
        }
    }

    void SpawnRandomMeteorite()
    {
        if (meteoritePrefabs.Length == 0) return;

        int index = Random.Range(0, meteoritePrefabs.Length);
        GameObject chosenMeteor = meteoritePrefabs[index];

        Instantiate(chosenMeteor, transform.position, Quaternion.identity, transform);
    }
}
